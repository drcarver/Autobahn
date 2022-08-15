//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   PDActivityEducationLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The PDActivityEducationLevelViewModel
     /// </summary>
    public partial class PDActivityEducationLevelViewModel : ViewModelBase, Interfaces.IPDActivityEducationLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PDActivityEducationLevel";

        // member variable for the RefPDActivityEducationLevelsAddressedId property
        private Guid _RefPDActivityEducationLevelsAddressedId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PDActivityEducationLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPDActivityEducationLevelsAddressed"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20245">Professional Development Activity Education Levels Addressed</a>
        /// </para>
        /// </summary>
        [DisplayName("Professional Development Activity Education Levels Addressed")]
        public Guid RefPDActivityEducationLevelsAddressedId { get => _RefPDActivityEducationLevelsAddressedId; set => SetProperty(ref _RefPDActivityEducationLevelsAddressedId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPDActivityEducationLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            RefPDActivityEducationLevelsAddressedId = model.RefPDActivityEducationLevelsAddressedId; // Professional Development Activity Education Levels Addressed
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
