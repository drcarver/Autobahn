//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationOperationalStatus.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationOperationalStatus Interface
     /// </summary>
    public partial interface IOrganizationOperationalStatus : IAutobahnBase
    {
        /// <summary>
        /// The classification of the operational condition of a local education agency (LEA) at the start of the school year.
        /// </summary>
        System.DateTime? OperationalStatusEffectiveDate { get; set; }

        /// <summary>
        /// The classification of the operational condition of a local education agency (LEA) at the start of the school year.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The classification of the operational condition of a local education agency (LEA) at the start of the school year.
        /// </summary>
        Guid RefOperationalStatusId { get; set; }

    }
}
