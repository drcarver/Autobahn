//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonStatus.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonStatus
     /// </summary>
    public partial class PersonStatus : IPersonStatus
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonStatusType"/> model
        /// </summary>
        public Guid RefPersonStatusTypeId { get; set; }

        /// <summary>
        /// Defines the PersonStatus.StatusValue non nullable property
        /// </summary>
        public System.Boolean StatusValue { get; set; }

        /// <summary>
        /// Defines the PersonStatus.StatusStartDate nullable property
        /// </summary>
        public System.DateTime? StatusStartDate { get; set; }

        /// <summary>
        /// Defines the PersonStatus.StatusEndDate nullable property
        /// </summary>
        public System.DateTime? StatusEndDate { get; set; }

        /// <summary>
        /// Defines the PersonStatus.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonStatus.RecordEndDateTime nullable property
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
