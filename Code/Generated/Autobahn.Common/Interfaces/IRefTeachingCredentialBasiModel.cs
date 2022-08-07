//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefTeachingCredentialBasiModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefTeachingCredentialBasi Interface Model
     /// </summary>
    public partial interface IRefTeachingCredentialBasiModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        Guid RefTeachingCredentialBasisId { get; set; }

    }
}
