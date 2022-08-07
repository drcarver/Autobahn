//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentAcademicHonorModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentAcademicHonor Model
     /// </summary>
    public partial class K12StudentAcademicHonorModel : AutobahnBase, Interfaces.IK12StudentAcademicHonorModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicHonorType"/> model
        /// </summary>
        public Guid? RefAcademicHonorTypeId { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicHonor.HonorDescription non nullable property
        /// </summary>
        public System.String HonorDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
