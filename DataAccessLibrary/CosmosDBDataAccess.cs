using Microsoft.Azure.Cosmos;

namespace DataAccessLibrary
{
	internal class CosmosDBDataAccess
	{
		private readonly string _endpointuri;
		private readonly string _primarykey;
		private readonly string _databasename;
		private readonly string _containername;
		private readonly CosmosClient _cosmosclient;
		private readonly Database _database;
		private readonly Container _container;

		internal CosmosDBDataAccess(string endpointUrl, string primaryKey, string databaseName, string containerName)
		{
			_endpointuri = endpointUrl;
			_primarykey = primaryKey;
			_databasename = databaseName;
			_containername = containerName;

			_cosmosclient = new CosmosClient(_endpointuri, _primarykey);
			_database = _cosmosclient.GetDatabase(_databasename);
			_container = _database.GetContainer(_containername);
		}

		internal async Task CreateRecordAsync<T>(T record)
		{
			await _container.CreateItemAsync(record);
		}

		internal async Task<List<T>> GetAllRecordsAsync<T>()
		{
			string sqlQueryText = "SELECT * FROM c";

			QueryDefinition queryDefinition = new QueryDefinition(sqlQueryText);
			FeedIterator<T> feedIterator = _container.GetItemQueryIterator<T>(queryDefinition);

			List<T> output = new List<T>();

			while ( feedIterator.HasMoreResults )
			{
				FeedResponse<T> currentResultsSet = await feedIterator.ReadNextAsync();

				foreach ( T result in currentResultsSet )
				{
					output.Add(result);
				}
			}

			return output;
		}

		internal async Task<T?> GetRecordById<T>(string id)
		{
			T? output = default(T);

			string sqlQueryText = "SELECT * FROM c WHERE c.id = @Id";

			QueryDefinition queryDefinition = new QueryDefinition(sqlQueryText).WithParameter("@Id", id);
			FeedIterator<T> feedIterator = _container.GetItemQueryIterator<T>(queryDefinition);

			while ( feedIterator.HasMoreResults )
			{
				FeedResponse<T> currentResultsSet = await feedIterator.ReadNextAsync();
				foreach ( T result in currentResultsSet )
				{
					output = result;
				}
			}

			return output;
		}

		internal async Task<List<T>> GetRecordsByPartitionKey<T>(string partitionKey)
		{
			string sqlQueryText = "SELECT * FROM c WHERE c.PartitionKey = @PartitionKey";

			QueryDefinition queryDefinition = new QueryDefinition(sqlQueryText).WithParameter("@PartitionKey", partitionKey);
			FeedIterator<T> feedIterator = _container.GetItemQueryIterator<T>(queryDefinition);

			List<T> output = new List<T>();

			while ( feedIterator.HasMoreResults )
			{
				FeedResponse<T> currentResultsSet = await feedIterator.ReadNextAsync();

				foreach ( T result in currentResultsSet )
				{
					output.Add(result);
				}
			}

			return output;
		}

		internal async Task<T> ReadRecordAsync<T>(string id, string partitionKey)
		{
			PartitionKey partition = new PartitionKey(partitionKey);

			ItemResponse<T> response = await _container.ReadItemAsync<T>(id, partition);
			T output = response.Resource;

			return output;
		}

		internal async Task ReplaceRecordAsync<T>(T record, string id)
		{
			await _container.ReplaceItemAsync(record, id);
		}

		internal async Task UpsertRecordAsync<T>(T record)
		{
			await _container.UpsertItemAsync(record);
		}

		internal async Task DeleteRecordAsync<T>(string id, string partitionKey)
		{
			PartitionKey partition = new PartitionKey(partitionKey);

			await _container.DeleteItemAsync<T>(id, partition);
		}
	}
}
