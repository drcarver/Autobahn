//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAdditionalTargetedSupportAndImprovementStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefAdditionalTargetedSupportAndImprovementStatu Model
     /// </summary>
    public partial class RefAdditionalTargetedSupportAndImprovementStatu : ReferenceModelBase, IRefAdditionalTargetedSupportAndImprovementStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAdditionalTargetedSupportAndImprovementStatus"/> model
        /// </summary>
        public Guid RefAdditionalTargetedSupportAndImprovementStatusId { get; set; }

    }
}
