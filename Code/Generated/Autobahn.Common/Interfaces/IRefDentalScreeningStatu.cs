//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefDentalScreeningStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefDentalScreeningStatu Interface
     /// </summary>
    public partial interface IRefDentalScreeningStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefDentalScreeningStatus"/> model
        /// </summary>
        Guid RefDentalScreeningStatusId { get; set; }

    }
}
