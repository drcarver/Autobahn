//**********************************************************
//* DomainName: Facilities
//* FileName:   BuildingSpaceUtilizationViewModel.cs
//* Name:       Available Utilized Instructional Space
//* Definition: An indication that the instruction space in a school is used in the calculation of student capacity.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// An indication that the instruction space in a school is used in the calculation of student capacity.
     /// </summary>
    public partial class BuildingSpaceUtilizationViewModel : ViewModelBase, Interfaces.IBuildingSpaceUtilization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from BuildingSpaceUtilization";

        // AvailableUtilizedInstructionalSpace -- (backing property for Available Utilized Instructional Space)
        private System.Boolean? _AvailableUtilizedInstructionalSpace;

        // BuildingCapacityFactorIndicator -- (backing property for Building Capacity Factor Indicator)
        private System.Boolean? _BuildingCapacityFactorIndicator;

        // member variable for the BuildingSpaceId property
        private Guid _BuildingSpaceId;

        // BuildingSpaceUtilizationArea -- (backing property for Building Space Utilization Area)
        private System.Decimal? _BuildingSpaceUtilizationArea;

        // BuildingUnassignedSpaceIndicator -- (backing property for Building Unassigned Space Indicator)
        private System.Boolean? _BuildingUnassignedSpaceIndicator;

        // RefBuildingCommunityUseSpaceTypeId -- (backing property for Building Community Use Space Type)
        private Guid? _RefBuildingCommunityUseSpaceTypeId;

        // RefBuildingInstructionalSpaceFactorTypeId -- (backing property for Building Instructional Space Factor Type)
        private Guid? _RefBuildingInstructionalSpaceFactorTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Available Utilized Instructional Space
        /// <para>
        /// An indication that the instruction space in a school is used in the calculation of student capacity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20883">Available Utilized Instructional Space</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? AvailableUtilizedInstructionalSpace { get => _AvailableUtilizedInstructionalSpace; set => SetProperty(ref _AvailableUtilizedInstructionalSpace, value); }

        /// <summary>
        /// Building Capacity Factor Indicator
        /// <para>
        /// A designation as to whether the space is included in the calculation of school building capacity under state or local guidelines.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20884">Building Capacity Factor Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? BuildingCapacityFactorIndicator { get => _BuildingCapacityFactorIndicator; set => SetProperty(ref _BuildingCapacityFactorIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IBuildingSpace"/> model
        /// </summary>
        public Guid BuildingSpaceId { get => _BuildingSpaceId; set => SetProperty(ref _BuildingSpaceId, value); }

        /// <summary>
        /// Building Space Utilization Area
        /// <para>
        /// The area in square feet measured between the principal wall that faces at or near floor level, including alcove spaces, and the outer limits of space designed to serve the activity. Structural space is excluded.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20842">Building Space Utilization Area</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? BuildingSpaceUtilizationArea { get => _BuildingSpaceUtilizationArea; set => SetProperty(ref _BuildingSpaceUtilizationArea, value); }

        /// <summary>
        /// Building Unassigned Space Indicator
        /// <para>
        /// An indication that the space in a school, including circulation, administration offices, support spaces, and common areas, is not part of the calculation for capacity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20844">Building Unassigned Space Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? BuildingUnassignedSpaceIndicator { get => _BuildingUnassignedSpaceIndicator; set => SetProperty(ref _BuildingUnassignedSpaceIndicator, value); }

        /// <summary>
        /// Building Community Use Space Type
        /// <para>
        /// The space designed primarily for community or shared use.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20836">Building Community Use Space Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingCommunityUseSpaceTypeId { get => _RefBuildingCommunityUseSpaceTypeId; set => SetProperty(ref _RefBuildingCommunityUseSpaceTypeId, value); }

        /// <summary>
        /// Building Instructional Space Factor Type
        /// <para>
        /// A designation as to whether the space is considered an instructional space under state or local guidelines.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20832">Building Instructional Space Factor Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingInstructionalSpaceFactorTypeId { get => _RefBuildingInstructionalSpaceFactorTypeId; set => SetProperty(ref _RefBuildingInstructionalSpaceFactorTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IBuildingSpaceUtilization model)
        {
            IsBusy = true;
            Id = model.Id;
            AvailableUtilizedInstructionalSpace = model.AvailableUtilizedInstructionalSpace; // Available Utilized Instructional Space
            BuildingCapacityFactorIndicator = model.BuildingCapacityFactorIndicator; // Building Capacity Factor Indicator
            BuildingSpaceId = model.BuildingSpaceId; // 
            BuildingSpaceUtilizationArea = model.BuildingSpaceUtilizationArea; // Building Space Utilization Area
            BuildingUnassignedSpaceIndicator = model.BuildingUnassignedSpaceIndicator; // Building Unassigned Space Indicator
            RefBuildingCommunityUseSpaceTypeId = model.RefBuildingCommunityUseSpaceTypeId; // Building Community Use Space Type
            RefBuildingInstructionalSpaceFactorTypeId = model.RefBuildingInstructionalSpaceFactorTypeId; // Building Instructional Space Factor Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
