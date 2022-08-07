//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationIndicatorModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationIndicatorModel Interface
     /// </summary>
    public partial interface IOrganizationIndicatorModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationIndicator.IndicatorValue non nullable property
        /// </summary>
        System.String IndicatorValue { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefOrganizationIndicator"/> model
        /// </summary>
        Guid RefOrganizationIndicatorId { get; set; }

    }
}
