//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefTeachingCredentialBasi.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefTeachingCredentialBasi Interface
     /// </summary>
    public partial interface IRefTeachingCredentialBasi : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        Guid RefTeachingCredentialBasisId { get; set; }

    }
}
