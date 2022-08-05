//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefComprehensiveSupportAndImprovementStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefComprehensiveSupportAndImprovementStatu Interface
     /// </summary>
    public partial interface IRefComprehensiveSupportAndImprovementStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefComprehensiveSupportAndImprovementStatus"/> model
        /// </summary>
        Guid RefComprehensiveSupportAndImprovementStatusId { get; set; }

    }
}
