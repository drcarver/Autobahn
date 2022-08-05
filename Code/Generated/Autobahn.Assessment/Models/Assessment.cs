//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   Assessment.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The Assessment
     /// </summary>
    public partial class Assessment : AutobahnBase, Interfaces.IAssessment
    {
        /// <summary>
        /// Defines the Assessment.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Defines the Assessment.IdentificationSystem nullable property
        /// </summary>
        public System.Int32? IdentificationSystem { get; set; }

        /// <summary>
        /// Defines the Assessment.GUID non nullable property
        /// </summary>
        public System.String GUID { get; set; }

        /// <summary>
        /// Defines the Assessment.Title non nullable property
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Defines the Assessment.ShortName non nullable property
        /// </summary>
        public System.String ShortName { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAcademicSubject"/> model
        /// </summary>
        public Guid RefAcademicSubjectId { get; set; }

        /// <summary>
        /// Defines the Assessment.Objective non nullable property
        /// </summary>
        public System.String Objective { get; set; }

        /// <summary>
        /// Defines the Assessment.Provider non nullable property
        /// </summary>
        public System.String Provider { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentPurpose"/> model
        /// </summary>
        public Guid? RefAssessmentPurposeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentType"/> model
        /// </summary>
        public Guid? RefAssessmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentTypeChildrenWithDisabilities"/> model
        /// </summary>
        public Guid? RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

        /// <summary>
        /// Defines the Assessment.AssessmentRevisionDate nullable property
        /// </summary>
        public System.DateTime? AssessmentRevisionDate { get; set; }

        /// <summary>
        /// Defines the Assessment.AssessmentFamilyTitle non nullable property
        /// </summary>
        public System.String AssessmentFamilyTitle { get; set; }

        /// <summary>
        /// Defines the Assessment.AssessmentFamilyShortName non nullable property
        /// </summary>
        public System.String AssessmentFamilyShortName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
