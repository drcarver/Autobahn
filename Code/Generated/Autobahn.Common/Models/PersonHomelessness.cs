//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonHomelessness.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonHomelessness
     /// </summary>
    public partial class PersonHomelessness : AutobahnBase, Interfaces.IPersonHomelessness
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
