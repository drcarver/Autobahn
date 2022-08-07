//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefApipInteractionTypeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefApipInteractionType Interface Model
     /// </summary>
    public partial interface IRefApipInteractionTypeModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAPIPInteractionType"/> model
        /// </summary>
        Guid RefAPIPInteractionTypeId { get; set; }

    }
}
