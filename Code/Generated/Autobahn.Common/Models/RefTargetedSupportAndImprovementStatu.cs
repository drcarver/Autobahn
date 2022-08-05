//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTargetedSupportAndImprovementStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefTargetedSupportAndImprovementStatu Model
     /// </summary>
    public partial class RefTargetedSupportAndImprovementStatu : ReferenceModelBase, IRefTargetedSupportAndImprovementStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTargetedSupportAndImprovementStatus"/> model
        /// </summary>
        public Guid RefTargetedSupportAndImprovementStatusId { get; set; }

    }
}
