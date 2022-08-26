//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IEarlyChildhoodCredential.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.EarlyLearning
{
     /// <summary>
     /// The IEarlyChildhoodCredential Interface
     /// </summary>
    public partial interface IEarlyChildhoodCredential : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonCredential"/> model
        /// </summary>
        Guid PersonCredentialId { get; set; }

        /// <summary>
        /// Early Childhood Credential
        /// <para>
        /// The credential related to early childhood education or development held by a person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19344">Early Childhood Credential</a>
        /// </para>
        /// </summary>
        Guid RefEarlyChildhoodCredentialId { get; set; }

    }
}
