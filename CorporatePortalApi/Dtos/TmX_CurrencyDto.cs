namespace CorporatePortalApi.Dtos
{
    public class TmX_CurrencyDto
    {
        public int Currency_ID { get; set; }
        public bool Active_Flag { get; set; }
        public DateTime Effective_Start_Date { get; set; }
        public DateTime Effective_End_Date { get; set; }
        public string? Currency_Code { get; set; }
        public string Currency_Symbol { get; set; }
        public string? Currency_Description { get; set; }
        public string Created_By { get; set; }
        public DateTime Created_Date { get; set; }
        public string? Last_Updated_By { get; set; }
        public DateTime? Last_Updated_Date { get; set; }
    }
}
