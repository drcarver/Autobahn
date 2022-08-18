//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IActivityRecognition.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IActivityRecognition Interface
     /// </summary>
    public partial interface IActivityRecognition : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefActivityRecognitionType"/> model
        /// </summary>
        Guid RefActivityRecognitionTypeId { get; set; }

    }
}
