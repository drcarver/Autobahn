//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefReapAlternativeFundingStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefReapAlternativeFundingStatu Interface
     /// </summary>
    public partial interface IRefReapAlternativeFundingStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefReapAlternativeFundingStatus"/> model
        /// </summary>
        Guid RefReapAlternativeFundingStatusId { get; set; }

    }
}
