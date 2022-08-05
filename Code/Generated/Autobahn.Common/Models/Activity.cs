//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Activity.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Activity
     /// </summary>
    public partial class Activity : AutobahnBase, Interfaces.IActivity
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the Activity.ActivityDescription non nullable property
        /// </summary>
        public System.String ActivityDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
