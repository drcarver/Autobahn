//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTeachingCredentialBasiModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefTeachingCredentialBasi Model
     /// </summary>
    public partial class RefTeachingCredentialBasiModel : ReferenceModelBase, IRefTeachingCredentialBasiModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        public Guid RefTeachingCredentialBasisId { get; set; }

    }
}
