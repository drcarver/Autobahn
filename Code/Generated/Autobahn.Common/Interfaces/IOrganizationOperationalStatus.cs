//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationOperationalStatus.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationOperationalStatus Interface
     /// </summary>
    public partial interface IOrganizationOperationalStatus : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         OperationalStatusEffectiveDate { get; set; }

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
        Guid? RefOperationalStatusId { get; set; }

    }
}
