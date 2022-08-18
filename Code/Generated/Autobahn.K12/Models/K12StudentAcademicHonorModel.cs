//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentAcademicHonorModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentAcademicHonor Model
     /// </summary>
    public partial class K12StudentAcademicHonorModel : AutobahnBase, Interfaces.IK12StudentAcademicHonor
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
        public System.String HonorDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicHonorType"/> model
        /// </summary>
        public Guid? RefAcademicHonorTypeId { get; set; }

    }
}
