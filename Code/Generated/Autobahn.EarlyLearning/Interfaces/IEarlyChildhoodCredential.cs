//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IEarlyChildhoodCredential.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IEarlyChildhoodCredential Interface
     /// </summary>
    public partial interface IEarlyChildhoodCredential : IAutobahnBase
    {
        /// <summary>
        /// Name of Professional Credential or License
        /// <para>
        /// The name of the license/credential awarded by a given profession.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20064">Name of Professional Credential or License</a>
        /// </para>
        /// </summary>
        Guid PersonCredentialId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefEarlyChildhoodCredential"/> model
        /// </summary>
        Guid RefEarlyChildhoodCredentialId { get; set; }

    }
}
