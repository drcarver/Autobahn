//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefEmergencyOrProvisionalCredentialStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefEmergencyOrProvisionalCredentialStatu Interface
     /// </summary>
    public partial interface IRefEmergencyOrProvisionalCredentialStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEmergencyOrProvisionalCredentialStatus"/> model
        /// </summary>
        Guid RefEmergencyOrProvisionalCredentialStatusId { get; set; }

    }
}
