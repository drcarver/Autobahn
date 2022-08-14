//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IRefApipInteractionType.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The RefApipInteractionType Interface Model
     /// </summary>
    public partial interface IRefApipInteractionType : IReferenceModel
    {
        /// <summary>
        /// The assessment item body interaction type as defined by IMS Global specifications.
        /// </summary>
        Guid RefAPIPInteractionTypeId { get; set; }

    }
}
