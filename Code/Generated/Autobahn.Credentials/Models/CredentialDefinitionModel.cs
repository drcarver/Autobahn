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
        /// 
        /// </summary>
        public  AlternateName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CredentialDefDateEffective { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CredentialDefinitionTerminalDegreeIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CredentialNAICSIndustryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EmploymentNAICSCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  JurisdictionRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  JurisdictionRegionException { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Keywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCareerClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCredentialDefIntendedPurposeTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCredentialDefStatusTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCredentialDefVerificationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCtdlAudienceLevelTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefONETSOCOccupationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ValidationMethodDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Version { get; set; }

    }
}
