//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentSessionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentSessionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A measure of average performance in all courses taken by a person during a given session. This is obtained by dividing the total grade points received by the number of credits attempted for the same session.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19129">Grade Point Average Given Session</a>
        /// </para>
        /// </summary>
        [DisplayName("Grade Point Average Given Session")]
        public System.Decimal? GradePointAverageGivenSession { get => _GradePointAverageGivenSession; set => SetProperty(ref _GradePointAverageGivenSession, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentSession model)
        {
            IsBusy = true;
            Id = model.Id;
            GradePointAverageGivenSession = model.GradePointAverageGivenSession; // Grade Point Average Given Session
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
