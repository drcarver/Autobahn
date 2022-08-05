//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefIntegratedTechnologyStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefIntegratedTechnologyStatu Model
     /// </summary>
    public partial class RefIntegratedTechnologyStatu : ReferenceModelBase, IRefIntegratedTechnologyStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefIntegratedTechnologyStatus"/> model
        /// </summary>
        public Guid RefIntegratedTechnologyStatusId { get; set; }

    }
}
