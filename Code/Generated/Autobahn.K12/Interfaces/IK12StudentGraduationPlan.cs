//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentGraduationPlan.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentGraduationPlan Interface
     /// </summary>
    public partial interface IK12StudentGraduationPlan : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         CreditsRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefGradeLevelWhenCourseTakenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSCEDCourseSubjectAreaId { get; set; }

    }
}
