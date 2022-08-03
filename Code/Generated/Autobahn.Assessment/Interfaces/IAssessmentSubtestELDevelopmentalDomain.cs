//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentSubtestELDevelopmentalDomain.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentSubtestELDevelopmentalDomain
     /// </summary>
    public partial interface IAssessmentSubtestELDevelopmentalDomain
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        Guid AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentELDevelopmentalDomain"/> model
        /// </summary>
        Guid RefAssessmentELDevelopmentalDomainId { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtestELDevelopmentalDomain.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtestELDevelopmentalDomain.RecordEndDateTime nullable property
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
