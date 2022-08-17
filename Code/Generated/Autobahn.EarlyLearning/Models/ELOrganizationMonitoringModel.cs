//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationMonitoringModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The ELOrganizationMonitoring Model
     /// </summary>
    public partial class ELOrganizationMonitoringModel : AutobahnBase, Interfaces.IELOrganizationMonitoring
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Organization Monitoring Notifications
        /// <para>
        /// Whether the organization received notification about monitoring
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20296">Organization Monitoring Notifications</a>
        /// </para>
        /// </summary>
        public Guid? RefOrganizationMonitoringNotificationsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPurposeOfMonitoringVisit"/> model
        /// </summary>
        public Guid? RefPurposeOfMonitoringVisitId { get; set; }

        /// <summary>
        /// Organization Type of Monitoring
        /// <para>
        /// The type of monitoring on the organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20300">Organization Type of Monitoring</a>
        /// </para>
        /// </summary>
        public System.String TypeOfMonitoring { get; set; }

        /// <summary>
        /// Monitoring Visit End Date
        /// <para>
        /// The date that monitoring visit ended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20298">Monitoring Visit End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? VisitEndDate { get; set; }

        /// <summary>
        /// Monitoring Visit Start Date
        /// <para>
        /// The date that monitoring visit began.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20297">Monitoring Visit Start Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? VisitStartDate { get; set; }

    }
}
