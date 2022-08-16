//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationPopulationServed.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPopulationServed Interface
     /// </summary>
    public partial interface IOrganizationPopulationServed : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         OldestAgeServed { get; set; }

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
         RefPopulationServedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? YoungestAgeServed { get; set; }

    }
}
