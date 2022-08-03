//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaTitleISupportService.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaTitleISupportService
     /// </summary>
    public partial class K12LeaTitleISupportService : IK12LeaTitleISupportService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefK12LeaTitleISupportService"/> model
        /// </summary>
        public Guid RefK12LeaTitleISupportServiceId { get; set; }

        /// <summary>
        /// Defines the K12LeaTitleISupportService.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12LeaTitleISupportService.RecordEndDateTime nullable property
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
