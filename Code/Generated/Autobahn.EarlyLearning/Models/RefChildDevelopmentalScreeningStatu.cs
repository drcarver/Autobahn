//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefChildDevelopmentalScreeningStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.EarlyLearning.Interfaces;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The RefChildDevelopmentalScreeningStatu Model
     /// </summary>
    public partial class RefChildDevelopmentalScreeningStatu : ReferenceModelBase, IRefChildDevelopmentalScreeningStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefChildDevelopmentalScreeningStatus"/> model
        /// </summary>
        public Guid RefChildDevelopmentalScreeningStatusId { get; set; }

    }
}
