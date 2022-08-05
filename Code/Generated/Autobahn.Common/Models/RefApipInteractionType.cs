//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefApipInteractionType.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefApipInteractionType Model
     /// </summary>
    public partial class RefApipInteractionType : ReferenceModelBase, IRefApipInteractionType
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAPIPInteractionType"/> model
        /// </summary>
        public Guid RefAPIPInteractionTypeId { get; set; }

    }
}
