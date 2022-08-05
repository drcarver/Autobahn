//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefCharterLeaStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefCharterLeaStatu Interface
     /// </summary>
    public partial interface IRefCharterLeaStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCharterLeaStatus"/> model
        /// </summary>
        Guid RefCharterLeaStatusId { get; set; }

    }
}
