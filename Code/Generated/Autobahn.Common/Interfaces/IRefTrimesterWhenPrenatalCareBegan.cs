//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefTrimesterWhenPrenatalCareBegan.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefTrimesterWhenPrenatalCareBegan
     /// </summary>
    public partial interface IRefTrimesterWhenPrenatalCareBegan
    {
        /// <summary>
        /// Defines the RefTrimesterWhenPrenatalCareBegan.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefTrimesterWhenPrenatalCareBegan.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefTrimesterWhenPrenatalCareBegan.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefTrimesterWhenPrenatalCareBegan.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefTrimesterWhenPrenatalCareBegan.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefTrimesterWhenPrenatalCareBegan.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
