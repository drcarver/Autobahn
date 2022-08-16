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
        /// 
        /// </summary>
        Guid? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RegionGeoJSON { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ShortName { get; set; }

    }
}
