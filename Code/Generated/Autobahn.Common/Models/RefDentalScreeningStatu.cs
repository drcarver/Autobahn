//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefDentalScreeningStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefDentalScreeningStatu Model
     /// </summary>
    public partial class RefDentalScreeningStatu : ReferenceModelBase, IRefDentalScreeningStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefDentalScreeningStatus"/> model
        /// </summary>
        public Guid RefDentalScreeningStatusId { get; set; }

    }
}
