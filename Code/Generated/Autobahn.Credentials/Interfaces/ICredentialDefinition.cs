//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefinition.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefinition Interface
     /// </summary>
    public partial interface ICredentialDefinition : IAutobahnBase
    {
        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.String AlternateName { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.DateTime? CredentialDefDateEffective { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.Boolean? CredentialDefinitionTerminalDegreeIndicator { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.String CredentialNAICSIndustryType { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.String EmploymentNAICSCode { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.String ImageUrl { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.String JurisdictionRegion { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.String JurisdictionRegionException { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.String Keywords { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        Guid? RefCredentialDefIntendedPurposeTypeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        Guid? RefCredentialDefStatusTypeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        Guid? RefCredentialDefVerificationTypeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        Guid? RefCTDLAudienceLevelTypeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        Guid? RefONETSOCOccupationTypeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.String ValidationMethodDescription { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        System.Decimal? Version { get; set; }

    }
}
