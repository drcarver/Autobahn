//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefAlternateFundUsModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefAlternateFundUs Interface Model
     /// </summary>
    public partial interface IRefAlternateFundUsModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAlternateFundUses"/> model
        /// </summary>
        Guid RefAlternateFundUsesId { get; set; }

    }
}
