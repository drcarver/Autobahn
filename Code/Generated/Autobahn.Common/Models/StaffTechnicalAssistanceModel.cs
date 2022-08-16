//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffTechnicalAssistanceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffTechnicalAssistance Model
     /// </summary>
    public partial class StaffTechnicalAssistanceModel : AutobahnBase, Interfaces.IStaffTechnicalAssistance
    {
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
        public  RefTechnicalAssistanceDeliveryTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTechnicalAssistanceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? TechnicalAssistanceApprovedInd { get; set; }

    }
}
