//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonRelationship.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonRelationship Interface
     /// </summary>
    public partial interface IPersonRelationship : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         ContactPriorityNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ContactRestrictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? CustodialRelationshipIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         EmergencyContactInd { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LivesWithIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PrimaryContactIndicator { get; set; }

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
         RefPersonRelationshipTypeId { get; set; }

    }
}
