using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Dtos
{
	public class TmX_Person_Income_DetailDto: BaseDto
	{
		public int Person_Income_Detail_ID { get; set; }

		public int? Income_Source_Lkp { get; set; }

		public decimal? Monthly_Income_Amount { get; set; }

		public int Tenant_ID { get; set; }

		public int? Currency_ID { get; set; }

		public string Created_By { get; set; }

		public string? Last_Updated_By { get; set; }

		public bool? Active_Flag { get; set; }

		public DateTime? Effective_Start_Date { get; set; }

		public DateTime? Effective_End_Date { get; set; }

		public int? Salary_Income_Mode_Lkp { get; set; }

		public int Person_ID { get; set; }

		public Guid? Mobile_ID { get; set; }

		public string? UDF_Data { get; set; }

		public int? Order_ID { get; set; }
	}
}
