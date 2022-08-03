//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsPriceOfAttendance.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsPriceOfAttendance
     /// </summary>
    public partial class PsPriceOfAttendance : IPsPriceOfAttendance
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PSPriceOfAttendance"/> model
        /// </summary>
        public Guid PSPriceOfAttendanceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="PsInstitution"/> model
        /// </summary>
        public Guid PsInstitutionId { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.SessionDesignator non nullable property
        /// </summary>
        public System.String SessionDesignator { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.TuitionPublished nullable property
        /// </summary>
        public System.Decimal? TuitionPublished { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.BoardCharges nullable property
        /// </summary>
        public System.Decimal? BoardCharges { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.RoomCharges nullable property
        /// </summary>
        public System.Decimal? RoomCharges { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.BooksAndSuppliesCosts nullable property
        /// </summary>
        public System.Decimal? BooksAndSuppliesCosts { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.RequiredStudentFees nullable property
        /// </summary>
        public System.Decimal? RequiredStudentFees { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.ComprehensiveFee nullable property
        /// </summary>
        public System.Decimal? ComprehensiveFee { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.OtherStudentExpenses nullable property
        /// </summary>
        public System.Decimal? OtherStudentExpenses { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.PriceOfAttendance nullable property
        /// </summary>
        public System.Decimal? PriceOfAttendance { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.IPEDSCollectionYearDesignator non nullable property
        /// </summary>
        public System.String IPEDSCollectionYearDesignator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTuitionUnit"/> model
        /// </summary>
        public Guid? RefTuitionUnitId { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.RecordEndDateTime nullable property
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
