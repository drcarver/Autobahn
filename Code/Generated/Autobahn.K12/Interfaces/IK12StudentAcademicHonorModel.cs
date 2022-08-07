//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12StudentAcademicHonorModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentAcademicHonorModel Interface
     /// </summary>
    public partial interface IK12StudentAcademicHonorModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicHonorType"/> model
        /// </summary>
        Guid? RefAcademicHonorTypeId { get; set; }

        /// <summary>
        /// Defines the K12StudentAcademicHonor.HonorDescription non nullable property
        /// </summary>
        System.String HonorDescription { get; set; }

    }
}
