//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAidAward.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The FinancialAidAward
     /// </summary>
    public partial class FinancialAidAward : IFinancialAidAward
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
        /// Defines the FinancialAidAward.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FinancialAidAward.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
