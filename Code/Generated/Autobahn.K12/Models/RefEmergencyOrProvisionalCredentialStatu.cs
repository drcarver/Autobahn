//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefEmergencyOrProvisionalCredentialStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefEmergencyOrProvisionalCredentialStatu Model
     /// </summary>
    public partial class RefEmergencyOrProvisionalCredentialStatu : ReferenceModelBase, IRefEmergencyOrProvisionalCredentialStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEmergencyOrProvisionalCredentialStatus"/> model
        /// </summary>
        public Guid RefEmergencyOrProvisionalCredentialStatusId { get; set; }

    }
}
