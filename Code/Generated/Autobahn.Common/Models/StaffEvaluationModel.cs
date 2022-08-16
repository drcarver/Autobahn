//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffEvaluation Model
     /// </summary>
    public partial class StaffEvaluationModel : AutobahnBase, Interfaces.IStaffEvaluation
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Outcome { get; set; }

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
        public  RefStaffPerformanceLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Scale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ScoreOrRating { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  System { get; set; }

    }
}
