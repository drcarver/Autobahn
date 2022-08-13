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
        /// The credential related to early childhood education or development held by a person.
        /// </summary>
        Guid PersonCredentialId { get; set; }

        /// <summary>
        /// The credential related to early childhood education or development held by a person.
        /// </summary>
        Guid RefEarlyChildhoodCredentialId { get; set; }

    }
}
