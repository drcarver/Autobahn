//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ActivityRecognitionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The ActivityRecognition Model
     /// </summary>
    public partial class ActivityRecognitionModel : AutobahnBase, Interfaces.IActivityRecognition
    {
        /// <summary>
        /// The nature of recognition given to the student for accomplishments in a co-curricular, or extra-curricular activity.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The nature of recognition given to the student for accomplishments in a co-curricular, or extra-curricular activity.
        /// </summary>
        public Guid RefActivityRecognitionTypeId { get; set; }

    }
}
