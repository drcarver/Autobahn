//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemCharacteristicModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentItemCharacteristic Model
     /// </summary>
    public partial class AssessmentItemCharacteristicModel : AutobahnBase, Interfaces.IAssessmentItemCharacteristic
    {
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
        public Guid? RefAssessmentItemCharacteristicTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ResponseChoicePattern { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Value { get; set; }

    }
}
