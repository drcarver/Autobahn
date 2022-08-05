//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ServicePlan.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ServicePlan
     /// </summary>
    public partial class ServicePlan : AutobahnBase, Interfaces.IServicePlan
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ServicePlan.DeclinedServicesDate nullable property
        /// </summary>
        public System.DateTime? DeclinedServicesDate { get; set; }

        /// <summary>
        /// Defines the ServicePlan.ExtendsOutsideSchoolYear nullable property
        /// </summary>
        public System.Boolean? ExtendsOutsideSchoolYear { get; set; }

        /// <summary>
        /// Defines the ServicePlan.InclusiveSettingIndicator nullable property
        /// </summary>
        public System.Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// Defines the ServicePlan.ReasonForDeclinedServices non nullable property
        /// </summary>
        public System.String ReasonForDeclinedServices { get; set; }

        /// <summary>
        /// Defines the ServicePlan.SettingDescription non nullable property
        /// </summary>
        public System.String SettingDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
