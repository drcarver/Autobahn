//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefEmploymentStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefEmploymentStatu Interface
     /// </summary>
    public partial interface IRefEmploymentStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEmploymentStatus"/> model
        /// </summary>
        Guid RefEmploymentStatusId { get; set; }

    }
}
