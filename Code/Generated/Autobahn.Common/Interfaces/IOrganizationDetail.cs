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
        /// Activity Title
        /// <para>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19009">Activity Title</a>
        /// </para>
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefOrganizationType"/> model
        /// </summary>
        Guid? RefOrganizationTypeId { get; set; }

        /// <summary>
        /// Organization Region GeoJSON
        /// <para>
        /// The geo-political area of the organization's facility, building, or site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20731">Organization Region GeoJSON</a>
        /// </para>
        /// </summary>
        System.String RegionGeoJSON { get; set; }

        /// <summary>
        /// Short Name of Institution
        /// <para>
        /// The name of the institution, which may be the abbreviated form of the full legally accepted name.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20459">Short Name of Institution</a>
        /// </para>
        /// </summary>
        System.String ShortName { get; set; }

    }
}
