//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IAssessmentItemCharacteristic.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Assessments
{
     /// <summary>
     /// The IAssessmentItemCharacteristic Interface
     /// </summary>
    public partial interface IAssessmentItemCharacteristic : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
        /// </summary>
        Guid AssessmentItemId { get; set; }

        /// <summary>
        /// Assessment Item Characteristic Type
        /// <para>
        /// The type of psychometric measure provided for assessment item.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19384">Assessment Item Characteristic Type</a>
        /// </para>
        /// </summary>
        Guid? RefAssessmentItemCharacteristicTypeId { get; set; }

        /// <summary>
        /// Assessment Item Response Choice Pattern
        /// <para>
        /// The distribution of responses for each choice in the assessment item.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19385">Assessment Item Response Choice Pattern</a>
        /// </para>
        /// </summary>
        System.String ResponseChoicePattern { get; set; }

        /// <summary>
        /// Assessment Item Characteristic Value
        /// <para>
        /// A psychometric measure provided for an assessment item.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19685">Assessment Item Characteristic Value</a>
        /// </para>
        /// </summary>
        System.String Value { get; set; }

    }
}
