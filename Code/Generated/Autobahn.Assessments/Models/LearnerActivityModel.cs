//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActivityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The LearnerActivity Model
     /// </summary>
    public partial class LearnerActivityModel : AutobahnBase, Interfaces.ILearnerActivity
    {
        /// <summary>
        /// 
        /// </summary>
        public  CreationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DueDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DueTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MaximumAttemptsAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MaximumTimeAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PossiblePoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Prerequisite { get; set; }

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
        public Guid? RefLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearnerActivityAddToGradeBookFlagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearnerActivityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ReleaseDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RubricUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Weight { get; set; }

    }
}
