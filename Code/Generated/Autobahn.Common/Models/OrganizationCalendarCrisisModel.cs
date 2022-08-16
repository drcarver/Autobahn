//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarCrisisModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarCrisis Model
     /// </summary>
    public partial class OrganizationCalendarCrisisModel : AutobahnBase, Interfaces.IOrganizationCalendarCrisis
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CrisisDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CrisisEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EndDate { get; set; }

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
        public  StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Type { get; set; }

    }
}
