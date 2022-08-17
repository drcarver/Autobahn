//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentAcademicHonor.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentAcademicHonor Interface
     /// </summary>
    public partial interface IK12StudentAcademicHonor : IAutobahnBase
    {
        /// <summary>
        /// Honors Description
        /// <para>
        /// A description of the type of academic distinctions earned by or awarded to the person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19150">Honors Description</a>
        /// </para>
        /// </summary>
        System.String HonorDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAcademicHonorType"/> model
        /// </summary>
        Guid? RefAcademicHonorTypeId { get; set; }

    }
}
