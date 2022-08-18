//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodCredentialModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The EarlyChildhoodCredential Model
     /// </summary>
    public partial class EarlyChildhoodCredentialModel : AutobahnBase, Interfaces.IEarlyChildhoodCredential
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
        public Guid PersonCredentialId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodCredential"/> model
        /// </summary>
        public Guid RefEarlyChildhoodCredentialId { get; set; }

    }
}
