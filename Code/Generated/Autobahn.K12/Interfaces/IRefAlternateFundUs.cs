//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefAlternateFundUs.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefAlternateFundUs Interface
     /// </summary>
    public partial interface IRefAlternateFundUs : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAlternateFundUses"/> model
        /// </summary>
        Guid RefAlternateFundUsesId { get; set; }

    }
}
