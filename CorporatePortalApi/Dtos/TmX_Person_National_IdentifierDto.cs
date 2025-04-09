using CorporatePortalApi.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Dtos
{
    public class TmX_Person_National_IdentifierDto: BaseDto
    {
        public int Tenant_ID { get; set; }
        public int Person_National_Identifier_ID { get; set; }
        public int National_ID_Type_Lkp { get; set; }
        public string? National_Identifier_Value { get; set; }
        public DateTime? National_ID_Issue_Date { get; set; }
        public DateTime? National_ID_Expiry_Date { get; set; }
        public string Created_By { get; set; } 
        public string? Last_Updated_By { get; set; } 
        public int Person_ID { get; set; }
        public bool Active_Flag { get; set; }
        public DateTime Effective_Start_Date { get; set; }
        public DateTime Effective_End_Date { get; set; }
        public int? Document_Type { get; set; }
        public Guid? Mobile_ID { get; set; }
        public string? Place_Of_Issue { get; set; }
        public int? Nationality_Lkp { get; set; }
        public int? Order_ID { get; set; }


    }
}
