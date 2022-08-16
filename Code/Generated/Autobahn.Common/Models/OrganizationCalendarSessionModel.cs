//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarSessionModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarSession Model
     /// </summary>
    public partial class OrganizationCalendarSessionModel : AutobahnBase, Interfaces.IOrganizationCalendarSession
    {
        /// <summary>
        /// 
        /// </summary>
        public  AttendanceTermIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? BeginDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DaysInSession { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Designator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FirstInstructionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InstructionalMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LastInstructionDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MarkingTermIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MinutesPerDay { get; set; }

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
        public  RefAcademicTermDesignatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefSessionTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SchedulingTermIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SessionEndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SessionStartTime { get; set; }

    }
}
