//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefCategory.cs
//* Name:       Credential Definition Category Type
//* Definition: Credential Category Type
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// Credential Category Type
     /// </summary>
    public partial interface ICredentialDefCategory : IAutobahnBase
    {
        /// <summary>
        /// Credential Definition Category Type
        /// <para>
        /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19892">Credential Definition Category Type</a>
        /// </para>
        /// </summary>
        System.String Category { get; set; }

        /// <summary>
        /// Credential Definition Category System
        /// <para>
        /// The system that defines the categories of the qualification, achievement, personal or organizational quality, or aspect of an identity used in Credential Category Type.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20211">Credential Definition Category System</a>
        /// </para>
        /// </summary>
        System.String CategorySystem { get; set; }

        /// <summary>
        /// Credential Definition Alternate Name
        /// <para>
        /// An alias for the credential, which may include acronyms, alpha-numeric notations, and other forms of name abbreviations in common use such as PhD, MA, and BA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20717">Credential Definition Alternate Name</a>
        /// </para>
        /// </summary>
        Guid CredentialDefinitionId { get; set; }

    }
}
