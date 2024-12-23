using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Dtos
{
    public class TmX_LookupDto
    {

        public int Lookup_ID { get; set; }

        public int? Parent_Lookup_ID { get; set; }

        public int Tenant_ID { get; set; }

        public string? Lookup_Type { get; set; }

        public string? Description { get; set; }

        public bool? Is_Active { get; set; }

        public string? Hidden_Value { get; set; }

        public string? Visible_Value { get; set; }

        public int? User_Editable { get; set; }
        public int? Sort_Order { get; set; }

        public string? Lookup_Name { get; set; }
        public bool? Active_Flag { get; set; }

        public string Created_By { get; set; }

        public string? Created_Date { get; set; } // in script the datatype was nvarchar

        public string? Last_Updated_By { get; set; }

        public DateTime? Last_Updated_Date { get; set; }

        public string? Locale_Label { get; set; }

        public int Locale_ID { get; set; }


    }
}
