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
        /// 
        /// </summary>
        public Guid? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RegionGeoJSON { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ShortName { get; set; }

    }
}
