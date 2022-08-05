//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTelephoneNumberListedStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefTelephoneNumberListedStatu Model
     /// </summary>
    public partial class RefTelephoneNumberListedStatu : ReferenceModelBase, IRefTelephoneNumberListedStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefTelephoneNumberListedStatus"/> model
        /// </summary>
        public Guid RefTelephoneNumberListedStatusId { get; set; }

    }
}
