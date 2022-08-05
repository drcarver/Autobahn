//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessmentSubtest.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessmentSubtest
     /// </summary>
    public partial interface IAssessmentSubtest : IAutobahnBase
    {
        /// <summary>
        /// Defines the AssessmentSubtest.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentSubtestentifierType"/> model
        /// </summary>
        Guid? RefAssessmentSubtestIdentifierTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.Title non nullable property
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.Version non nullable property
        /// </summary>
        System.String Version { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.PublishedDate nullable property
        /// </summary>
        System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.Abbreviation non nullable property
        /// </summary>
        System.String Abbreviation { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefScoreMetricType"/> model
        /// </summary>
        Guid? RefScoreMetricTypeId { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.MinimumValue non nullable property
        /// </summary>
        System.String MinimumValue { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.MaximumValue non nullable property
        /// </summary>
        System.String MaximumValue { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.OptimalValue non nullable property
        /// </summary>
        System.String OptimalValue { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.Tier nullable property
        /// </summary>
        System.Int32? Tier { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.ContainerOnly non nullable property
        /// </summary>
        System.String ContainerOnly { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurpose"/> model
        /// </summary>
        Guid? RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the AssessmentSubtest.Rules non nullable property
        /// </summary>
        System.String Rules { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefContentStandardType"/> model
        /// </summary>
        Guid? RefContentStandardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicSubject"/> model
        /// </summary>
        Guid? RefAcademicSubjectId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ChildOf_AssessmentSubtest"/> model
        /// </summary>
        Guid? ChildOf_AssessmentSubtestId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentForm"/> model
        /// </summary>
        Guid? AssessmentFormId { get; set; }

    }
}
