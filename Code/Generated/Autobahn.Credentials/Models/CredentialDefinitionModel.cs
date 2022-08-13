//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefinitionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefinition Model
     /// </summary>
    public partial class CredentialDefinitionModel : AutobahnBase, Interfaces.ICredentialDefinition
    {
        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.String AlternateName { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.DateTime? CredentialDefDateEffective { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.Boolean? CredentialDefinitionTerminalDegreeIndicator { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.String CredentialNAICSIndustryType { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.String EmploymentNAICSCode { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.String ImageUrl { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.String JurisdictionRegion { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.String JurisdictionRegionException { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.String Keywords { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public Guid? RefCredentialDefIntendedPurposeTypeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public Guid? RefCredentialDefStatusTypeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public Guid? RefCredentialDefVerificationTypeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public Guid? RefCTDLAudienceLevelTypeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public Guid? RefONETSOCOccupationTypeId { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.String ValidationMethodDescription { get; set; }

        /// <summary>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </summary>
        public System.Decimal? Version { get; set; }

    }
}
