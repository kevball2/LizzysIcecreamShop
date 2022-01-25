using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace DataAccessLibrary.Models
{
	public abstract class WorkerModel
	{
		[JsonProperty(PropertyName = "id")]
		public Guid Id { get; set; } = Guid.NewGuid();
		public string FirstName { get; set; } = string.Empty;
		[JsonProperty(PropertyName = "partitionKey")]
		public string LastName { get; set; } = string.Empty;
		public int Age { get; set; }
		public DateOnly Birthday { get; set; }
		public decimal Wage { get; set; }
		public int NumberOfHoursWorked { get; set; }
		public int EmployeeId { get; set; }
		public DateOnly HireDate { get; set; }
		public DateOnly? TerminationDate { get; set; }
		public string EmployeeType { get; set; } = string.Empty;

		public override string? ToString()
		{
			return JsonConvert.SerializeObject(this);
			;
		}
	}
}
