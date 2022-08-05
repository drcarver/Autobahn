//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IRefProfitStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The RefProfitStatu Interface
     /// </summary>
    public partial interface IRefProfitStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefProfitStatus"/> model
        /// </summary>
        Guid RefProfitStatusId { get; set; }

    }
}
