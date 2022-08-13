//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationDetail.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationDetail Interface
     /// </summary>
    public partial interface IOrganizationDetail : IAutobahnBase
    {
        /// <summary>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </summary>
        Guid? RefOrganizationTypeId { get; set; }

        /// <summary>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </summary>
        System.String RegionGeoJSON { get; set; }

        /// <summary>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </summary>
        System.String ShortName { get; set; }

    }
}
