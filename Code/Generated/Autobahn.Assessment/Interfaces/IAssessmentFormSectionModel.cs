//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentFormSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentFormSectionModel Interface
     /// </summary>
    public partial interface IAssessmentFormSectionModel : IAutobahnBase
    {
        /// <summary>
        /// Defines the AssessmentFormSection.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentFormSectionentificationSystem"/> model
        /// </summary>
        Guid? RefAssessmentFormSectionIdentificationSystemId { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.PublishedDate nullable property
        /// </summary>
        System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.Version non nullable property
        /// </summary>
        System.String Version { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.SectionTimeLimit nullable property
        /// </summary>
        System.TimeSpan? SectionTimeLimit { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.SectionSealed nullable property
        /// </summary>
        System.Boolean? SectionSealed { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.SectionReentry nullable property
        /// </summary>
        System.Boolean? SectionReentry { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.AssessmentItemBankIdentifier non nullable property
        /// </summary>
        System.String AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.AssessmentItemBankName non nullable property
        /// </summary>
        System.String AssessmentItemBankName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ChildOf_FormSection"/> model
        /// </summary>
        Guid? ChildOf_FormSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        Guid? LearningResourceId { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.GUID non nullable property
        /// </summary>
        System.String GUID { get; set; }

    }
}
