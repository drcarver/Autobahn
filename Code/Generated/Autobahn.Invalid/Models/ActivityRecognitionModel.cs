//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ActivityRecognitionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ActivityRecognition Model
     /// </summary>
    public partial class ActivityRecognitionModel : AutobahnBase, Interfaces.IActivityRecognition
    {
        /// <summary>
        /// The nature of recognition given to the student for accomplishments in a co-curricular, or extra-curricular activity.
        /// </summary>
        public Guid RefActivityRecognitionTypeId { get; set; }

    }
}
