//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefNSLPStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefNSLPStatu Interface
     /// </summary>
    public partial interface IRefNSLPStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefNSLPStatus"/> model
        /// </summary>
        Guid RefNSLPStatusId { get; set; }

    }
}
