//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFinancialModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationFinancial Model
     /// </summary>
    public partial class OrganizationFinancialModel : AutobahnBase, Interfaces.IOrganizationFinancial
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? ActualValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BudgetedValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EncumberedValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FiscalPeriodBeginDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FiscalPeriodEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FiscalYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Value { get; set; }

    }
}
