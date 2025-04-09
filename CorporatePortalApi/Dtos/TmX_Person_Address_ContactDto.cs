namespace CorporatePortalApi.Dtos
{
    public class TmX_Person_Address_ContactDto : BaseDto
    {
        public int Tenant_ID { get; set; }
        public int Person_Address_Contact_ID { get; set; }
        public string Created_By { get; set; } = string.Empty;
      
        public string? Last_Updated_By { get; set; }
        public int Contact_Type_Lkp { get; set; }
        public bool Active_Flag { get; set; }
        public DateTime Effective_Start_Date { get; set; }
        public DateTime Effective_End_Date { get; set; }
        public string? Contact_Number { get; set; }
        public string? Contact_Extension { get; set; }
        public bool Primary_Contact_Flag { get; set; }
        public string? Contact_Email_Address { get; set; }
        public int Person_To_Address_Map_ID { get; set; }
        public Guid? Mobile_ID { get; set; }    
    }
}
