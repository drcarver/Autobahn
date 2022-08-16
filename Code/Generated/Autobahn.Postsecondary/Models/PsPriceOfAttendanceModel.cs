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
        /// 
        /// </summary>
        public  BoardCharges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  BooksAndSuppliesCosts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ComprehensiveFee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  IPEDSCollectionYearDesignator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  OtherStudentExpenses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PriceOfAttendance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTuitionUnitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RequiredStudentFees { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RoomCharges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? SessionDesignator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  TuitionPublished { get; set; }

    }
}
