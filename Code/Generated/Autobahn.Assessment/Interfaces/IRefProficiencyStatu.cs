//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRefProficiencyStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The RefProficiencyStatu Interface
     /// </summary>
    public partial interface IRefProficiencyStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefProficiencyStatus"/> model
        /// </summary>
        Guid RefProficiencyStatusId { get; set; }

    }
}
