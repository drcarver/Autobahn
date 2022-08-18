//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentActivityViewModel.cs
//* Name:       Activity Time Involved
//* Definition: The amount of time the student participated in the events and procedures of an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The amount of time the student participated in the events and procedures of an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
     /// </summary>
    public partial class K12StudentActivityViewModel : ViewModelBase, Interfaces.IK12StudentActivity
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentActivity";

        // ActivityTimeInvolved -- (backing property for Activity Time Involved)
        private System.Decimal? _ActivityTimeInvolved;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefActivityTimeMeasurementTypeId -- (backing property for Activity Time Measurement Type)
        private Guid? _RefActivityTimeMeasurementTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Activity Time Involved
        /// <para>
        /// The amount of time the student participated in the events and procedures of an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20502">Activity Time Involved</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? ActivityTimeInvolved { get => _ActivityTimeInvolved; set => SetProperty(ref _ActivityTimeInvolved, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Activity Time Measurement Type
        /// <para>
        /// The type of measurement for the amount of time the student participated in the events and procedures of an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20503">Activity Time Measurement Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefActivityTimeMeasurementTypeId { get => _RefActivityTimeMeasurementTypeId; set => SetProperty(ref _RefActivityTimeMeasurementTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivityTimeInvolved = model.ActivityTimeInvolved; // Activity Time Involved
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefActivityTimeMeasurementTypeId = model.RefActivityTimeMeasurementTypeId; // Activity Time Measurement Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
