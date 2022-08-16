//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefAssociationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyDefAssociation Model
     /// </summary>
    public partial class CompetencyDefAssociationModel : AutobahnBase, Interfaces.ICompetencyDefAssociation
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? AssociatedEntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CompetencyDefAssociationIdentifierURI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ConnectionCitation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DestinationNodeName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DestinationNodeURI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  OriginNodeName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  OriginNodeURI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCompetencyDefAssociationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLearningResourceCompetencyAlignmentTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Weight { get; set; }

    }
}
