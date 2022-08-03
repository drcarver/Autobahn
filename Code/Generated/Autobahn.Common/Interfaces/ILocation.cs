//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ILocation.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The ILocation
     /// </summary>
    public partial interface ILocation
    {
        /// <summary>
        /// Defines the Location.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the Location.RecordEndDateTime nullable property
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
