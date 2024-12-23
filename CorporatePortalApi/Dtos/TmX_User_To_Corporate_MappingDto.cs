namespace CorporatePortalApi.Dtos
{
    public class TmX_User_To_Corporate_MappingDto
    {
        public int User_To_Corporate_Mapping_Id { get; set; }
        public string User_Id { get; set; }
        public int Corporate_Id { get; set; }
        public bool Active_Flag { get; set; }
        public DateTime Effective_Start_Date { get; set; }
        public DateTime? Effective_End_Date { get; set; }
        public string Created_By { get; set; }
        public DateTime Created_Date { get; set; }
        public string Last_Updated_By { get; set; }
        public DateTime? Last_Updated_Date { get; set; }
    }
}
