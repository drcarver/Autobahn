//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefVisionScreeningStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefVisionScreeningStatu Interface
     /// </summary>
    public partial interface IRefVisionScreeningStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefVisionScreeningStatus"/> model
        /// </summary>
        Guid RefVisionScreeningStatusId { get; set; }

    }
}
