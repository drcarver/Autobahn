//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefApipInteractionType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefApipInteractionType Interface
     /// </summary>
    public partial interface IRefApipInteractionType : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAPIPInteractionType"/> model
        /// </summary>
        Guid RefAPIPInteractionTypeId { get; set; }

    }
}
