//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IRefChildDevelopmentalScreeningStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The RefChildDevelopmentalScreeningStatu Interface
     /// </summary>
    public partial interface IRefChildDevelopmentalScreeningStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefChildDevelopmentalScreeningStatus"/> model
        /// </summary>
        Guid RefChildDevelopmentalScreeningStatusId { get; set; }

    }
}
