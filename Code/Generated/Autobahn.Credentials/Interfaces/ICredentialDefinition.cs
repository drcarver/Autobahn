//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefinition.cs
//* Name:       Credential Definition Alternate Name
//* Definition: Credential Alternate Name
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// Credential Alternate Name
     /// </summary>
    public partial interface ICredentialDefinition : IAutobahnBase
    {
        /// <summary>
        /// Credential Definition Alternate Name
        /// <para>
        /// An alias for the credential, which may include acronyms, alpha-numeric notations, and other forms of name abbreviations in common use such as PhD, MA, and BA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20717">Credential Definition Alternate Name</a>
        /// </para>
        /// </summary>
        System.String AlternateName { get; set; }

        /// <summary>
        /// Credential Definition Date Effective
        /// <para>
        /// Effective date of the content of a credential definition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20891">Credential Definition Date Effective</a>
        /// </para>
        /// </summary>
        System.DateTime? CredentialDefDateEffective { get; set; }

        /// <summary>
        /// Credential Definition Terminal Degree Indicator
        /// <para>
        /// This degree is the highest degree that can be awarded in this classification of instructional programs field or program area.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20919">Credential Definition Terminal Degree Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? CredentialDefinitionTerminalDegreeIndicator { get; set; }

        /// <summary>
        /// Credential Definition NAICS Industry Type
        /// <para>
        /// The North American Industry Classification System (NAICS) class identifier for an industry associated with the credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20723">Credential Definition NAICS Industry Type</a>
        /// </para>
        /// </summary>
        System.String CredentialNAICSIndustryType { get; set; }

        /// <summary>
        /// Employment NAICS Code
        /// <para>
        /// The North American Industry Classification System (NAICS) code associated with an individual's employment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20070">Employment NAICS Code</a>
        /// </para>
        /// </summary>
        System.String EmploymentNAICSCode { get; set; }

        /// <summary>
        /// Credential Image URL
        /// <para>
        /// The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19894">Credential Image URL</a>
        /// </para>
        /// </summary>
        System.String ImageUrl { get; set; }

        /// <summary>
        /// Credential Definition Jurisdiction Region
        /// <para>
        /// The geo-political region in which the credential is applicable.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20724">Credential Definition Jurisdiction Region</a>
        /// </para>
        /// </summary>
        System.String JurisdictionRegion { get; set; }

        /// <summary>
        /// Credential Definition Jurisdiction Region Exception
        /// <para>
        /// A geo-political region in which the credential does not apply.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20725">Credential Definition Jurisdiction Region Exception</a>
        /// </para>
        /// </summary>
        System.String JurisdictionRegionException { get; set; }

        /// <summary>
        /// Credential Definition Keywords
        /// <para>
        /// Keywords or key phrases describing aspects of a credential considered useful for its discovery.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20726">Credential Definition Keywords</a>
        /// </para>
        /// </summary>
        System.String Keywords { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCareerCluster"/> model
        /// </summary>
        Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCipCode"/> model
        /// </summary>
        Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCredentialDefIntendedPurposeType"/> model
        /// </summary>
        Guid? RefCredentialDefIntendedPurposeTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCredentialDefStatusType"/> model
        /// </summary>
        Guid? RefCredentialDefStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCredentialDefVerificationType"/> model
        /// </summary>
        Guid? RefCredentialDefVerificationTypeId { get; set; }

        /// <summary>
        /// CTDL Audience Level Type
        /// <para>
        /// Type of level indicating a point in a progression through an educational or training context, for which the credential is intended; select from an existing enumeration of such types.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20894">CTDL Audience Level Type</a>
        /// </para>
        /// </summary>
         RefCtdlAudienceLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCTDLAudienceLevelType"/> model
        /// </summary>
        Guid? RefCTDLAudienceLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefONETSOCOccupationType"/> model
        /// </summary>
        Guid? RefONETSOCOccupationTypeId { get; set; }

        /// <summary>
        /// Credential Definition Title
        /// <para>
        /// The title assigned to a qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19893">Credential Definition Title</a>
        /// </para>
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// Credential Definition Validation Method Description
        /// <para>
        /// Description of the methods used to evaluate the validity and reliability of a credential earned by a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20733">Credential Definition Validation Method Description</a>
        /// </para>
        /// </summary>
        System.String ValidationMethodDescription { get; set; }

        /// <summary>
        /// Credential Definition Version
        /// <para>
        /// An alphanumeric identifier of a version of the credential being described that is unique within the organizational context.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20735">Credential Definition Version</a>
        /// </para>
        /// </summary>
        System.Decimal? Version { get; set; }

    }
}
