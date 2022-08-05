//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefTitleIInstructionalService.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefTitleIInstructionalService Interface
     /// </summary>
    public partial interface IRefTitleIInstructionalService : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTitleIInstructionalServices"/> model
        /// </summary>
        Guid RefTitleIInstructionalServicesId { get; set; }

    }
}
