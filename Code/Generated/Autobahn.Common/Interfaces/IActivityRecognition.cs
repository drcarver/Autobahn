//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IActivityRecognition.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IActivityRecognition
     /// </summary>
    public partial interface IActivityRecognition : IAutobahnBase
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
