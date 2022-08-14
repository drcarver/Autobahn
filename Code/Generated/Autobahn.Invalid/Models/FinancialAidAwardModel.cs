//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   FinancialAidAwardModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The FinancialAidAward Model
     /// </summary>
    public partial class FinancialAidAwardModel : AutobahnBase, Interfaces.IFinancialAidAward
    {
        /// <summary>
        /// The amount of financial aid awarded to a person for the term/year.
        /// </summary>
        public System.Decimal? FinancialAidAwardAmount { get; set; }

        /// <summary>
        /// The amount of financial aid awarded to a person for the term/year.
        /// </summary>
        public System.String FinancialAidYearDesignator { get; set; }

        /// <summary>
        /// The amount of financial aid awarded to a person for the term/year.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The amount of financial aid awarded to a person for the term/year.
        /// </summary>
        public Guid? RefFinancialAidAwardTypeId { get; set; }

        /// <summary>
        /// The amount of financial aid awarded to a person for the term/year.
        /// </summary>
        public Guid? RefFinancialAidStatusId { get; set; }

    }
}
