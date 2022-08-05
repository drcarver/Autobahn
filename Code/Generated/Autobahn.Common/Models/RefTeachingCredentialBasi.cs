//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTeachingCredentialBasi.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefTeachingCredentialBasi Model
     /// </summary>
    public partial class RefTeachingCredentialBasi : ReferenceModelBase, IRefTeachingCredentialBasi
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        public Guid RefTeachingCredentialBasisId { get; set; }

    }
}
