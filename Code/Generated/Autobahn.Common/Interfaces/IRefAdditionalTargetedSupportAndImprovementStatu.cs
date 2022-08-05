//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefAdditionalTargetedSupportAndImprovementStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefAdditionalTargetedSupportAndImprovementStatu Interface
     /// </summary>
    public partial interface IRefAdditionalTargetedSupportAndImprovementStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAdditionalTargetedSupportAndImprovementStatus"/> model
        /// </summary>
        Guid RefAdditionalTargetedSupportAndImprovementStatusId { get; set; }

    }
}
