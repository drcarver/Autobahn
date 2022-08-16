//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityFinancialModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityFinancial Model
     /// </summary>
    public partial class FacilityFinancialModel : AutobahnBase, Interfaces.IFacilityFinancial
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
