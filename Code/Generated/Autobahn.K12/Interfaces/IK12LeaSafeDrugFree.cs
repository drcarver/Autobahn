//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12LeaSafeDrugFree.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaSafeDrugFree Interface
     /// </summary>
    public partial interface IK12LeaSafeDrugFree : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         Baseline { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BaselineYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CollectionFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? IndicatorName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Instrument { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MostRecentCollection { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Performance { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Target { get; set; }

    }
}
