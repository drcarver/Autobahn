//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IServicePlanModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IServicePlanModel Interface
     /// </summary>
    public partial interface IServicePlanModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the ServicePlan.DeclinedServicesDate nullable property
        /// </summary>
        System.DateTime? DeclinedServicesDate { get; set; }

        /// <summary>
        /// Defines the ServicePlan.ExtendsOutsideSchoolYear nullable property
        /// </summary>
        System.Boolean? ExtendsOutsideSchoolYear { get; set; }

        /// <summary>
        /// Defines the ServicePlan.InclusiveSettingIndicator nullable property
        /// </summary>
        System.Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// Defines the ServicePlan.ReasonForDeclinedServices non nullable property
        /// </summary>
        System.String ReasonForDeclinedServices { get; set; }

        /// <summary>
        /// Defines the ServicePlan.SettingDescription non nullable property
        /// </summary>
        System.String SettingDescription { get; set; }

    }
}
