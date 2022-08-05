//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefTargetedSupportAndImprovementStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefTargetedSupportAndImprovementStatu Interface
     /// </summary>
    public partial interface IRefTargetedSupportAndImprovementStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTargetedSupportAndImprovementStatus"/> model
        /// </summary>
        Guid RefTargetedSupportAndImprovementStatusId { get; set; }

    }
}
