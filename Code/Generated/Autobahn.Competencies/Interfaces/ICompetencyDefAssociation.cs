//***************************************************************************
//* DomainName: Competencies Interfaces (used by both models and View Models
//* FileName:   ICompetencyDefAssociation.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The ICompetencyDefAssociation Interface
     /// </summary>
    public partial interface ICompetencyDefAssociation : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? AssociatedEntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CompetencyDefAssociationIdentifierURI { get; set; }

        /// <summary>
        /// 
        /// </summary>
         ConnectionCitation { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DestinationNodeName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         DestinationNodeURI { get; set; }

        /// <summary>
        /// 
        /// </summary>
         OriginNodeName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         OriginNodeURI { get; set; }

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
         RefCompetencyDefAssociationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefLearningResourceCompetencyAlignmentTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Weight { get; set; }

    }
}
