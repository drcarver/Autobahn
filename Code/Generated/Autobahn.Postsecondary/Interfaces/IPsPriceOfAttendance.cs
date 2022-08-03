//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsPriceOfAttendance.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsPriceOfAttendance
     /// </summary>
    public partial interface IPsPriceOfAttendance
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PSPriceOfAttendance"/> model
        /// </summary>
        Guid PSPriceOfAttendanceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="PsInstitution"/> model
        /// </summary>
        Guid PsInstitutionId { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.SessionDesignator non nullable property
        /// </summary>
        System.String SessionDesignator { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.TuitionPublished nullable property
        /// </summary>
        System.Decimal? TuitionPublished { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.BoardCharges nullable property
        /// </summary>
        System.Decimal? BoardCharges { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.RoomCharges nullable property
        /// </summary>
        System.Decimal? RoomCharges { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.BooksAndSuppliesCosts nullable property
        /// </summary>
        System.Decimal? BooksAndSuppliesCosts { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.RequiredStudentFees nullable property
        /// </summary>
        System.Decimal? RequiredStudentFees { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.ComprehensiveFee nullable property
        /// </summary>
        System.Decimal? ComprehensiveFee { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.OtherStudentExpenses nullable property
        /// </summary>
        System.Decimal? OtherStudentExpenses { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.PriceOfAttendance nullable property
        /// </summary>
        System.Decimal? PriceOfAttendance { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.IPEDSCollectionYearDesignator non nullable property
        /// </summary>
        System.String IPEDSCollectionYearDesignator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTuitionUnit"/> model
        /// </summary>
        Guid? RefTuitionUnitId { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsPriceOfAttendance.RecordEndDateTime nullable property
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
