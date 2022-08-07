//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefOrganizationMonitoringNotificationModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.EarlyLearning.Interfaces;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The RefOrganizationMonitoringNotification Model
     /// </summary>
    public partial class RefOrganizationMonitoringNotificationModel : ReferenceModelBase, IRefOrganizationMonitoringNotificationModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefOrganizationMonitoringNotifications"/> model
        /// </summary>
        public Guid RefOrganizationMonitoringNotificationsId { get; set; }

    }
}
