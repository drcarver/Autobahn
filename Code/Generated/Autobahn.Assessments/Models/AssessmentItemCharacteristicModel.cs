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
        /// The type of psychometric measure provided for assessment item.
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// The type of psychometric measure provided for assessment item.
        /// </summary>
        public Guid? RefAssessmentItemCharacteristicTypeId { get; set; }

        /// <summary>
        /// The type of psychometric measure provided for assessment item.
        /// </summary>
        public System.String ResponseChoicePattern { get; set; }

        /// <summary>
        /// The type of psychometric measure provided for assessment item.
        /// </summary>
        public System.String Value { get; set; }

    }
}
