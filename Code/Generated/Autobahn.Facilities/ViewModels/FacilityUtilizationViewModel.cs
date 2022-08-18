//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityUtilizationViewModel.cs
//* Name:       Building Hours of Public Use Per Week
//* Definition: The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
     /// </summary>
    public partial class FacilityUtilizationViewModel : ViewModelBase, Interfaces.IFacilityUtilization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityUtilization";

        // BuildingHoursOfPublicUsePerWeek -- (backing property for Building Hours of Public Use Per Week)
        private System.Int32? _BuildingHoursOfPublicUsePerWeek;

        // BuildingNetAreaOfInstructionalSpace -- (backing property for Building Net Area of Instructional Space)
        private System.Decimal? _BuildingNetAreaOfInstructionalSpace;

        // BuildingNumberOfTeachingStations -- (backing property for Building Number of Teaching Stations)
        private System.Int32? _BuildingNumberOfTeachingStations;

        // BuildingPublicUsePolicyDescription -- (backing property for Building Public Use Policy Description)
        private System.String _BuildingPublicUsePolicyDescription;

        // FacilityEnrollmentCapacity -- (backing property for Facility Enrollment Capacity)
        private System.Int32? _FacilityEnrollmentCapacity;

        // member variable for the FacilityId property
        private Guid _FacilityId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Building Hours of Public Use Per Week
        /// <para>
        /// The number of hours that all or part of a building is used for purposes other than general education by the community or other organizations.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20837">Building Hours of Public Use Per Week</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? BuildingHoursOfPublicUsePerWeek { get => _BuildingHoursOfPublicUsePerWeek; set => SetProperty(ref _BuildingHoursOfPublicUsePerWeek, value); }

        /// <summary>
        /// Building Net Area of Instructional Space
        /// <para>
        /// The area of space directly used for instruction excluding circulation, administration, student services, and building support.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20838">Building Net Area of Instructional Space</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? BuildingNetAreaOfInstructionalSpace { get => _BuildingNetAreaOfInstructionalSpace; set => SetProperty(ref _BuildingNetAreaOfInstructionalSpace, value); }

        /// <summary>
        /// Building Number of Teaching Stations
        /// <para>
        /// The number of teaching stations, as defined by how many spaces have, or could have, a teacher assigned to them for classroom instruction.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20839">Building Number of Teaching Stations</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? BuildingNumberOfTeachingStations { get => _BuildingNumberOfTeachingStations; set => SetProperty(ref _BuildingNumberOfTeachingStations, value); }

        /// <summary>
        /// Building Public Use Policy Description
        /// <para>
        /// A description of the policy that enables the community or other organizations to use all or part of a building for purposes other than general education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20840">Building Public Use Policy Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BuildingPublicUsePolicyDescription { get => _BuildingPublicUsePolicyDescription; set => SetProperty(ref _BuildingPublicUsePolicyDescription, value); }

        /// <summary>
        /// Facility Enrollment Capacity
        /// <para>
        /// The maximum number of age appropriate students who can be enrolled in a facility such that the district's programmatic, operational, and student/teacher work load requirements are met.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20885">Facility Enrollment Capacity</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? FacilityEnrollmentCapacity { get => _FacilityEnrollmentCapacity; set => SetProperty(ref _FacilityEnrollmentCapacity, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityUtilization model)
        {
            IsBusy = true;
            Id = model.Id;
            BuildingHoursOfPublicUsePerWeek = model.BuildingHoursOfPublicUsePerWeek; // Building Hours of Public Use Per Week
            BuildingNetAreaOfInstructionalSpace = model.BuildingNetAreaOfInstructionalSpace; // Building Net Area of Instructional Space
            BuildingNumberOfTeachingStations = model.BuildingNumberOfTeachingStations; // Building Number of Teaching Stations
            BuildingPublicUsePolicyDescription = model.BuildingPublicUsePolicyDescription; // Building Public Use Policy Description
            FacilityEnrollmentCapacity = model.FacilityEnrollmentCapacity; // Facility Enrollment Capacity
            FacilityId = model.FacilityId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
