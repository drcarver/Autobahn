//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEvaluationPartModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffEvaluationPart Model
     /// </summary>
    public partial class StaffEvaluationPartModel : AutobahnBase, Interfaces.IStaffEvaluationPart
    {
        /// <summary>
        /// 
        /// </summary>
        public  PartName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Scale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ScoreOrRating { get; set; }

    }
}
