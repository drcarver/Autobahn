//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessment Interface
     /// </summary>
    public partial interface IAssessment : IAutobahnBase
    {
        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        System.String AssessmentFamilyShortName { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        System.String AssessmentFamilyTitle { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        System.DateTime? AssessmentRevisionDate { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        System.String GUID { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        System.Int32? IdentificationSystem { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        System.String Objective { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        System.String Provider { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        Guid RefAcademicSubjectId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        Guid? RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        Guid? RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        Guid? RefAssessmentTypeId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        System.String ShortName { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        System.String Title { get; set; }

    }
}
