//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ActivityModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Activity Model
     /// </summary>
    public partial class ActivityModel : AutobahnBase, Interfaces.IActivityModel
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
