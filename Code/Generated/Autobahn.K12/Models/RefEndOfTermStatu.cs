//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefEndOfTermStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefEndOfTermStatu Model
     /// </summary>
    public partial class RefEndOfTermStatu : ReferenceModelBase, IRefEndOfTermStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEndOfTermStatus"/> model
        /// </summary>
        public Guid RefEndOfTermStatusId { get; set; }

    }
}
