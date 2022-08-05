//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefTelephoneNumberListedStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefTelephoneNumberListedStatu Interface
     /// </summary>
    public partial interface IRefTelephoneNumberListedStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTelephoneNumberListedStatus"/> model
        /// </summary>
        Guid RefTelephoneNumberListedStatusId { get; set; }

    }
}
