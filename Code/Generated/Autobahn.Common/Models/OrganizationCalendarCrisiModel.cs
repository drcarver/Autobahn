//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarCrisiModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarCrisi Model
     /// </summary>
    public partial class OrganizationCalendarCrisiModel : AutobahnBase, Interfaces.IOrganizationCalendarCrisi
    {
        /// <summary>
        /// 
        /// </summary>
        public System.String CrisisDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? CrisisEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid OrganizationCalendarCrisisId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.String Type { get; set; }

    }
}
