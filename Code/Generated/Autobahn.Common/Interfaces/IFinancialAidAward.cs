//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IFinancialAidAward.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IFinancialAidAward
     /// </summary>
    public partial interface IFinancialAidAward
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidAwardType"/> model
        /// </summary>
        Guid? RefFinancialAidAwardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidStatus"/> model
        /// </summary>
        Guid? RefFinancialAidStatusId { get; set; }

        /// <summary>
        /// Defines the FinancialAidAward.FinancialAidAwardAmount nullable property
        /// </summary>
        System.Decimal? FinancialAidAwardAmount { get; set; }

        /// <summary>
        /// Defines the FinancialAidAward.FinancialAidYearDesignator non nullable property
        /// </summary>
        System.String FinancialAidYearDesignator { get; set; }

        /// <summary>
        /// Defines the FinancialAidAward.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the FinancialAidAward.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
