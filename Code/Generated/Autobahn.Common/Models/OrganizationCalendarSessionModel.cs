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
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        public System.DateTime? BeginDate { get; set; }

    }
}
