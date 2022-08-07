//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ActivityRecognitionModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ActivityRecognition Model
     /// </summary>
    public partial class ActivityRecognitionModel : AutobahnBase, Interfaces.IActivityRecognitionModel
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
