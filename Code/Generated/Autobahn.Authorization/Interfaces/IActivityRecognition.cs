//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IActivityRecognition.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IActivityRecognition Interface
     /// </summary>
    public partial interface IActivityRecognition : IAutobahnBase
    {
        /// <summary>
        /// The nature of recognition given to the student for accomplishments in a co-curricular, or extra-curricular activity.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The nature of recognition given to the student for accomplishments in a co-curricular, or extra-curricular activity.
        /// </summary>
        Guid RefActivityRecognitionTypeId { get; set; }

    }
}
