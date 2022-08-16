//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationCalendarCrisis.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendarCrisis Interface
     /// </summary>
    public partial interface IOrganizationCalendarCrisis : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CrisisDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CrisisEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Type { get; set; }

    }
}
