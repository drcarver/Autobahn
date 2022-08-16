//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationCalendarDay.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationCalendarDay Interface
     /// </summary>
    public partial interface IOrganizationCalendarDay : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? AlternateDayName { get; set; }

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
