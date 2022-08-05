//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefIntegratedTechnologyStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefIntegratedTechnologyStatu Interface
     /// </summary>
    public partial interface IRefIntegratedTechnologyStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefIntegratedTechnologyStatus"/> model
        /// </summary>
        Guid RefIntegratedTechnologyStatusId { get; set; }

    }
}
