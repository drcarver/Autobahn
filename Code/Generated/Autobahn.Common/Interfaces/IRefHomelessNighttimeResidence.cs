//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefHomelessNighttimeResidence.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefHomelessNighttimeResidence
     /// </summary>
    public partial interface IRefHomelessNighttimeResidence
    {
        /// <summary>
        /// Defines the RefHomelessNighttimeResidence.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefHomelessNighttimeResidence.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefHomelessNighttimeResidence.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefHomelessNighttimeResidence.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefHomelessNighttimeResidence.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefHomelessNighttimeResidence.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
