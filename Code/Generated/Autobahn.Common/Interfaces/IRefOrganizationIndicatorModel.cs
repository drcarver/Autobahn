//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefOrganizationIndicatorModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefOrganizationIndicator Interface Model
     /// </summary>
    public partial interface IRefOrganizationIndicatorModel : IReferenceModel
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationType"/> model
        /// </summary>
        Guid? RefOrganizationTypeId { get; set; }

    }
}
