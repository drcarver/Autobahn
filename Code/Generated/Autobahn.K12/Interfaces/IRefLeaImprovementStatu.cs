//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefLeaImprovementStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefLeaImprovementStatu Interface
     /// </summary>
    public partial interface IRefLeaImprovementStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefLeaImprovementStatus"/> model
        /// </summary>
        Guid RefLeaImprovementStatusId { get; set; }

    }
}
