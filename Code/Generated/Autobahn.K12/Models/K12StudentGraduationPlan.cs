//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentGraduationPlan.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentGraduationPlan
     /// </summary>
    public partial class K12StudentGraduationPlan : AutobahnBase, Interfaces.IK12StudentGraduationPlan
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12Course"/> model
        /// </summary>
        public Guid K12CourseId { get; set; }

        /// <summary>
        /// Defines the K12StudentGraduationPlan.CreditsRequired nullable property
        /// </summary>
        public System.Decimal? CreditsRequired { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSCEDCourseSubjectArea"/> model
        /// </summary>
        public Guid? RefSCEDCourseSubjectAreaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
        /// </summary>
        public Guid? RefGradeLevelWhenCourseTakenId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
