//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonStatus.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonStatus
     /// </summary>
    public partial class PersonStatus : AutobahnBase, Interfaces.IPersonStatus
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
