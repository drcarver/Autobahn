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
        /// 
        /// </summary>
         BoardCharges { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BooksAndSuppliesCosts { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ComprehensiveFee { get; set; }

        /// <summary>
        /// 
        /// </summary>
         IPEDSCollectionYearDesignator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         OtherStudentExpenses { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PriceOfAttendance { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTuitionUnitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RequiredStudentFees { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RoomCharges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? SessionDesignator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TuitionPublished { get; set; }

    }
}
