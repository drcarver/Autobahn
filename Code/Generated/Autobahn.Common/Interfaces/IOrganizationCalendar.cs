//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationCalendar.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendar Interface
     /// </summary>
    public partial interface IOrganizationCalendar : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         CalendarCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CalendarDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? CalendarYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
