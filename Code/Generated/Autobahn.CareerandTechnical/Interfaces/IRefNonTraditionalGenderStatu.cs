//**********************************************************
//* DomainName: Autobahn.CareerandTechnical
//* FileName:   IRefNonTraditionalGenderStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.CareerandTechnical.Interfaces
{
     /// <summary>
     /// The RefNonTraditionalGenderStatu Interface
     /// </summary>
    public partial interface IRefNonTraditionalGenderStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefNonTraditionalGenderStatus"/> model
        /// </summary>
        Guid RefNonTraditionalGenderStatusId { get; set; }

    }
}
