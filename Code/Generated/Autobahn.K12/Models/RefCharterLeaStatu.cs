//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefCharterLeaStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefCharterLeaStatu Model
     /// </summary>
    public partial class RefCharterLeaStatu : ReferenceModelBase, IRefCharterLeaStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCharterLeaStatus"/> model
        /// </summary>
        public Guid RefCharterLeaStatusId { get; set; }

    }
}
