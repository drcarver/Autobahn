//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IServicePlan.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IServicePlan
     /// </summary>
    public partial interface IServicePlan
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

        /// <summary>
        /// Defines the ServicePlan.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ServicePlan.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
