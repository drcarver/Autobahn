//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefAmaoAttainmentStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefAmaoAttainmentStatu Interface
     /// </summary>
    public partial interface IRefAmaoAttainmentStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAmaoAttainmentStatus"/> model
        /// </summary>
        Guid RefAmaoAttainmentStatusId { get; set; }

    }
}
