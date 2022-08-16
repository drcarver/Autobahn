//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   ILearnerActivity.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The ILearnerActivity Interface
     /// </summary>
    public partial interface ILearnerActivity : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         CreationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DueDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DueTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MaximumAttemptsAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MaximumTimeAllowed { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PossiblePoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Prerequisite { get; set; }

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
        Guid? RefLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearnerActivityAddToGradeBookFlagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearnerActivityTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ReleaseDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RubricUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Weight { get; set; }

    }
}
