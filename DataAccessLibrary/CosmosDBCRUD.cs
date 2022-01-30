using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
	public class CosmosDBCRUD
	{
		private readonly string _endpointuri;
		private readonly string _primarykey;
		private readonly string _databasename;
		private readonly string _employeecontainer;
		private readonly string _managercontainer;
		private readonly string _researchercontainer;
		private readonly CosmosDBDataAccess _employeedb;
		private readonly CosmosDBDataAccess _managerdb;
		private readonly CosmosDBDataAccess _researcherdb;

		public CosmosDBCRUD(string endpointUrl, string primaryKey, string databaseName, string employeeContainer, string managerContainer, string researcherContainer)
		{
			_endpointuri = endpointUrl;
			_primarykey = primaryKey;
			_databasename = databaseName;
			_employeecontainer = employeeContainer;
			_managercontainer = managerContainer;
			_researchercontainer = researcherContainer;
			_employeedb = new CosmosDBDataAccess(_endpointuri, _primarykey, _databasename, _employeecontainer);
			_managerdb = new CosmosDBDataAccess(_endpointuri, _primarykey, _databasename, _managercontainer);
			_researcherdb = new CosmosDBDataAccess(_endpointuri, _primarykey, _databasename, _researchercontainer);
		}

		public Task CreateEmployeeAsync(EmployeeModel employee)
		{
			return _employeedb.CreateRecordAsync(employee);
		}

		public Task CreateManagerAsync(ManagerModel manager)
		{
			return _managerdb.CreateRecordAsync(manager);
		}

		public Task CreateResearcherAsync(ResearcherModel researcher)
		{
			return _researcherdb.CreateRecordAsync(researcher);
		}

		public Task<List<EmployeeModel>> RetrieveAllEmployeesAsync()
		{
			return _employeedb.GetAllRecordsAsync<EmployeeModel>();
		}

		public Task<List<EmployeeModel>> RetrieveEmployeesByPartitionKey(string partitionKey)
		{
			return _employeedb.GetRecordsByPartitionKey<EmployeeModel>(partitionKey);
		}

		public Task<EmployeeModel?> RetrieveEmployeeById(string id)
		{
			return _employeedb.GetRecordById<EmployeeModel>(id);
		}

		public Task<EmployeeModel> RetrieveEmployeeByIdAndPartitionKey(string id, string partitionKey)
		{
			return _employeedb.ReadRecordAsync<EmployeeModel>(id, partitionKey);
		}

		public Task<List<ManagerModel>> RetrieveAllManagersAsync()
		{
			return _managerdb.GetAllRecordsAsync<ManagerModel>();
		}

		public Task<List<ManagerModel>> RetrieveManagersByPartitionKey(string partitionKey)
		{
			return _managerdb.GetRecordsByPartitionKey<ManagerModel>(partitionKey);
		}

		public Task<ManagerModel?> RetrieveManagerById(string id)
		{
			return _managerdb.GetRecordById<ManagerModel>(id);
		}

		public Task<ManagerModel> RetrieveManagerByIdAndPartitionKey(string id, string partitionKey)
		{
			return _managerdb.ReadRecordAsync<ManagerModel>(id, partitionKey);
		}

		public Task<List<ResearcherModel>> RetrieveAllResearchersAsync()
		{
			return _researcherdb.GetAllRecordsAsync<ResearcherModel>();
		}

		public Task<List<ResearcherModel>> RetrieveResearchersByPartitionKey(string partitionKey)
		{
			return _researcherdb.GetRecordsByPartitionKey<ResearcherModel>(partitionKey);
		}

		public Task<ResearcherModel?> RetrieveResearcherById(string id)
		{
			return _researcherdb.GetRecordById<ResearcherModel>(id);
		}

		public Task<ResearcherModel> RetrieveResearcherByIdAndPartitionKey(string id, string partitionKey)
		{
			return _researcherdb.ReadRecordAsync<ResearcherModel>(id, partitionKey);
		}

		public Task UpdateEmployeeAsync(EmployeeModel employee)
		{
			string id = employee.Id.ToString();

			return _employeedb.ReplaceRecordAsync(employee, id);
		}

		public Task UpdateManagerAsync(ManagerModel manager)
		{
			string id = manager.Id.ToString();

			return _managerdb.ReplaceRecordAsync(manager, id);
		}

		public Task UpdateResearcherAsync(ResearcherModel researcher)
		{
			string id = researcher.Id.ToString();

			return _researcherdb.ReplaceRecordAsync(researcher, id);
		}

		public Task DeleteEmployeeAsync(EmployeeModel employee)
		{
			string id = employee.Id.ToString();
			string partitionKey = employee.LastName;

			return _employeedb.DeleteRecordAsync<EmployeeModel>(id, partitionKey);
		}

		public Task DeleteManagerAsync(ManagerModel manager)
		{
			string id = manager.Id.ToString();
			string partitionKey = manager.LastName;

			return _managerdb.DeleteRecordAsync<ManagerModel>(id, partitionKey);
		}

		public Task DeleteResearcherAsync(ResearcherModel researcher)
		{
			string id = researcher.Id.ToString();
			string partitionKey = researcher.LastName;

			return _researcherdb.DeleteRecordAsync<ResearcherModel>(id, partitionKey);
		}

	}
}
