//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELOrganizationMonitoringModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELOrganizationMonitoringModel Interface
     /// </summary>
    public partial interface IELOrganizationMonitoringModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the ELOrganizationMonitoring.VisitStartDate nullable property
        /// </summary>
        System.DateTime? VisitStartDate { get; set; }

        /// <summary>
        /// Defines the ELOrganizationMonitoring.VisitEndDate nullable property
        /// </summary>
        System.DateTime? VisitEndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPurposeOfMonitoringVisit"/> model
        /// </summary>
        Guid? RefPurposeOfMonitoringVisitId { get; set; }

        /// <summary>
        /// Defines the ELOrganizationMonitoring.TypeOfMonitoring non nullable property
        /// </summary>
        System.String TypeOfMonitoring { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationMonitoringNotifications"/> model
        /// </summary>
        Guid? RefOrganizationMonitoringNotificationsId { get; set; }

    }
}
