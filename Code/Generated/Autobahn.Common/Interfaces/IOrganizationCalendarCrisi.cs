//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationCalendarCrisi.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendarCrisi Interface
     /// </summary>
    public partial interface IOrganizationCalendarCrisi : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        System.String CrisisDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.DateTime? CrisisEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.DateTime? EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid OrganizationCalendarCrisisId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.DateTime? StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String Type { get; set; }

    }
}
