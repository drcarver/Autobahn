//**********************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefCategoryModel.cs
//***************************************************************************

using Autobahn.Interfaces.Credentials;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The CredentialDefCategory Model
     /// </summary>
    public partial class CredentialDefCategoryModel : AutobahnBase, ICredentialDefCategory
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
        /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
        /// </summary>
        public Guid CredentialDefinitionId { get; set; }

    }
}
