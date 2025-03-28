using CorporatePortalApi.Models;

namespace CorporatePortalApi.Dtos
{
    public class TmX_UserDto: BaseDto
	{
        public string User_ID { get; set; }
        public string Parent_User_ID { get; set; }
        public int Tenant_ID { get; set; }
        public int? Location_ID { get; set; }
        public int? Address_ID { get; set; }
        public int? Time_Zone_ID { get; set; }
        public string User_Name { get; set; }
        public string First_Name { get; set; }
        public string Email_Address { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string Contact_Number { get; set; }
        public string User_Image_URL { get; set; }
        public string Primary_National_Identifier_Value { get; set; }
        public bool? Mobile_User_Flag { get; set; }
        public bool Active_Flag { get; set; }
        public DateTime Effective_Start_Date { get; set; }
        public DateTime Effective_End_Date { get; set; }
        public string Created_By { get; set; }
        public string Last_Updated_By { get; set; }
        public int? Primary_National_ID_Type_Lkp_ID { get; set; }
        public int? User_Type_Lkp_ID { get; set; }
        public int? Designation_Lkp_ID { get; set; }
        public string Server_User_ID { get; set; }
        public string Server_Branch_ID { get; set; }
    }
}
