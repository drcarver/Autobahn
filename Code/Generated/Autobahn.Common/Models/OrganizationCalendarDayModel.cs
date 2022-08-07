//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarDayModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarDay Model
     /// </summary>
    public partial class OrganizationCalendarDayModel : AutobahnBase, Interfaces.IOrganizationCalendarDayModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendar"/> model
        /// </summary>
        public Guid OrganizationCalendarId { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarDay.DayName non nullable property
        /// </summary>
        public System.String DayName { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarDay.AlternateDayName non nullable property
        /// </summary>
        public System.String AlternateDayName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
