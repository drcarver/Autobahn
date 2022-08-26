//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentAcademicHonorModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12studentAcademicHonor Model
     /// </summary>
    public partial class K12studentAcademicHonorModel : AutobahnBase, IK12studentAcademicHonor
    {
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
