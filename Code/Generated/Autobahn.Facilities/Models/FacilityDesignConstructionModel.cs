//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignConstructionModel.cs
//* Name:       Building Addition Code
//* Definition: A unique number or alphanumeric code assigned to a building addition by a school, school system, state, or other agency or entity.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// A unique number or alphanumeric code assigned to a building addition by a school, school system, state, or other agency or entity.
     /// </summary>
    public partial class FacilityDesignConstructionModel : AutobahnBase, Interfaces.IFacilityDesignConstruction
    {
        /// <summary>
        /// Building Addition Code
        /// <para>
        /// A unique number or alphanumeric code assigned to a building addition by a school, school system, state, or other agency or entity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20757">Building Addition Code</a>
        /// </para>
        /// </summary>
        public System.String BuildingAdditionCode { get; set; }

        /// <summary>
        /// Building Addition Description
        /// <para>
        /// A description of the permanent structure added to the original building.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20756">Building Addition Description</a>
        /// </para>
        /// </summary>
        public System.String BuildingAdditionDescription { get; set; }

        /// <summary>
        /// Building Site Improvement Description
        /// <para>
        /// A description of the designed and constructed improvements made to a site.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20831">Building Site Improvement Description</a>
        /// </para>
        /// </summary>
        public System.String BuildingSiteImprovementDescription { get; set; }

        /// <summary>
        /// Facility Addition Year
        /// <para>
        /// The year the construction on the addition was completed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20750">Facility Addition Year</a>
        /// </para>
        /// </summary>
        public System.String FacilityAdditionYear { get; set; }

        /// <summary>
        /// Facility Construction Date
        /// <para>
        /// The month, day, and year on which construction of a building, addition, or improvement was completed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20761">Facility Construction Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? FacilityConstructionDate { get; set; }

        /// <summary>
        /// Facility Construction Year
        /// <para>
        /// The year the building was first constructed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20752">Facility Construction Year</a>
        /// </para>
        /// </summary>
        public System.String FacilityConstructionYear { get; set; }

        /// <summary>
        /// Building Architect Name
        /// <para>
        /// The name of the architect of record for the building.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20815">Building Architect Name</a>
        /// </para>
        /// </summary>
        public Guid FacilityDesignId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefBuildingEnergyConservationMeasureType"/> model
        /// </summary>
        public Guid? RefBuildingEnergyConservationMeasureTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityConstructionDateType"/> model
        /// </summary>
        public Guid? RefFacilityConstructionDateTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityConstructionMaterialType"/> model
        /// </summary>
        public Guid? RefFacilityConstructionMaterialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityJointDevelopmentType"/> model
        /// </summary>
        public Guid? RefFacilityJointDevelopmentTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilitySiteImprovementLocationType"/> model
        /// </summary>
        public Guid? RefFacilitySiteImprovementLocationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFacilityStandardType"/> model
        /// </summary>
        public Guid? RefFacilityStandardTypeId { get; set; }

    }
}
