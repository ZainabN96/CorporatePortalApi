namespace CorporatePortalApi.Dtos
{
    public class TmX_BankDto
    {
        public int Bank_ID { get; set; }
        public string? Bank_Name { get; set; }
        public string Created_By { get; set; }
        public DateTime Created_Date { get; set; }
        public string? Last_Updated_By { get; set; }
        public DateTime? Last_Updated_Date { get; set; }
        public string? Bank_API_Url { get; set; }
        public string? Admin_Username { get; set; }
        public string? Admin_Password { get; set; }
        public string? Bank_Email { get; set; }
        public string? Bank_Contact_Number { get; set; }
        public bool? Data_Sync_Enabled { get; set; }
        public string? Cloud_API_Url { get; set; }
        public string? Cloud_Admin_Username { get; set; }
        public string? Cloud_Admin_Password { get; set; }
        public bool? Parent1_To_Admin_Sync { get; set; }
        public bool? Admin_To_Parent2_Sync { get; set; }
        public bool? Parent2_To_Admin_Sync { get; set; }
        public string? Employment_Type_Hint { get; set; }
        public string? Image { get; set; }
        public bool? Is_Active { get; set; }
        public bool Iframe_Enabled { get; set; }
        public bool Bypass_OTP_Flag { get; set; }
        public bool Is_Visible { get; set; }
    }
}
