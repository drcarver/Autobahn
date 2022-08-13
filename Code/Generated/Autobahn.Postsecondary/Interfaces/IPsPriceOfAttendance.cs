//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsPriceOfAttendance.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsPriceOfAttendance Interface
     /// </summary>
    public partial interface IPsPriceOfAttendance : IAutobahnBase
    {
        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        System.Decimal? BoardCharges { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        System.Decimal? BooksAndSuppliesCosts { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        System.Decimal? ComprehensiveFee { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        System.String IPEDSCollectionYearDesignator { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        System.Decimal? OtherStudentExpenses { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        System.Decimal? PriceOfAttendance { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        Guid PsInstitutionId { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        Guid PSPriceOfAttendanceId { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        Guid? RefTuitionUnitId { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        System.Decimal? RequiredStudentFees { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        System.Decimal? RoomCharges { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        System.String SessionDesignator { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        System.Decimal? TuitionPublished { get; set; }

    }
}
