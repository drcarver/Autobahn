//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IServicePlan.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IServicePlan Interface
     /// </summary>
    public partial interface IServicePlan : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         DeclinedServicesDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ExtendsOutsideSchoolYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? ReasonForDeclinedServices { get; set; }

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
         SettingDescription { get; set; }

    }
}
