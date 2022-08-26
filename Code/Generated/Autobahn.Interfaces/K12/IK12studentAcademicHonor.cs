//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12studentAcademicHonor.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12studentAcademicHonor Interface
     /// </summary>
    public partial interface IK12studentAcademicHonor : IAutobahnBase
    {
        System.String HonorDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicHonorType"/> model
        /// </summary>
        Guid? RefAcademicHonorTypeId { get; set; }

    }
}
