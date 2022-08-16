//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentAdministration.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentAdministration Interface
     /// </summary>
    public partial interface IAssessmentAdministration : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         AssessmentAdministrationPeriodDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FinishDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FinishTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Name { get; set; }

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
         StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StartTime { get; set; }

    }
}
