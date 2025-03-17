using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorporatePortalApi.Models
{
	public class TmX_Person
	{
		[Key]
		public int Person_ID { get; set; }

		[Required]
		[MaxLength(50)]
		public string Person_First_Name { get; set; }

		public DateTime? Person_Date_Of_Birth { get; set; }
		public int? Person_Gender_Lkp { get; set; }

		[Required]
		[MaxLength(50)]
		public string Created_By { get; set; }

		[Required]
		public DateTime Created_Date { get; set; }

		[MaxLength(50)]
		public string? Last_Updated_By { get; set; }
		public DateTime? Last_Updated_Date { get; set; }

		[Required]
		public int Tenant_ID { get; set; }

		[MaxLength(100)]
		public string? Person_Middle_Name { get; set; }

		[Required]
		[MaxLength(100)]
		public string Person_Last_Name { get; set; }

		[Required]
		public bool Active_Flag { get; set; }

		[Required]
		public DateTime Effective_Start_Date { get; set; }
		[Required]
		public DateTime Effective_End_Date { get; set; }

		public int? Person_Marital_Status_Lkp { get; set; }
		[MaxLength(100)]
		public string? Person_Birth_Name { get; set; }
		[MaxLength(100)]
		public string? Person_Calling_Name { get; set; }

		public int? Person_Education_Lkp { get; set; }
		public int? Person_Residence_Lkp { get; set; }
		public decimal? Person_Residence_Duration { get; set; }

		[MaxLength(100)]
		public string? Person_Religion { get; set; }
		public bool? Family_Head_Flag { get; set; }
		[MaxLength(100)]
		public string? Person_Technical_Vocational_Training { get; set; }
		public int? Person_Technical_Vocational_Training_Type_Lkp { get; set; }
		public bool? Person_Disability_Flag { get; set; }
		[MaxLength(100)]
		public string? Person_Disability_Nature { get; set; }
		public bool? Family_Earning_Member_Flag { get; set; }

		public int? Person_Health_Lkp { get; set; }
		public int? Person_Profession_Type_Lkp { get; set; }
		public decimal? Person_Total_Income_Amount { get; set; }
		public decimal? Person_Total_Expense_Amount { get; set; }

		public DateTime? Person_Wedding_Date { get; set; }
		[MaxLength(500)]
		public string? Person_Current_Address { get; set; }
		[MaxLength(500)]
		public string? Person_Permanent_Address { get; set; }

		public int? Currency_ID { get; set; }

		[MaxLength(100)]
		public string? Person_Family_Identifier { get; set; }
		public int? Family_Children_Count { get; set; }
		public int? Family_Dependent_Count { get; set; }
		public int? Family_Members_Count { get; set; }
		public int? Family_Migrants_Count { get; set; }
		public int? Family_Earning_Members_Count { get; set; }

		public int? Person_Nationality_Lkp { get; set; }
		public int? Place_Of_Birth_Lkp { get; set; }
		[MaxLength(200)]
		public string? Person_Hobbies { get; set; }
		public int? Person_Language_Preference_Lkp { get; set; }

		public string? UDF_Data { get; set; }
		public Guid? Mobile_ID { get; set; }

		[ForeignKey("Currency_ID")]
		public virtual TmX_Currency Currency { get; set; }

		[ForeignKey("Tenant_ID")]
		public virtual TmX_Tenant Tenant { get; set; }

	}
}
