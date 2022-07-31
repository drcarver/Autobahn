//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELOrganization.cs
//**********************************************************

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELOrganization
     /// </summary>
    public partial Interface IELOrganization
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ELOrganization"/> model
        /// </summary>
        Guid ELOrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfitStatus"/> model
        /// </summary>
        Guid? RefProfitStatusId { get; set; }

        /// <summary>
        /// Defines the ELOrganization.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ELOrganization.RecordEndDateTime nullable property
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
