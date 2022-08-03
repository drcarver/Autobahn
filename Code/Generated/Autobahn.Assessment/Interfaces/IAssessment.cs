//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IAssessment.cs
//**********************************************************

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IAssessment
     /// </summary>
    public partial interface IAssessment
    {
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
        /// Defines the Assessment.AssessmentRevisionDate nullable property
        /// </summary>
        System.DateTime? AssessmentRevisionDate { get; set; }

        /// <summary>
        /// Defines the Assessment.AssessmentFamilyTitle non nullable property
        /// </summary>
        System.String AssessmentFamilyTitle { get; set; }

        /// <summary>
        /// Defines the Assessment.AssessmentFamilyShortName non nullable property
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
