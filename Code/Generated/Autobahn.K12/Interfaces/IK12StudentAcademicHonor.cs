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
        /// A designation of the type of academic distinctions earned by or awarded to the student.
        /// </summary>
        System.String HonorDescription { get; set; }

        /// <summary>
        /// A designation of the type of academic distinctions earned by or awarded to the student.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// A designation of the type of academic distinctions earned by or awarded to the student.
        /// </summary>
        Guid? RefAcademicHonorTypeId { get; set; }

    }
}
