//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefDataCollectionStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefDataCollectionStatu Interface
     /// </summary>
    public partial interface IRefDataCollectionStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefDataCollectionStatus"/> model
        /// </summary>
        Guid RefDataCollectionStatusId { get; set; }

    }
}
