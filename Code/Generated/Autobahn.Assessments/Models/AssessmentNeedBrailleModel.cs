//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedBrailleModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentNeedBraille Model
     /// </summary>
    public partial class AssessmentNeedBrailleModel : AutobahnBase, Interfaces.IAssessmentNeedBraille
    {
        /// <summary>
        /// 
        /// </summary>
        public  BrailleDotPressure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfBrailleCells { get; set; }

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
        public  RefAssessmentNeedBrailleGradeTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentNeedBrailleMarkTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentNeedBrailleStatusCellTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAssessmentNeedNumberOfBrailleDotsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefAssessmentNeedUsageTypeId { get; set; }

    }
}
