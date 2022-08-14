//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The AssessmentForm Model
     /// </summary>
    public partial class AssessmentFormModel : AutobahnBase, Interfaces.IAssessmentForm
    {
        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String AccommodationList { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.Boolean? AssessmentFormAdaptiveIndicator { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String AssessmentFormAlgorithmIdentifier { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String AssessmentFormAlgorithmVersion { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String AssessmentFormGUID { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public Guid AssessmentId { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String AssessmentItemBankName { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.Boolean? AssessmentSecureIndicator { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String FormNumber { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.DateTime? IntendedAdministrationEndDate { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.DateTime? IntendedAdministrationStartDate { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public Guid? LearningResourceId { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String PlatformsSupported { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public Guid? RefAssessmentLanguageId { get; set; }

        /// <summary>
        /// The name of a given assessment form.
        /// </summary>
        public System.String Version { get; set; }

    }
}
