using CorporatePortalApi.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Dtos
{
    public class TmX_Customer_DetailDto : BaseDto   
    {
        public int Customer_Detail_ID { get; set; }
        public int? Tax_Filer { get; set; }
        public string? National_Tax_Number { get; set; }
        public DateTime? Customer_Relationship_Contract { get; set; }
        public int? Existing_Account_Holder { get; set; }
        public int? Priority_Customer { get; set; }
        public int? Loyalty_Points { get; set; }
        public int? Ever_Discontinued_Priority { get; set; }
        public int? Reason_For_Discontinuity_Lkp { get; set; }
        public int? Frequency_Of_Contracting_RM_Lkp { get; set; }
        public int? Preferred_Mode_Of_Communication_Lkp { get; set; }
        public string? Relation_With_Banks { get; set; }
        public int Customer_Master_Id { get; set; } // Foreign Key
        public int? SMS_Alert { get; set; }
        public string? Website_Address { get; set; }
        public string? Customer_Profile { get; set; }
        public int? High_Risk_Approval { get; set; }
        public int? Political_Figure_Approved_Obtained { get; set; }
        public string? Political_Figure_Name { get; set; }
        public int? Relative_Political_Figure { get; set; }
        public int? Risk_Level { get; set; }
        public string? Sources_Of_Funds { get; set; }   

        public string? Expected_Cities_Txn { get; set; }
        public string? Expected_Countries_Txn { get; set; }
        public string? Expected_Counter_Parties { get; set; }   

        public string? Branch_Comments { get; set; }

        public int Tenant_ID { get; set; } // Foreign Key   
        public string Created_By { get; set; } = string.Empty;


        public string? Last_Updated_By { get; set; }

      

        public decimal? Customer_Total_Family_Income_Amount { get; set; }

        public decimal? Customer_Total_Family_Expense_Amount { get; set; }

        public int? Currency_ID { get; set; }

        public int? Person_ID { get; set; } //foreign key

        public decimal? Customer_Total_Self_Income_Amount { get; set; }

        public decimal? Customer_Total_Self_Expense_Amount { get; set; }
        public bool Active_Flag { get; set; }
        public DateTime Effective_Start_Date { get; set; }
        public DateTime Effective_End_Date { get; set; }

        public Guid? Mobile_ID { get; set; }

    }

}
