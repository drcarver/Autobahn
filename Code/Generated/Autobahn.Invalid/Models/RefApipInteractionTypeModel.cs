//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefApipInteractionTypeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

using Autobahn.Invalid.Interfaces;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The RefApipInteractionType Model
     /// </summary>
    public partial class RefApipInteractionType : ReferenceModelBase, Interfaces.IRefApipInteractionType
    {
        /// <summary>
        /// The assessment item body interaction type as defined by IMS Global specifications.
        /// </summary>
        public Guid RefAPIPInteractionTypeId { get; set; }

    }
}
