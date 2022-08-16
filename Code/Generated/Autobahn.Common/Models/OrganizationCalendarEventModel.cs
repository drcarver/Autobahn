//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarEventModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarEvent Model
     /// </summary>
    public partial class OrganizationCalendarEventModel : AutobahnBase, Interfaces.IOrganizationCalendarEvent
    {
        /// <summary>
        /// 
        /// </summary>
        public  EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EventDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Name { get; set; }

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
        public Guid? RefCalendarEventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StartTime { get; set; }

    }
}
