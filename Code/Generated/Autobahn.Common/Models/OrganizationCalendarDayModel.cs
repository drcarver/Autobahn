//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarDayModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarDay Model
     /// </summary>
    public partial class OrganizationCalendarDayModel : AutobahnBase, Interfaces.IOrganizationCalendarDay
    {
        /// <summary>
        /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
        /// </summary>
        public System.String AlternateDayName { get; set; }

        /// <summary>
        /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
        /// </summary>
        public System.String DayName { get; set; }

        /// <summary>
        /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
        /// </summary>
        public Guid OrganizationCalendarId { get; set; }

    }
}
