//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IFinancialAidAward.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IFinancialAidAward Interface
     /// </summary>
    public partial interface IFinancialAidAward : IAutobahnBase
    {
        /// <summary>
        /// The amount of financial aid awarded to a person for the term/year.
        /// </summary>
        System.Decimal? FinancialAidAwardAmount { get; set; }

        /// <summary>
        /// The amount of financial aid awarded to a person for the term/year.
        /// </summary>
        System.String FinancialAidYearDesignator { get; set; }

        /// <summary>
        /// The amount of financial aid awarded to a person for the term/year.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The amount of financial aid awarded to a person for the term/year.
        /// </summary>
        Guid? RefFinancialAidAwardTypeId { get; set; }

        /// <summary>
        /// The amount of financial aid awarded to a person for the term/year.
        /// </summary>
        Guid? RefFinancialAidStatusId { get; set; }

    }
}
