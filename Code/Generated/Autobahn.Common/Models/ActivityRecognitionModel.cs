//**********************************************************
//* DomainName: Common Models
//* FileName:   ActivityRecognitionModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ActivityRecognition Model
     /// </summary>
    public partial class ActivityRecognitionModel : AutobahnBase, Interfaces.IActivityRecognition
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefActivityRecognitionType"/> model
        /// </summary>
        public Guid RefActivityRecognitionTypeId { get; set; }

    }
}
