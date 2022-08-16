//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationPersonRoleApplication.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRoleApplication Interface
     /// </summary>
    public partial interface IOrganizationPersonRoleApplication : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? ApplicationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
