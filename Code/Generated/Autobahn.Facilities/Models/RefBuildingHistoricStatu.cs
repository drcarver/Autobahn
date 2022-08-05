//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingHistoricStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefBuildingHistoricStatu Model
     /// </summary>
    public partial class RefBuildingHistoricStatu : ReferenceModelBase, IRefBuildingHistoricStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefBuildingHistoricStatus"/> model
        /// </summary>
        public Guid RefBuildingHistoricStatusId { get; set; }

    }
}
