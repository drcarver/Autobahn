//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmployeeBenefitModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationEmployeeBenefit Model
     /// </summary>
    public partial class OrganizationEmployeeBenefitModel : AutobahnBase, Interfaces.IOrganizationEmployeeBenefit
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
        public System.Boolean? FullTimeBenefitIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Part-Time Employee Benefits
        /// <para>
        /// The benefits offered by a program/facility/employer for part-time staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19867">Part-Time Employee Benefits</a>
        /// </para>
        /// </summary>
        public System.Boolean? PartTimeBenefitIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployeeBenefit"/> model
        /// </summary>
        public Guid? RefEmployeeBenefitId { get; set; }

    }
}
