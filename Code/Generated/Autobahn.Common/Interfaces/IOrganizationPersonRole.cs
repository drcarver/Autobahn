//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationPersonRole.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRole Interface
     /// </summary>
    public partial interface IOrganizationPersonRole : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day on which the person began to participate in the activity.
        /// </summary>
        System.DateTime? EntryDate { get; set; }

    }
}
