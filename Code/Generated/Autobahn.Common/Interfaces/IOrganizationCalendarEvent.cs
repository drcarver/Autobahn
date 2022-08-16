//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationCalendarEvent.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendarEvent Interface
     /// </summary>
    public partial interface IOrganizationCalendarEvent : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EventDate { get; set; }

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
        Guid? RefCalendarEventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StartTime { get; set; }

    }
}
