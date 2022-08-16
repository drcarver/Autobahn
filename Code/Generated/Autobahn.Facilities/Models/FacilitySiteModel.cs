//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySiteModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilitySite Model
     /// </summary>
    public partial class FacilitySiteModel : AutobahnBase, Interfaces.IFacilitySite
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? FacilitySiteArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FacilitySiteIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefBuildingSiteUseRestrictionsTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefFacilitySiteOutdoorAreaTypeId { get; set; }

    }
}
