//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationImage.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationImage Interface
     /// </summary>
    public partial interface IOrganizationImage : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        System.String URL { get; set; }

    }
}
