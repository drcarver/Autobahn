//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentItemCharacteristic.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentItemCharacteristic
     /// </summary>
    public partial class AssessmentItemCharacteristic : AutobahnBase, Interfaces.IAssessmentItemCharacteristic
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemCharacteristicType"/> model
        /// </summary>
        public Guid? RefAssessmentItemCharacteristicTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentItemCharacteristic.Value non nullable property
        /// </summary>
        public System.String Value { get; set; }

        /// <summary>
        /// Defines the AssessmentItemCharacteristic.ResponseChoicePattern non nullable property
        /// </summary>
        public System.String ResponseChoicePattern { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
