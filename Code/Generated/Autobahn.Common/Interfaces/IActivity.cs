//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IActivity.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IActivity
     /// </summary>
    public partial interface IActivity : IAutobahnBase
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
