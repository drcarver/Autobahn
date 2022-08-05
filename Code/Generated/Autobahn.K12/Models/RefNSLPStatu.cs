//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefNSLPStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefNSLPStatu Model
     /// </summary>
    public partial class RefNSLPStatu : ReferenceModelBase, IRefNSLPStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefNSLPStatus"/> model
        /// </summary>
        public Guid RefNSLPStatusId { get; set; }

    }
}
