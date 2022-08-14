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
        /// The reason given for declining the recommended services.
        /// </summary>
        public System.DateTime? DeclinedServicesDate { get; set; }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        public System.Boolean? ExtendsOutsideSchoolYear { get; set; }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        public System.Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        public System.String ReasonForDeclinedServices { get; set; }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        public System.String SettingDescription { get; set; }

    }
}
