//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsSection.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsSection
     /// </summary>
    public partial interface IPsSection : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSection"/> model
        /// </summary>
        Guid CourseSectionId { get; set; }

        /// <summary>
        /// Defines the PsSection.GradeValueQualifier non nullable property
        /// </summary>
        System.String GradeValueQualifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseGPAApplicability"/> model
        /// </summary>
        Guid? RefCourseGPAApplicabilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseHonorsType"/> model
        /// </summary>
        Guid? RefCourseHonorsTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInstructionMethod"/> model
        /// </summary>
        Guid? RefCourseInstructionMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseLevelType"/> model
        /// </summary>
        Guid? RefCourseLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDevelopmentalEducationType"/> model
        /// </summary>
        Guid? RefDevelopmentalEducationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefWorkbasedLearningOpportunityType"/> model
        /// </summary>
        Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
