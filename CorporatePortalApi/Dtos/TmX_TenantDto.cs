namespace CorporatePortalApi.Dtos
{
    public class TmX_TenantDto: BaseDto
	{
        public int Tenant_ID { get; set; }
        public string Tenant_Name { get; set; }
        public DateTime? Tenant_Registration_Date { get; set; }
        public DateTime? Tenant_Activation_Date { get; set; }
        public bool? Tenant_Blocked_Flag { get; set; }
        public bool Active_Flag { get; set; }
        public DateTime Effective_Start_Date { get; set; }
        public DateTime Effective_End_Date { get; set; }
        public string Created_By { get; set; }
        public string? Last_Updated_By { get; set; }
    }
}
