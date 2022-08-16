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
        /// 
        /// </summary>
         AlternateName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CredentialDefDateEffective { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CredentialDefinitionTerminalDegreeIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CredentialNAICSIndustryType { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EmploymentNAICSCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
         JurisdictionRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
         JurisdictionRegionException { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Keywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCareerClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCredentialDefIntendedPurposeTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCredentialDefStatusTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCredentialDefVerificationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefCtdlAudienceLevelTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefONETSOCOccupationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ValidationMethodDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Version { get; set; }

    }
}
