//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentFormSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The AssessmentFormSection Model
     /// </summary>
    public partial class AssessmentFormSectionModel : AutobahnBase, Interfaces.IAssessmentFormSection
    {
        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.String AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.String AssessmentItemBankName { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public Guid? ChildOf_FormSectionId { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.String GUID { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public Guid? LearningResourceId { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public Guid? RefAssessmentFormSectionIdentificationSystemId { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.Boolean? SectionReentry { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.Boolean? SectionSealed { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.TimeSpan? SectionTimeLimit { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        public System.String Version { get; set; }

    }
}
