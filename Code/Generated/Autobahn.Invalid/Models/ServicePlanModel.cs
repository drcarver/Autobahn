//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServicePlanModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ServicePlan Model
     /// </summary>
    public partial class ServicePlanModel : AutobahnBase, Interfaces.IServicePlan
    {
        /// <summary>
        /// 
        /// </summary>
        public  DeclinedServicesDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ExtendsOutsideSchoolYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ReasonForDeclinedServices { get; set; }

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
        public  SettingDescription { get; set; }

    }
}
