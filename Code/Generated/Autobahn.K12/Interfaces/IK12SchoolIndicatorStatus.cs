//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SchoolIndicatorStatus.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolIndicatorStatus Interface
     /// </summary>
    public partial interface IK12SchoolIndicatorStatus : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

    }
}
