//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefIndicatorStateDefinedStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefIndicatorStateDefinedStatu Model
     /// </summary>
    public partial class RefIndicatorStateDefinedStatu : ReferenceModelBase, IRefIndicatorStateDefinedStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefIndicatorStateDefinedStatus"/> model
        /// </summary>
        public Guid RefIndicatorStateDefinedStatusId { get; set; }

    }
}
