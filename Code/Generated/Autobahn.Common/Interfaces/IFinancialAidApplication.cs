//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IFinancialAidApplication.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IFinancialAidApplication Interface
     /// </summary>
    public partial interface IFinancialAidApplication : IAutobahnBase
    {
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
        /// Reference to an optional instance of the <see cref="IRefFinancialAidApplicationType"/> model
        /// </summary>
        Guid RefFinancialAidApplicationTypeId { get; set; }

    }
}
