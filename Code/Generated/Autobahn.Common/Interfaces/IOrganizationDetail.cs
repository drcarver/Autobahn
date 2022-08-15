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
        /// The name of a data system or application which an authenticated person may access.
        /// </summary>
        System.String Name { get; set; }

    }
}
