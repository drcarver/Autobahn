//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationIndicator.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationIndicator
     /// </summary>
    public partial interface IOrganizationIndicator
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

        /// <summary>
        /// Defines the OrganizationIndicator.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationIndicator.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
