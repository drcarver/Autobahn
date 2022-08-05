//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefReconstitutedStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefReconstitutedStatu Interface
     /// </summary>
    public partial interface IRefReconstitutedStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefReconstitutedStatus"/> model
        /// </summary>
        Guid RefReconstitutedStatusId { get; set; }

    }
}
