//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefTitleIInstructionalServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefTitleIInstructionalService Interface Model
     /// </summary>
    public partial interface IRefTitleIInstructionalServiceModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTitleIInstructionalServices"/> model
        /// </summary>
        Guid RefTitleIInstructionalServicesId { get; set; }

    }
}
