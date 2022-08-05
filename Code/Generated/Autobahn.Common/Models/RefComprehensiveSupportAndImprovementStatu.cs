//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefComprehensiveSupportAndImprovementStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefComprehensiveSupportAndImprovementStatu Model
     /// </summary>
    public partial class RefComprehensiveSupportAndImprovementStatu : ReferenceModelBase, IRefComprehensiveSupportAndImprovementStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefComprehensiveSupportAndImprovementStatus"/> model
        /// </summary>
        public Guid RefComprehensiveSupportAndImprovementStatusId { get; set; }

    }
}
