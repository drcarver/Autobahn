//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefAlternateFundUsModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefAlternateFundUs Model
     /// </summary>
    public partial class RefAlternateFundUsModel : ReferenceModelBase, IRefAlternateFundUsModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAlternateFundUses"/> model
        /// </summary>
        public Guid RefAlternateFundUsesId { get; set; }

    }
}
