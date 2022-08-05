//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefHearingScreeningStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefHearingScreeningStatu Interface
     /// </summary>
    public partial interface IRefHearingScreeningStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefHearingScreeningStatus"/> model
        /// </summary>
        Guid RefHearingScreeningStatusId { get; set; }

    }
}
