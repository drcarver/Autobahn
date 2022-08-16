//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentDiscipline.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentDiscipline Interface
     /// </summary>
    public partial interface IK12StudentDiscipline : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? DisciplinaryActionEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DisciplinaryActionStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DurationOfDisciplinaryAction { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EducationalServicesAfterRemoval { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FullYearExpulsion { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IEPPlacementMeetingIndicator { get; set; }

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
         RefDisciplinaryActionTakenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefDisciplineLengthDifferenceReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefDisciplineMethodFirearmsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefDisciplineMethodOfCwdId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefDisciplineReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIDEADisciplineMethodFirearmId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIdeaInterimRemovalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIdeaInterimRemovalReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RelatedToZeroTolerancePolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ShortenedExpulsion { get; set; }

    }
}
