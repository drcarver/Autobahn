//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefLeaImprovementStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefLeaImprovementStatu Model
     /// </summary>
    public partial class RefLeaImprovementStatu : ReferenceModelBase, IRefLeaImprovementStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefLeaImprovementStatus"/> model
        /// </summary>
        public Guid RefLeaImprovementStatusId { get; set; }

    }
}
