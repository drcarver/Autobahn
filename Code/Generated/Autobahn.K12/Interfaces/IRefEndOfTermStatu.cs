//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefEndOfTermStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefEndOfTermStatu Interface
     /// </summary>
    public partial interface IRefEndOfTermStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEndOfTermStatus"/> model
        /// </summary>
        Guid RefEndOfTermStatusId { get; set; }

    }
}
