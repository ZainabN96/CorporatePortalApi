﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CorporatePortalApi.Models
{
    public class TmX_Product
    {
        [Key]
        public int Product_ID { get; set; }

        public int Tenant_ID { get; set; }

        [MaxLength(50)]
        public string? Product_Code { get; set; }

		[Required]
        [MaxLength(100)]
        public string Product_Name { get; set; } = string.Empty;

		[MaxLength(100)]
        public string? Product_Description { get; set; }

		public int Product_Type_Lkp { get; set; }

        public int? Product_Tenure_Months { get; set; }

        public int? Repayment_Mode_Lkp { get; set; }

        public int? Repayment_Frequency_Lkp { get; set; }

		[Column(TypeName = "numeric(9,4)")]
		public decimal? Documentation_Fee { get; set; }

		[Column(TypeName = "numeric(9,4)")]
		public decimal? Service_Fee { get; set; }

		[Column(TypeName = "numeric(9,4)")]
		public decimal? Processing_Fee { get; set; }

        public int Currency_ID { get; set; }

        public bool Group_Flag { get; set; }

        [MaxLength(100)]
        public string? Workflow_Scheme_Code { get; set; }

		public bool Individual_Flag { get; set; }

        public bool Active_Flag { get; set; }

        public DateTime Effective_Start_Date { get; set; }

        public DateTime Effective_End_Date { get; set; }

        [MaxLength(100)]
        public string? Created_By { get; set; }

		public DateTime Created_Date { get; set; }

        [MaxLength(100)]
        public string? Last_Updated_By { get; set; }

        public DateTime? Last_Updated_Date { get; set; }

        public int? Product_Classification_Lkp { get; set; }

        public int? Bank_Id { get; set; }

        public bool Execute_Parser_Scorecard_Flag { get; set; }

        public bool Manual_Doc_Collection_Enabled_Flag { get; set; }

        public int? Monthly_Repayment_Due_Day { get; set; }

        public string? Shortlisting_Rules_Lookup { get; set; }

		[Column(TypeName = "decimal(18,0)")]
		public decimal? Max_Allowed_Loan_Limit { get; set; }

        public int? Max_Sub_Product_Count { get; set; }

        public bool? Ask_Bank_Details_Flag { get; set; }

        [MaxLength(50)]
        public string? Company_Name { get; set; }

        public string? Company_Address { get; set; }

        public bool? PDC_Flag { get; set; }

        public bool Payment_Allowed { get; set; }

        public bool Onboarded_Corportate_Employees { get; set; }

       // Navigation Properties
       [ForeignKey("Currency_ID")]
       public virtual required TmX_Currency Currency { get; set; }

       [ForeignKey("Bank_Id")]
       public virtual TmX_Bank? Bank { get; set; }

       [ForeignKey("Tenant_ID")]
       public virtual TmX_Tenant? Tenant { get; set; }
    }
}
