//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IActivityRecognitionModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IActivityRecognitionModel Interface
     /// </summary>
    public partial interface IActivityRecognitionModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefActivityRecognitionType"/> model
        /// </summary>
        Guid RefActivityRecognitionTypeId { get; set; }

    }
}
