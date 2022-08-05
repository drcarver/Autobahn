//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefProfitStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.EarlyLearning.Interfaces;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The RefProfitStatu Model
     /// </summary>
    public partial class RefProfitStatu : ReferenceModelBase, IRefProfitStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefProfitStatus"/> model
        /// </summary>
        public Guid RefProfitStatusId { get; set; }

    }
}
