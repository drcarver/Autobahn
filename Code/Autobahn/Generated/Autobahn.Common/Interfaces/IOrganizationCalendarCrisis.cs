//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationCalendarCrisis.cs
//* Name:       Crisis Code
//* Definition: A unique number or alphanumeric code used to identify a crisis. This code should be able to accommodate numerous crises within a single school year. It is associated with the displaced student identifier in order to link a crisis to a student who was displaced or otherwise affected by the event. If the same code values are to be used over multiple years, it is important to have enough crisis-specific items (e.g., school year, date/time) to keep the events unique over time.
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// A unique number or alphanumeric code used to identify a crisis. This code should be able to accommodate numerous crises within a single school year. It is associated with the displaced student identifier in order to link a crisis to a student who was displaced or otherwise affected by the event. If the same code values are to be used over multiple years, it is important to have enough crisis-specific items (e.g., school year, date/time) to keep the events unique over time.
     /// </summary>
    public partial interface IOrganizationCalendarCrisis : IAutobahnBase
    {
    }
}
