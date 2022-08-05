//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefDataCollectionStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefDataCollectionStatu Model
     /// </summary>
    public partial class RefDataCollectionStatu : ReferenceModelBase, IRefDataCollectionStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefDataCollectionStatus"/> model
        /// </summary>
        public Guid RefDataCollectionStatusId { get; set; }

    }
}
