//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IRefIDEAIEPStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The RefIDEAIEPStatu Interface
     /// </summary>
    public partial interface IRefIDEAIEPStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefIDEAIEPStatus"/> model
        /// </summary>
        Guid RefIDEAIEPStatusId { get; set; }

    }
}
