//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ICourseSectionModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ICourseSectionModel Interface
     /// </summary>
    public partial interface ICourseSectionModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Course"/> model
        /// </summary>
        Guid CourseId { get; set; }

        /// <summary>
        /// Defines the CourseSection.AvailableCarnegieUnitCredit nullable property
        /// </summary>
        System.Decimal? AvailableCarnegieUnitCredit { get; set; }

        /// <summary>
        /// Defines the CourseSection.TimeRequiredForCompletion nullable property
        /// </summary>
        System.Decimal? TimeRequiredForCompletion { get; set; }

        /// <summary>
        /// Defines the CourseSection.VirtualIndicator nullable property
        /// </summary>
        System.Boolean? VirtualIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        Guid? OrganizationCalendarSessionId { get; set; }

        /// <summary>
        /// Defines the CourseSection.MaximumCapacity nullable property
        /// </summary>
        System.Int32? MaximumCapacity { get; set; }

        /// <summary>
        /// Defines the CourseSection.RelatedCompetencyDefinitions non nullable property
        /// </summary>
        System.String RelatedCompetencyDefinitions { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseSectionDeliveryMode"/> model
        /// </summary>
        Guid? RefCourseSectionDeliveryModeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSingleSexClassStatus"/> model
        /// </summary>
        Guid? RefSingleSexClassStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdditionalCreditType"/> model
        /// </summary>
        Guid? RefAdditionalCreditTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLanguage"/> model
        /// </summary>
        Guid? RefInstructionLanguageId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCreditTypeEarned"/> model
        /// </summary>
        Guid? RefCreditTypeEarnedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdvancedPlacementCourseCode"/> model
        /// </summary>
        Guid? RefAdvancedPlacementCourseCodeId { get; set; }

    }
}
