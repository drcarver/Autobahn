//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefUSCitizenshipStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefUSCitizenshipStatu Interface
     /// </summary>
    public partial interface IRefUSCitizenshipStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefUSCitizenshipStatus"/> model
        /// </summary>
        Guid RefUSCitizenshipStatusId { get; set; }

    }
}
