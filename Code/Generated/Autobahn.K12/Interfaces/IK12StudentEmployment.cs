//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StudentEmployment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StudentEmployment Interface
     /// </summary>
    public partial interface IK12StudentEmployment : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         EmploymentNaicsCode { get; set; }

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
         RefEmployedAfterExitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefEmployedWhileEnrolledId { get; set; }

    }
}
