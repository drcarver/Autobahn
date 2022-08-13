//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The Assessment Model
     /// </summary>
    public partial class AssessmentModel : AutobahnBase, Interfaces.IAssessment
    {
        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String AssessmentFamilyShortName { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String AssessmentFamilyTitle { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.DateTime? AssessmentRevisionDate { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String GUID { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.Int32? IdentificationSystem { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Objective { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Provider { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public Guid RefAcademicSubjectId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public Guid? RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public Guid? RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public Guid? RefAssessmentTypeId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String ShortName { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Title { get; set; }

    }
}
