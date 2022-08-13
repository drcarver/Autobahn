//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodCredentialModel.cs
//**********************************************************

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
        /// The credential related to early childhood education or development held by a person.
        /// </summary>
        public Guid PersonCredentialId { get; set; }

        /// <summary>
        /// The credential related to early childhood education or development held by a person.
        /// </summary>
        public Guid RefEarlyChildhoodCredentialId { get; set; }

    }
}
