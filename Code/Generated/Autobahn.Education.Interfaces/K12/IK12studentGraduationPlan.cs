//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12studentGraduationPlan.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.K12
{
     /// <summary>
     /// The IK12studentGraduationPlan Interface
     /// </summary>
    public partial interface IK12studentGraduationPlan : IAutobahnBase
    {
        #region IK12studentGraduationPlan
        Decimal? CreditsRequired { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12course"/> model
        /// </summary>
        Guid K12courseId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
        /// </summary>
        Guid? RefGradeLevelWhenCourseTakenId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
        /// </summary>
        Guid? RefScedcourseSubjectAreaId { get; set; }

        #endregion
    }
}
