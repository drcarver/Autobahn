//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefK12LeaTitleISupportService.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IRefK12LeaTitleISupportService
     /// </summary>
    public partial interface IRefK12LeaTitleISupportService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefK12LEATitleISupportService"/> model
        /// </summary>
        Guid RefK12LEATitleISupportServiceId { get; set; }

        /// <summary>
        /// Defines the RefK12LeaTitleISupportService.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefK12LeaTitleISupportService.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefK12LeaTitleISupportService.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefK12LeaTitleISupportService.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefK12LeaTitleISupportService.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefK12LeaTitleISupportService.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
