//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtest.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The AssessmentSubtest
     /// </summary>
    public partial class AssessmentSubtest : AutobahnBase, Interfaces.IAssessmentSubtest
    {
        /// <summary>
        /// Defines the AssessmentSubtest.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSubtestentifierType"/> model
        /// </summary>
        public Guid? RefAssessmentSubtestIdentifierTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.Title non nullable property
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.Version non nullable property
        /// </summary>
        public System.String Version { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.PublishedDate nullable property
        /// </summary>
        public System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.Abbreviation non nullable property
        /// </summary>
        public System.String Abbreviation { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScoreMetricType"/> model
        /// </summary>
        public Guid? RefScoreMetricTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.MinimumValue non nullable property
        /// </summary>
        public System.String MinimumValue { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.MaximumValue non nullable property
        /// </summary>
        public System.String MaximumValue { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.OptimalValue non nullable property
        /// </summary>
        public System.String OptimalValue { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.Tier nullable property
        /// </summary>
        public System.Int32? Tier { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.ContainerOnly non nullable property
        /// </summary>
        public System.String ContainerOnly { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurpose"/> model
        /// </summary>
        public Guid? RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.Rules non nullable property
        /// </summary>
        public System.String Rules { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefContentStandardType"/> model
        /// </summary>
        public Guid? RefContentStandardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicSubject"/> model
        /// </summary>
        public Guid? RefAcademicSubjectId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ChildOf_AssessmentSubtest"/> model
        /// </summary>
        public Guid? ChildOf_AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentForm"/> model
        /// </summary>
        public Guid? AssessmentFormId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
