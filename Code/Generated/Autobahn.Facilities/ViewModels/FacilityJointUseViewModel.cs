//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityJointUseViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilityJointUse View Model
     /// </summary>
    public partial class FacilityJointUseViewModel : ViewModelBase, Interfaces.IFacilityJointUse
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FacilityJointUse";

        // member variable for the FacilityId property
        private Guid _FacilityId;

        // RefBuildingJointUseRationaleTypeId -- (backing property for Building Joint Use Rationale Type)
        private Guid? _RefBuildingJointUseRationaleTypeId;

        // RefBuildingJointUserTypeId -- (backing property for Building Joint User Type)
        private Guid? _RefBuildingJointUserTypeId;

        // RefBuildingJointUseSchedulingTypeId -- (backing property for Building Joint Use Scheduling Type)
        private Guid? _RefBuildingJointUseSchedulingTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get => _FacilityId; set => SetProperty(ref _FacilityId, value); }

        /// <summary>
        /// Building Joint Use Rationale Type
        /// <para>
        /// The reasons for permitting and participating in joint-use.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20833">Building Joint Use Rationale Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingJointUseRationaleTypeId { get => _RefBuildingJointUseRationaleTypeId; set => SetProperty(ref _RefBuildingJointUseRationaleTypeId, value); }

        /// <summary>
        /// Building Joint User Type
        /// <para>
        /// The types of users sharing school district controlled, owned, or utilized facilities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20835">Building Joint User Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingJointUserTypeId { get => _RefBuildingJointUserTypeId; set => SetProperty(ref _RefBuildingJointUserTypeId, value); }

        /// <summary>
        /// Building Joint Use Scheduling Type
        /// <para>
        /// The type of designation of non school district users by the amount of time they have access to public school for joint use.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20834">Building Joint Use Scheduling Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefBuildingJointUseSchedulingTypeId { get => _RefBuildingJointUseSchedulingTypeId; set => SetProperty(ref _RefBuildingJointUseSchedulingTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFacilityJointUse model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityId = model.FacilityId; // 
            RefBuildingJointUseRationaleTypeId = model.RefBuildingJointUseRationaleTypeId; // Building Joint Use Rationale Type
            RefBuildingJointUserTypeId = model.RefBuildingJointUserTypeId; // Building Joint User Type
            RefBuildingJointUseSchedulingTypeId = model.RefBuildingJointUseSchedulingTypeId; // Building Joint Use Scheduling Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
