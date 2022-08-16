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
        /// 
        /// </summary>
        public Guid? AlternateDayName { get; set; }

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
