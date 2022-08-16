//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentActivityModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12StudentActivity Model
     /// </summary>
    public partial class K12StudentActivityModel : AutobahnBase, Interfaces.IK12StudentActivity
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? ActivityTimeInvolved { get; set; }

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
        public  RefActivityTimeMeasurementTypeId { get; set; }

    }
}
