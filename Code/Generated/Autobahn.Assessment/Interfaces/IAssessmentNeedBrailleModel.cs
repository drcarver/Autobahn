//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentNeedBrailleModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentNeedBrailleModel Interface
     /// </summary>
    public partial interface IAssessmentNeedBrailleModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileDisplay"/> model
        /// </summary>
        Guid? AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUsageType"/> model
        /// </summary>
        Guid? RefAssessmentNeedUsageTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleGradeType"/> model
        /// </summary>
        Guid? RefAssessmentNeedBrailleGradeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedNumberOfBrailleDots"/> model
        /// </summary>
        Guid? RefAssessmentNeedNumberOfBrailleDotsId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedBraille.NumberOfBrailleCells nullable property
        /// </summary>
        System.Int32? NumberOfBrailleCells { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleMarkType"/> model
        /// </summary>
        Guid? RefAssessmentNeedBrailleMarkTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedBraille.BrailleDotPressure nullable property
        /// </summary>
        System.Decimal? BrailleDotPressure { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleStatusCellType"/> model
        /// </summary>
        Guid? RefAssessmentNeedBrailleStatusCellTypeId { get; set; }

    }
}
