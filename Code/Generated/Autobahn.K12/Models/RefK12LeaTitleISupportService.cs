//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefK12LeaTitleISupportService.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefK12LeaTitleISupportService
     /// </summary>
    public partial class RefK12LeaTitleISupportService : IRefK12LeaTitleISupportService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefK12LEATitleISupportService"/> model
        /// </summary>
        public Guid RefK12LEATitleISupportServiceId { get; set; }

        /// <summary>
        /// Defines the RefK12LeaTitleISupportService.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefK12LeaTitleISupportService.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefK12LeaTitleISupportService.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefK12LeaTitleISupportService.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefK12LeaTitleISupportService.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefK12LeaTitleISupportService.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
