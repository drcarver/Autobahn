//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentActivity.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentActivity Interface
     /// </summary>
    public partial interface IK12StudentActivity : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? ActivityTimeInvolved { get; set; }

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
         RefActivityTimeMeasurementTypeId { get; set; }

    }
}
