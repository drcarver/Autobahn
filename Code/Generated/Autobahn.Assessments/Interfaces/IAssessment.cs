//**********************************************************
//* DomainName: Autobahn.Assessments
//* FileName:   IAssessment.cs
//**********************************************************

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IAssessment
     /// </summary>
    public partial interface IAssessment
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Assessment"/> model
        /// </summary>
        Guid AssessmentId { get; set; }

        /// <summary>
        /// Defines the Assessment.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Defines the Assessment.IdentificationSystem nullable property
        /// </summary>
        System.Int32? IdentificationSystem { get; set; }

        /// <summary>
        /// Defines the Assessment.GUID non nullable property
        /// </summary>
        System.String GUID { get; set; }

        /// <summary>
        /// Defines the Assessment.Title non nullable property
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// Defines the Assessment.ShortName non nullable property
        /// </summary>
        System.String ShortName { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAcademicSubject"/> model
        /// </summary>
        Guid RefAcademicSubjectId { get; set; }

        /// <summary>
        /// Defines the Assessment.Objective non nullable property
        /// </summary>
        System.String Objective { get; set; }

        /// <summary>
        /// Defines the Assessment.Provider non nullable property
        /// </summary>
        System.String Provider { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurpose"/> model
        /// </summary>
        Guid? RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentType"/> model
        /// </summary>
        Guid? RefAssessmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentTypeChildrenWithDisabilities"/> model
        /// </summary>
        Guid? RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

        /// <summary>
        /// The month, day, and year that the conceptual design for the assessment was most recently revised substantially.
        /// </summary>
    System.DateTime? AssessmentRevisionDate { get; set; }

        /// <summary>
        /// The full title of the Assessment Family. An Assessment Family is a set of assessments with a common name, jurisdiction, or focus, such as Graduate Record Exam or National Assessment of Educational Progress.
        /// </summary>
    System.String AssessmentFamilyTitle { get; set; }

        /// <summary>
        /// The abbreviated title of the Assessment Family. An Assessment Family is a set of assessments with a common name, jurisdiction, or focus.
        /// </summary>
    System.String AssessmentFamilyShortName { get; set; }

        /// <summary>
        /// Defines the Assessment.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the Assessment.RecordEndDateTime nullable property
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
