//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentNeedBraille.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentNeedBraille
     /// </summary>
    public partial class AssessmentNeedBraille : AutobahnBase, Interfaces.IAssessmentNeedBraille
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileDisplay"/> model
        /// </summary>
        public Guid? AssessmentPersonalNeedsProfileDisplayId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedUsageType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleGradeType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedBrailleGradeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedNumberOfBrailleDots"/> model
        /// </summary>
        public Guid? RefAssessmentNeedNumberOfBrailleDotsId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedBraille.NumberOfBrailleCells nullable property
        /// </summary>
        public System.Int32? NumberOfBrailleCells { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleMarkType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedBrailleMarkTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentNeedBraille.BrailleDotPressure nullable property
        /// </summary>
        public System.Decimal? BrailleDotPressure { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedBrailleStatusCellType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedBrailleStatusCellTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
