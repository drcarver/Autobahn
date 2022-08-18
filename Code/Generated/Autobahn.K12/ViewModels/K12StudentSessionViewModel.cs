//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentSessionViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentSession View Model
     /// </summary>
    public partial class K12StudentSessionViewModel : ViewModelBase, Interfaces.IK12StudentSession
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentSession";

        // GradePointAverageGivenSession -- (backing property for Grade Point Average Given Session)
        private System.Decimal? _GradePointAverageGivenSession;

        // member variable for the OrganizationCalendarSessionId property
        private Guid? _OrganizationCalendarSessionId;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Grade Point Average Given Session
        /// <para>
        /// A measure of average performance in all courses taken by a person during a given session. This is obtained by dividing the total grade points received by the number of credits attempted for the same session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19129">Grade Point Average Given Session</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? GradePointAverageGivenSession { get => _GradePointAverageGivenSession; set => SetProperty(ref _GradePointAverageGivenSession, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
        /// </summary>
        public Guid? OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
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
            GradePointAverageGivenSession = model.GradePointAverageGivenSession; // Grade Point Average Given Session
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId; // 
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
