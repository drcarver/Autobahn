//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IFinancialAidAwardModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IFinancialAidAwardModel Interface
     /// </summary>
    public partial interface IFinancialAidAwardModel : IAutobahnBase
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

    }
}
