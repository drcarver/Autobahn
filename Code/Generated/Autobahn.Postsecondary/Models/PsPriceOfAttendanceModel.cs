//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsPriceOfAttendanceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsPriceOfAttendance Model
     /// </summary>
    public partial class PsPriceOfAttendanceModel : AutobahnBase, Interfaces.IPsPriceOfAttendance
    {
        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? BoardCharges { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? BooksAndSuppliesCosts { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? ComprehensiveFee { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.String IPEDSCollectionYearDesignator { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? OtherStudentExpenses { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? PriceOfAttendance { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public Guid PsInstitutionId { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public Guid PSPriceOfAttendanceId { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public Guid? RefTuitionUnitId { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? RequiredStudentFees { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? RoomCharges { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.String SessionDesignator { get; set; }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.Decimal? TuitionPublished { get; set; }

    }
}
