//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefinitionModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Credentials;

namespace Autobahn.Education.Credentials.Models
{
     /// <summary>
     /// The CredentialDefinition Model
     /// </summary>
    public partial class CredentialDefinitionModel : ICredentialDefinition
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region ICredentialDefinition
        /// <summary>
        /// Credential Definition Alternate Name
        /// <para>
        /// An alias for the credential, which may include acronyms, alpha-numeric notations, and other forms of name abbreviations in common use such as PhD, MA, and BA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20717">Credential Definition Alternate Name</a>
        /// </para>
        /// </summary>
        public System.String AlternateName { get; set; }

        /// <summary>
        /// Credential Definition Date Effective
        /// <para>
        /// Effective date of the content of a credential definition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20891">Credential Definition Date Effective</a>
        /// </para>
        /// </summary>
        public DateTime? CredentialDefDateEffective { get; set; }

        /// <summary>
        /// Credential Definition Terminal Degree Indicator
        /// <para>
        /// This degree is the highest degree that can be awarded in this classification of instructional programs field or program area.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20919">Credential Definition Terminal Degree Indicator</a>
        /// </para>
        /// </summary>
        public Boolean? CredentialDefinitionTerminalDegreeIndicator { get; set; }

        public System.String CredentialNaicsindustryType { get; set; }

        public System.String EmploymentNaicscode { get; set; }

        /// <summary>
        /// Credential Image URL
        /// <para>
        /// The Uniform Resource Locator (URL) for the unique address of an image representing an award or badge associated with the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19894">Credential Image URL</a>
        /// </para>
        /// </summary>
        public System.String ImageUrl { get; set; }

        /// <summary>
        /// Credential Definition Jurisdiction Region
        /// <para>
        /// The geo-political region in which the credential is applicable.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20724">Credential Definition Jurisdiction Region</a>
        /// </para>
        /// </summary>
        public System.String JurisdictionRegion { get; set; }

        /// <summary>
        /// Credential Definition Jurisdiction Region Exception
        /// <para>
        /// A geo-political region in which the credential does not apply.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20725">Credential Definition Jurisdiction Region Exception</a>
        /// </para>
        /// </summary>
        public System.String JurisdictionRegionException { get; set; }

        /// <summary>
        /// Credential Definition Keywords
        /// <para>
        /// Keywords or key phrases describing aspects of a credential considered useful for its discovery.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20726">Credential Definition Keywords</a>
        /// </para>
        /// </summary>
        public System.String Keywords { get; set; }

        /// <summary>
        /// Career Cluster
        /// <para>
        /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
        /// </para>
        /// </summary>
        public Guid? RefCareerClusterId { get; set; }

        /// <summary>
        /// Classification of Instructional Program Code
        /// <para>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
        /// </para>
        /// </summary>
        public Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Credential Definition Intended Purpose Type
        /// <para>
        /// The intended type of application of the credential by the holder.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20730">Credential Definition Intended Purpose Type</a>
        /// </para>
        /// </summary>
        public Guid? RefCredentialDefIntendedPurposeTypeId { get; set; }

        /// <summary>
        /// Credential Definition Status Type
        /// <para>
        /// The status of the credential offered by a credentialing organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20721">Credential Definition Status Type</a>
        /// </para>
        /// </summary>
        public Guid? RefCredentialDefStatusTypeId { get; set; }

        /// <summary>
        /// Credential Definition Verification Type
        /// <para>
        /// A resource describing the means by which someone can verify whether a credential has been attained by a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20734">Credential Definition Verification Type</a>
        /// </para>
        /// </summary>
        public Guid? RefCredentialDefVerificationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCtdlaudienceLevelType"/> model
        /// </summary>
        public Guid? RefCtdlaudienceLevelTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOnetsococcupationType"/> model
        /// </summary>
        public Guid? RefOnetsococcupationTypeId { get; set; }

        /// <summary>
        /// Credential Definition Title
        /// <para>
        /// The title assigned to a qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19893">Credential Definition Title</a>
        /// </para>
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Credential Definition Validation Method Description
        /// <para>
        /// Description of the methods used to evaluate the validity and reliability of a credential earned by a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20733">Credential Definition Validation Method Description</a>
        /// </para>
        /// </summary>
        public System.String ValidationMethodDescription { get; set; }

        /// <summary>
        /// Credential Definition Version
        /// <para>
        /// An alphanumeric identifier of a version of the credential being described that is unique within the organizational context.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20735">Credential Definition Version</a>
        /// </para>
        /// </summary>
        public Decimal? Version { get; set; }

        #endregion
    }
}