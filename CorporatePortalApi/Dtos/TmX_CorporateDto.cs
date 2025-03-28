namespace CorporatePortalApi.Dtos
{
    public class TmX_CorporateDto: BaseDto
    {
        public int Corporate_Id { get; set; }
        public required string Corporate_Name { get; set; }
        public required string Corporate_Code { get; set; }
        public string? Corporate_Description { get; set; }
        public string? Corporate_NTN_Number { get; set; }
        public string? Corporate_Bank_Account { get; set; }
        public string? Corporate_Image { get; set; }
        public string? Corporate_Email_Address { get; set; }
        public string? Corporate_Address { get; set; }
        public string? Corporate_URL { get; set; }
        public int? Default_Product_Id { get; set; }
        public bool Active_Flag { get; set; }
        public string Created_By { get; set; }
		public string? Last_Updated_By { get; set; }
    }
}
