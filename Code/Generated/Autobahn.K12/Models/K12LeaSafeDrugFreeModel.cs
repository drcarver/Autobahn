//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaSafeDrugFreeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaSafeDrugFree Model
     /// </summary>
    public partial class K12LeaSafeDrugFreeModel : AutobahnBase, Interfaces.IK12LeaSafeDrugFree
    {
        /// <summary>
        /// 
        /// </summary>
        public  Baseline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BaselineYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CollectionFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? IndicatorName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Instrument { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MostRecentCollection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Performance { get; set; }

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
        public  Target { get; set; }

    }
}
