//**********************************************************
//* DomainName: Autobahn.CareerandTechnical
//* FileName:   RefNonTraditionalGenderStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.CareerandTechnical.Interfaces;

namespace Autobahn.CareerandTechnical.Models
{
     /// <summary>
     /// The RefNonTraditionalGenderStatu Model
     /// </summary>
    public partial class RefNonTraditionalGenderStatu : ReferenceModelBase, IRefNonTraditionalGenderStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefNonTraditionalGenderStatus"/> model
        /// </summary>
        public Guid RefNonTraditionalGenderStatusId { get; set; }

    }
}
