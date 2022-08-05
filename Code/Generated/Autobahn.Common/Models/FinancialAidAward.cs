//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAidAward.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The FinancialAidAward
     /// </summary>
    public partial class FinancialAidAward : AutobahnBase, Interfaces.IFinancialAidAward
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidAwardType"/> model
        /// </summary>
        public Guid? RefFinancialAidAwardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidStatus"/> model
        /// </summary>
        public Guid? RefFinancialAidStatusId { get; set; }

        /// <summary>
        /// Defines the FinancialAidAward.FinancialAidAwardAmount nullable property
        /// </summary>
        public System.Decimal? FinancialAidAwardAmount { get; set; }

        /// <summary>
        /// Defines the FinancialAidAward.FinancialAidYearDesignator non nullable property
        /// </summary>
        public System.String FinancialAidYearDesignator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
