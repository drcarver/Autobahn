//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELOrganizationMonitoring.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELOrganizationMonitoring
     /// </summary>
    public partial class ELOrganizationMonitoring : AutobahnBase, Interfaces.IELOrganizationMonitoring
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the ELOrganizationMonitoring.VisitStartDate nullable property
        /// </summary>
        public System.DateTime? VisitStartDate { get; set; }

        /// <summary>
        /// Defines the ELOrganizationMonitoring.VisitEndDate nullable property
        /// </summary>
        public System.DateTime? VisitEndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPurposeOfMonitoringVisit"/> model
        /// </summary>
        public Guid? RefPurposeOfMonitoringVisitId { get; set; }

        /// <summary>
        /// Defines the ELOrganizationMonitoring.TypeOfMonitoring non nullable property
        /// </summary>
        public System.String TypeOfMonitoring { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationMonitoringNotifications"/> model
        /// </summary>
        public Guid? RefOrganizationMonitoringNotificationsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
