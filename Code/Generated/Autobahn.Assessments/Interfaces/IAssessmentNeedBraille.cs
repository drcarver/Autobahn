//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentNeedBraille.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedBraille Interface
     /// </summary>
    public partial interface IAssessmentNeedBraille : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         BrailleDotPressure { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NumberOfBrailleCells { get; set; }

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
         RefAssessmentNeedBrailleGradeTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentNeedBrailleMarkTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentNeedBrailleStatusCellTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefAssessmentNeedNumberOfBrailleDotsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefAssessmentNeedUsageTypeId { get; set; }

    }
}
