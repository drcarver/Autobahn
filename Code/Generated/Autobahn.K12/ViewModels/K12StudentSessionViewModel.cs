//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentSessionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentSessionViewModel
     /// </summary>
    public partial class K12StudentSessionViewModel : ViewModelBase, Interfaces.IK12StudentSession
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentSession";

        // member variable for the GradePointAverageGivenSession property
        private System.Decimal? _GradePointAverageGivenSession;

        // member variable for the OrganizationCalendarSessionId property
        private Guid? _OrganizationCalendarSessionId;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentSessionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A measure of average performance in all courses taken by a person during a given session. This is obtained by dividing the total grade points received by the number of credits attempted for the same session.
        /// </summary>
        public System.Decimal? GradePointAverageGivenSession { get => _GradePointAverageGivenSession; set => SetProperty(ref _GradePointAverageGivenSession, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarSession"/> model
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentSession model)
        {
            IsBusy = true;
            Id = model.Id;
            GradePointAverageGivenSession = model.GradePointAverageGivenSession;
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
