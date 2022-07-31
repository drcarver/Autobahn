//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELOrganization.cs
//**********************************************************

using Autobahn.EarlyLearning.Interfaces;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELOrganization
     /// </summary>
    public partial class ELOrganization : IELOrganization
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ELOrganization"/> model
        /// </summary>
        public Guid ELOrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProfitStatus"/> model
        /// </summary>
        public Guid? RefProfitStatusId { get; set; }

        /// <summary>
        /// Defines the ELOrganization.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ELOrganization.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
