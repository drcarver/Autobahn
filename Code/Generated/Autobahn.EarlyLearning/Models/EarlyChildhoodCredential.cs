//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   EarlyChildhoodCredential.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The EarlyChildhoodCredential
     /// </summary>
    public partial class EarlyChildhoodCredential : AutobahnBase, Interfaces.IEarlyChildhoodCredential
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonCredential"/> model
        /// </summary>
        public Guid PersonCredentialId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefEarlyChildhoodCredential"/> model
        /// </summary>
        public Guid RefEarlyChildhoodCredentialId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
