//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAssessmentFormSection.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAssessmentFormSection Interface
     /// </summary>
    public partial interface IAssessmentFormSection : IAutobahnBase
    {
        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        System.String AssessmentItemBankIdentifier { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        System.String AssessmentItemBankName { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        Guid? ChildOf_FormSectionId { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        System.String GUID { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        Guid? LearningResourceId { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        Guid? RefAssessmentFormSectionIdentificationSystemId { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        System.Boolean? SectionReentry { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        System.Boolean? SectionSealed { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        System.TimeSpan? SectionTimeLimit { get; set; }

        /// <summary>
        /// The globally unique identifier of an Assessment Form Section using a RFC 4122 compliant hexadecimal string.
        /// </summary>
        System.String Version { get; set; }

    }
}
