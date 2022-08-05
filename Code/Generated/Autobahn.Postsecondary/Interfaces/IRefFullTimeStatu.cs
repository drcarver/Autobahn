//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefFullTimeStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The RefFullTimeStatu Interface
     /// </summary>
    public partial interface IRefFullTimeStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefFullTimeStatus"/> model
        /// </summary>
        Guid RefFullTimeStatusId { get; set; }

    }
}
