//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefPDSessionStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefPDSessionStatu Interface
     /// </summary>
    public partial interface IRefPDSessionStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefPDSessionStatus"/> model
        /// </summary>
        Guid RefPDSessionStatusId { get; set; }

    }
}
