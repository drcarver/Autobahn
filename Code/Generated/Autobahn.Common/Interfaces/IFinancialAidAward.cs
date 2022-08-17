//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IFinancialAidAward.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IFinancialAidAward Interface
     /// </summary>
    public partial interface IFinancialAidAward : IAutobahnBase
    {
        /// <summary>
        /// Financial Aid Award Amount
        /// <para>
        /// The amount of financial aid awarded to a person for the term/year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19112">Financial Aid Award Amount</a>
        /// </para>
        /// </summary>
        System.Decimal? FinancialAidAwardAmount { get; set; }

        /// <summary>
        /// Financial Aid Year Designator
        /// <para>
        /// The school year for which the student's financial aid application and award data apply.  Generally, this is the 12-month period from July 1 to June 30.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20590">Financial Aid Year Designator</a>
        /// </para>
        /// </summary>
        System.String FinancialAidYearDesignator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFinancialAidAwardType"/> model
        /// </summary>
        Guid? RefFinancialAidAwardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFinancialAidStatus"/> model
        /// </summary>
        Guid? RefFinancialAidStatusId { get; set; }

    }
}
