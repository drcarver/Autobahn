//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTrimesterWhenPrenatalCareBegan.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefTrimesterWhenPrenatalCareBegan
     /// </summary>
    public partial class RefTrimesterWhenPrenatalCareBegan : IRefTrimesterWhenPrenatalCareBegan
    {
        /// <summary>
        /// Defines the RefTrimesterWhenPrenatalCareBegan.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefTrimesterWhenPrenatalCareBegan.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefTrimesterWhenPrenatalCareBegan.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefTrimesterWhenPrenatalCareBegan.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefTrimesterWhenPrenatalCareBegan.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefTrimesterWhenPrenatalCareBegan.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}