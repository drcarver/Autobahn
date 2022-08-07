//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarCrisiModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationCalendarCrisi Model
     /// </summary>
    public partial class OrganizationCalendarCrisiModel : AutobahnBase, Interfaces.IOrganizationCalendarCrisiModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarCrisis"/> model
        /// </summary>
        public Guid OrganizationCalendarCrisisId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarCrisi.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarCrisi.Name non nullable property
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarCrisi.StartDate nullable property
        /// </summary>
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarCrisi.EndDate nullable property
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarCrisi.Type non nullable property
        /// </summary>
        public System.String Type { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarCrisi.CrisisDescription non nullable property
        /// </summary>
        public System.String CrisisDescription { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarCrisi.CrisisEndDate nullable property
        /// </summary>
        public System.DateTime? CrisisEndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
