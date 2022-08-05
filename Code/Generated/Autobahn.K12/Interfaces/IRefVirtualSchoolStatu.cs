//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefVirtualSchoolStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefVirtualSchoolStatu Interface
     /// </summary>
    public partial interface IRefVirtualSchoolStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefVirtualSchoolStatus"/> model
        /// </summary>
        Guid RefVirtualSchoolStatusId { get; set; }

    }
}
