//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationCalendarCrisiModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendarCrisiModel Interface
     /// </summary>
    public partial interface IOrganizationCalendarCrisiModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarCrisis"/> model
        /// </summary>
        Guid OrganizationCalendarCrisisId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarCrisi.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarCrisi.Name non nullable property
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarCrisi.StartDate nullable property
        /// </summary>
        System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarCrisi.EndDate nullable property
        /// </summary>
        System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarCrisi.Type non nullable property
        /// </summary>
        System.String Type { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarCrisi.CrisisDescription non nullable property
        /// </summary>
        System.String CrisisDescription { get; set; }

        /// <summary>
        /// Defines the OrganizationCalendarCrisi.CrisisEndDate nullable property
        /// </summary>
        System.DateTime? CrisisEndDate { get; set; }

    }
}
