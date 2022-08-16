//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendar Model
     /// </summary>
    public partial class OrganizationCalendarModel : AutobahnBase, Interfaces.IOrganizationCalendar
    {
        /// <summary>
        /// 
        /// </summary>
        public  CalendarCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CalendarDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? CalendarYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

    }
}
