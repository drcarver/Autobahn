//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ActivityRecognition.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ActivityRecognition
     /// </summary>
    public partial class ActivityRecognition : AutobahnBase, Interfaces.IActivityRecognition
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefActivityRecognitionType"/> model
        /// </summary>
        public Guid RefActivityRecognitionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
