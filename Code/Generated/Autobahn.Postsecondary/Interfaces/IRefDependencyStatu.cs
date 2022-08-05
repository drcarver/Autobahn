//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefDependencyStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The RefDependencyStatu Interface
     /// </summary>
    public partial interface IRefDependencyStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefDependencyStatus"/> model
        /// </summary>
        Guid RefDependencyStatusId { get; set; }

    }
}
