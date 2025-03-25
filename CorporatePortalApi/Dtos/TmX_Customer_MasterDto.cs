using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Dtos
{
	public class TmX_Customer_MasterDto: BaseDto
	{
		public int Customer_Master_Id { get; set; }
		public string? Customer_Code { get; set; }
		public string? Customer_Title { get; set; }
		public string? Customer_Name { get; set; }
		public int? Customer_Type_Lkp { get; set; }
		public int? Customer_Classification_Lkp { get; set; }
		public DateTime? Effective_Start_Date { get; set; }
		public DateTime? Effective_End_Date { get; set; }
		public string Created_By { get; set; }
		public string? Last_Updated_By { get; set; }
		public int Tenant_Id { get; set; }
		public int? Location_Id { get; set; }
		public string? Multi_Site_Customer_Flag { get; set; }
		public int? National_ID_Type_Lkp { get; set; }
		public string? National_Identifier_Value { get; set; }
		public int? Customer_Status_Lkp { get; set; }
		public int? FATCA_Class_Lkp { get; set; }
		public int? Relationship_Code_Lkp { get; set; }
		public int? Customer_Segment_Lkp { get; set; }
		public int? Customer_Sub_Segment_Lkp { get; set; }
		public int? Entity_Type_Lkp { get; set; }
		public int? Same_As_Above_Lkp { get; set; }
		public int? ETB_Flag { get; set; }
		public string? udf_data { get; set; }
		public bool NTI_Flag { get; set; } = true;
		public string? FRMU_Status { get; set; }
		public string? SLS_Status { get; set; }
		public bool? neg_customer { get; set; }
		public bool? neg_area { get; set; }
		public Guid? Mobile_ID { get; set; }
		public int? Transaction_Id { get; set; }
		public decimal? Suggested_Loan_Amount { get; set; }
		public bool? Is_SA_User { get; set; }
		public bool? SA_User_Created { get; set; }
		public string? Customer_Phone_Number { get; set; }
		public string? Customer_Email_Address { get; set; }
		public decimal? Customer_Total_Limit { get; set; }
		public bool Is_Active { get; set; } = true;
	}
}
