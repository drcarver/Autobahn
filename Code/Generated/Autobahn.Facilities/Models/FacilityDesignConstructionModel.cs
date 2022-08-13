//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignConstructionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The FacilityDesignConstruction Model
     /// </summary>
    public partial class FacilityDesignConstructionModel : AutobahnBase, Interfaces.IFacilityDesignConstruction
    {
        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        public System.String BuildingAdditionCode { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        public System.String BuildingAdditionDescription { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        public System.String BuildingSiteImprovementDescription { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        public System.String FacilityAdditionYear { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        public System.DateTime? FacilityConstructionDate { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        public System.String FacilityConstructionYear { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        public Guid FacilityDesignId { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        public Guid? RefBuildingEnergyConservationMeasureTypeId { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        public Guid? RefFacilityConstructionDateTypeId { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        public Guid? RefFacilityConstructionMaterialTypeId { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        public Guid? RefFacilityJointDevelopmentTypeId { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        public Guid? RefFacilitySiteImprovementLocationTypeId { get; set; }

        /// <summary>
        /// The year the construction on the addition was completed.
        /// </summary>
        public Guid? RefFacilityStandardTypeId { get; set; }

    }
}
