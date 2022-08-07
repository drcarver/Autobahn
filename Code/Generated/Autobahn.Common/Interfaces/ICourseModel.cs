//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ICourseModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ICourseModel Interface
     /// </summary>
    public partial interface ICourseModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the Course.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the Course.SubjectAbbreviation non nullable property
        /// </summary>
        System.String SubjectAbbreviation { get; set; }

        /// <summary>
        /// Defines the Course.SCEDSequenceOfCourse non nullable property
        /// </summary>
        System.String SCEDSequenceOfCourse { get; set; }

        /// <summary>
        /// Defines the Course.InstructionalMinutes nullable property
        /// </summary>
        System.Int32? InstructionalMinutes { get; set; }

        /// <summary>
        /// Defines the Course.CreditValue nullable property
        /// </summary>
        System.Decimal? CreditValue { get; set; }

        /// <summary>
        /// Defines the Course.CertificationDescription non nullable property
        /// </summary>
        System.String CertificationDescription { get; set; }

        /// <summary>
        /// Defines the Course.RepeatabilityMaximumNumber nullable property
        /// </summary>
        System.Int32? RepeatabilityMaximumNumber { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseLevelCharacteristics"/> model
        /// </summary>
        Guid? RefCourseLevelCharacteristicsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnit"/> model
        /// </summary>
        Guid? RefCourseCreditUnitId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLanguage"/> model
        /// </summary>
        Guid? RefInstructionLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseApplicableEducationLevel"/> model
        /// </summary>
        Guid? RefCourseApplicableEducationLevelId { get; set; }

    }
}
