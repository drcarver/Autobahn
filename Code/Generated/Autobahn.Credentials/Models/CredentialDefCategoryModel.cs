//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCategoryModel.cs
//* Name:       Credential Definition Category Type
//* Definition: A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// A category for defining the qualification, achievement, personal or organizational quality, or aspect of an identity.
     /// </summary>
    public partial class CredentialDefCategoryModel : AutobahnBase, Interfaces.ICredentialDefCategory
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
        public System.String Category { get; set; }

        /// <summary>
        /// Credential Definition Category System
        /// <para>
        /// The system that defines the categories of the qualification, achievement, personal or organizational quality, or aspect of an identity used in Credential Category Type.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20211">Credential Definition Category System</a>
        /// </para>
        /// </summary>
        public System.String CategorySystem { get; set; }

        /// <summary>
        /// Credential Definition Alternate Name
        /// <para>
        /// An alias for the credential, which may include acronyms, alpha-numeric notations, and other forms of name abbreviations in common use such as PhD, MA, and BA.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20717">Credential Definition Alternate Name</a>
        /// </para>
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

    }
}
