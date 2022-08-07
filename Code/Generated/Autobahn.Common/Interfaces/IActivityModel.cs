//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IActivityModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IActivityModel Interface
     /// </summary>
    public partial interface IActivityModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the Activity.ActivityDescription non nullable property
        /// </summary>
        System.String ActivityDescription { get; set; }

    }
}
