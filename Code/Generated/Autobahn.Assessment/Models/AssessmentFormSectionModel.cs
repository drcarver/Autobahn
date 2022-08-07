//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentFormSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentFormSection Model
     /// </summary>
    public partial class AssessmentFormSectionModel : AutobahnBase, Interfaces.IAssessmentFormSectionModel
    {
        /// <summary>
        /// Defines the AssessmentFormSection.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentFormSectionentificationSystem"/> model
        /// </summary>
        public Guid? RefAssessmentFormSectionIdentificationSystemId { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.PublishedDate nullable property
        /// </summary>
        public System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.Version non nullable property
        /// </summary>
        public System.String Version { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.SectionTimeLimit nullable property
        /// </summary>
        public System.TimeSpan? SectionTimeLimit { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.SectionSealed nullable property
        /// </summary>
        public System.Boolean? SectionSealed { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.SectionReentry nullable property
        /// </summary>
        public System.Boolean? SectionReentry { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.AssessmentItemBankIdentifier non nullable property
        /// </summary>
        public System.String AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.AssessmentItemBankName non nullable property
        /// </summary>
        public System.String AssessmentItemBankName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ChildOf_FormSection"/> model
        /// </summary>
        public Guid? ChildOf_FormSectionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid? LearningResourceId { get; set; }

        /// <summary>
        /// Defines the AssessmentFormSection.GUID non nullable property
        /// </summary>
        public System.String GUID { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
