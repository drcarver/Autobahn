//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefAypStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefAypStatu Interface
     /// </summary>
    public partial interface IRefAypStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAypStatus"/> model
        /// </summary>
        Guid RefAypStatusId { get; set; }

    }
}
