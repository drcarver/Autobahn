//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefOutOfFieldStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefOutOfFieldStatu Interface
     /// </summary>
    public partial interface IRefOutOfFieldStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefOutOfFieldStatus"/> model
        /// </summary>
        Guid RefOutOfFieldStatusId { get; set; }

    }
}
