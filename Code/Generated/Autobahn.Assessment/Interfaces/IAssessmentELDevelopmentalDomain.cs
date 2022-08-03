//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentELDevelopmentalDomain.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentELDevelopmentalDomain
     /// </summary>
    public partial interface IAssessmentELDevelopmentalDomain
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Assessment"/> model
        /// </summary>
        Guid AssessmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentELDevelopmentalDomain"/> model
        /// </summary>
        Guid RefAssessmentELDevelopmentalDomainId { get; set; }

        /// <summary>
        /// Defines the AssessmentELDevelopmentalDomain.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentELDevelopmentalDomain.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
