//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentSubtestModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentSubtest Model
     /// </summary>
    public partial class AssessmentSubtestModel : AutobahnBase, Interfaces.IAssessmentSubtest
    {
        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Abbreviation { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public Guid? AssessmentFormId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public Guid? ChildOf_AssessmentSubtestId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String ContainerOnly { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String MaximumValue { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String MinimumValue { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String OptimalValue { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public Guid? RefAcademicSubjectId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public Guid? RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public Guid? RefAssessmentSubtestIdentifierTypeId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public Guid? RefContentStandardTypeId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public Guid? RefScoreMetricTypeId { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Rules { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.Int32? Tier { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// The description of the academic content or subject area (e.g., arts, mathematics, reading, or a foreign language) being evaluated.
        /// </summary>
        public System.String Version { get; set; }

    }
}
