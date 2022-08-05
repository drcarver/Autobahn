//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefIndicatorStateDefinedStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefIndicatorStateDefinedStatu Interface
     /// </summary>
    public partial interface IRefIndicatorStateDefinedStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefIndicatorStateDefinedStatus"/> model
        /// </summary>
        Guid RefIndicatorStateDefinedStatusId { get; set; }

    }
}
