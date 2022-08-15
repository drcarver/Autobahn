//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationCalendarSession.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendarSession Interface
     /// </summary>
    public partial interface IOrganizationCalendarSession : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// </summary>
        System.DateTime? BeginDate { get; set; }

    }
}
