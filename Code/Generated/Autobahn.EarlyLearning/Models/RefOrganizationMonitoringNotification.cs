//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefOrganizationMonitoringNotification.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.EarlyLearning.Interfaces;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The RefOrganizationMonitoringNotification Model
     /// </summary>
    public partial class RefOrganizationMonitoringNotification : ReferenceModelBase, IRefOrganizationMonitoringNotification
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefOrganizationMonitoringNotifications"/> model
        /// </summary>
        public Guid RefOrganizationMonitoringNotificationsId { get; set; }

    }
}
