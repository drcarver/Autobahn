//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSingleSexClassStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefSingleSexClassStatu Model
     /// </summary>
    public partial class RefSingleSexClassStatu : ReferenceModelBase, IRefSingleSexClassStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefSingleSexClassStatus"/> model
        /// </summary>
        public Guid RefSingleSexClassStatusId { get; set; }

    }
}
