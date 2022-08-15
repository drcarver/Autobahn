//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolStatusViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolStatusViewModel
     /// </summary>
    public partial class K12SchoolStatusViewModel : ViewModelBase, Interfaces.IK12SchoolStatus
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SchoolStatus";

        // member variable for the RefAlternativeSchoolFocusId property
        private Guid? _RefAlternativeSchoolFocusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12SchoolStatusViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAlternativeSchoolFocus"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19015">Alternative School Focus Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Alternative School Focus Type")]
        public Guid? RefAlternativeSchoolFocusId { get => _RefAlternativeSchoolFocusId; set => SetProperty(ref _RefAlternativeSchoolFocusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SchoolStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAlternativeSchoolFocusId = model.RefAlternativeSchoolFocusId; // Alternative School Focus Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
