//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefDirectoryInformationBlockStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefDirectoryInformationBlockStatu Interface
     /// </summary>
    public partial interface IRefDirectoryInformationBlockStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefDirectoryInformationBlockStatus"/> model
        /// </summary>
        Guid RefDirectoryInformationBlockStatusId { get; set; }

    }
}
