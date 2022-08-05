//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefIDEAIEPStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.EarlyLearning.Interfaces;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The RefIDEAIEPStatu Model
     /// </summary>
    public partial class RefIDEAIEPStatu : ReferenceModelBase, IRefIDEAIEPStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefIDEAIEPStatus"/> model
        /// </summary>
        public Guid RefIDEAIEPStatusId { get; set; }

    }
}
