//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELOrganizationMonitoring.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELOrganizationMonitoring Interface
     /// </summary>
    public partial interface IELOrganizationMonitoring : IAutobahnBase
    {
        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        Guid? RefOrganizationMonitoringNotificationsId { get; set; }

        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        Guid? RefPurposeOfMonitoringVisitId { get; set; }

        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        System.String TypeOfMonitoring { get; set; }

        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        System.DateTime? VisitEndDate { get; set; }

        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        System.DateTime? VisitStartDate { get; set; }

    }
}
