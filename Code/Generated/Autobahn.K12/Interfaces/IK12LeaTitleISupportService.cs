//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12LeaTitleISupportService.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaTitleISupportService
     /// </summary>
    public partial interface IK12LeaTitleISupportService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefK12LeaTitleISupportService"/> model
        /// </summary>
        Guid RefK12LeaTitleISupportServiceId { get; set; }

        /// <summary>
        /// Defines the K12LeaTitleISupportService.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12LeaTitleISupportService.RecordEndDateTime nullable property
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
