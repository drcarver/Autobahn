//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IEarlyChildhoodCredential.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IEarlyChildhoodCredential
     /// </summary>
    public partial interface IEarlyChildhoodCredential : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonCredential"/> model
        /// </summary>
        Guid PersonCredentialId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefEarlyChildhoodCredential"/> model
        /// </summary>
        Guid RefEarlyChildhoodCredentialId { get; set; }

    }
}
