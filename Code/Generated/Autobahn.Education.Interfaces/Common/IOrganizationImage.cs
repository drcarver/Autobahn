//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationImage.cs
//***************************************************************************

namespace Autobahn.Education.Interfaces.Common
{
     /// <summary>
     /// The IOrganizationImage Interface
     /// </summary>
    public partial interface IOrganizationImage : IAutobahnBase
    {
        #region IOrganizationImage
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        System.String Url { get; set; }

        #endregion
    }
}
