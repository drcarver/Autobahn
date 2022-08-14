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
        /// The reason given for declining the recommended services.
        /// </summary>
        System.DateTime? DeclinedServicesDate { get; set; }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        System.Boolean? ExtendsOutsideSchoolYear { get; set; }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        System.Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        System.String ReasonForDeclinedServices { get; set; }

        /// <summary>
        /// The reason given for declining the recommended services.
        /// </summary>
        System.String SettingDescription { get; set; }

    }
}
