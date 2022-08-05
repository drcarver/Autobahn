//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefReapAlternativeFundingStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefReapAlternativeFundingStatu Model
     /// </summary>
    public partial class RefReapAlternativeFundingStatu : ReferenceModelBase, IRefReapAlternativeFundingStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefReapAlternativeFundingStatus"/> model
        /// </summary>
        public Guid RefReapAlternativeFundingStatusId { get; set; }

    }
}
