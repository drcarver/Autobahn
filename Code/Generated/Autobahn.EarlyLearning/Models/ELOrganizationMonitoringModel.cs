//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationMonitoringModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELOrganizationMonitoring Model
     /// </summary>
    public partial class ELOrganizationMonitoringModel : AutobahnBase, Interfaces.IELOrganizationMonitoring
    {
        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        public Guid? RefOrganizationMonitoringNotificationsId { get; set; }

        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        public Guid? RefPurposeOfMonitoringVisitId { get; set; }

        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        public System.String TypeOfMonitoring { get; set; }

        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        public System.DateTime? VisitEndDate { get; set; }

        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        public System.DateTime? VisitStartDate { get; set; }

    }
}
