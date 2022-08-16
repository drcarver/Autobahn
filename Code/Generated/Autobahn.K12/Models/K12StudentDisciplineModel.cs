//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentDisciplineModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentDiscipline Model
     /// </summary>
    public partial class K12StudentDisciplineModel : AutobahnBase, Interfaces.IK12StudentDiscipline
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? DisciplinaryActionEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DisciplinaryActionStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DurationOfDisciplinaryAction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EducationalServicesAfterRemoval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FullYearExpulsion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IEPPlacementMeetingIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefDisciplinaryActionTakenId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefDisciplineLengthDifferenceReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefDisciplineMethodFirearmsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefDisciplineMethodOfCwdId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefDisciplineReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIDEADisciplineMethodFirearmId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIdeaInterimRemovalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIdeaInterimRemovalReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RelatedToZeroTolerancePolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ShortenedExpulsion { get; set; }

    }
}
