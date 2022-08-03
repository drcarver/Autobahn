//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonHomelessness.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonHomelessness
     /// </summary>
    public partial interface IPersonHomelessness
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonHomelessness.HomelessnessStatus non nullable property
        /// </summary>
        System.Boolean HomelessnessStatus { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefHomelessNighttimeResidence"/> model
        /// </summary>
        Guid RefHomelessNighttimeResidenceId { get; set; }

        /// <summary>
        /// Defines the PersonHomelessness.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonHomelessness.RecordEndDateTime nullable property
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
