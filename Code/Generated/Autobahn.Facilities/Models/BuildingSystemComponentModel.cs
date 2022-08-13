//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemComponentModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The BuildingSystemComponent Model
     /// </summary>
    public partial class BuildingSystemComponentModel : AutobahnBase, Interfaces.IBuildingSystemComponent
    {
        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        public System.String BuildingInstitutionalEquipmentDescription { get; set; }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        public System.Int32? ComponentOrFixtureUsefulLife { get; set; }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        public System.String InstallationDate { get; set; }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        public System.Decimal? LifecycleCost { get; set; }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        public Guid? RefFacilityFurnishingsTypeId { get; set; }

        /// <summary>
        /// The rating of the system or component functions under the demands of its regular operation.
        /// </summary>
        public Guid? RefFacilitySystemOrComponentConditionId { get; set; }

    }
}
