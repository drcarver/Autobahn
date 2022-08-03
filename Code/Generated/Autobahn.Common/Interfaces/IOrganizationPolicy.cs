//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationPolicy.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPolicy
     /// </summary>
    public partial interface IOrganizationPolicy
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationPolicy.PolicyType non nullable property
        /// </summary>
        System.String PolicyType { get; set; }

        /// <summary>
        /// Defines the OrganizationPolicy.Value non nullable property
        /// </summary>
        System.String Value { get; set; }

        /// <summary>
        /// Defines the OrganizationPolicy.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the OrganizationPolicy.RecordEndDateTime nullable property
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
