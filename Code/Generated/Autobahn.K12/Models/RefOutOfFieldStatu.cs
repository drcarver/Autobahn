//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefOutOfFieldStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefOutOfFieldStatu Model
     /// </summary>
    public partial class RefOutOfFieldStatu : ReferenceModelBase, IRefOutOfFieldStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefOutOfFieldStatus"/> model
        /// </summary>
        public Guid RefOutOfFieldStatusId { get; set; }

    }
}
