//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELOrganizationMonitoringModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELOrganizationMonitoring Model
     /// </summary>
    public partial class ELOrganizationMonitoringModel : AutobahnBase, Interfaces.IELOrganizationMonitoringModel
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
