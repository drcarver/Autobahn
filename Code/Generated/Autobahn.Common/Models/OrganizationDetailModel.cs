//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationDetailModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationDetail Model
     /// </summary>
    public partial class OrganizationDetailModel : AutobahnBase, Interfaces.IOrganizationDetail
    {
        /// <summary>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </summary>
        public Guid? RefOrganizationTypeId { get; set; }

        /// <summary>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </summary>
        public System.String RegionGeoJSON { get; set; }

        /// <summary>
        /// The title for a particular activity, such as a co-curricular or extra-curricular activity.
        /// </summary>
        public System.String ShortName { get; set; }

    }
}
