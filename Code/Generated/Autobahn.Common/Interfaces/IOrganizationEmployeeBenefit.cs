//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationEmployeeBenefit.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationEmployeeBenefit Interface
     /// </summary>
    public partial interface IOrganizationEmployeeBenefit : IAutobahnBase
    {
        /// <summary>
        /// Full-Time Employee Benefits
        /// <para>
        /// The benefits offered by a program/facility/employer for full-time staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19866">Full-Time Employee Benefits</a>
        /// </para>
        /// </summary>
        System.Boolean? FullTimeBenefitIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Part-Time Employee Benefits
        /// <para>
        /// The benefits offered by a program/facility/employer for part-time staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19867">Part-Time Employee Benefits</a>
        /// </para>
        /// </summary>
        System.Boolean? PartTimeBenefitIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployeeBenefit"/> model
        /// </summary>
        Guid? RefEmployeeBenefitId { get; set; }

    }
}
