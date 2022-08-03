//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonHomelessness.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonHomelessness
     /// </summary>
    public partial class PersonHomelessness : IPersonHomelessness
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonHomelessness.HomelessnessStatus non nullable property
        /// </summary>
        public System.Boolean HomelessnessStatus { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefHomelessNighttimeResidence"/> model
        /// </summary>
        public Guid RefHomelessNighttimeResidenceId { get; set; }

        /// <summary>
        /// Defines the PersonHomelessness.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonHomelessness.RecordEndDateTime nullable property
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
