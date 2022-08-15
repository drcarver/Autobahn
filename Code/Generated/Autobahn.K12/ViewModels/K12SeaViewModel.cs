//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SeaViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SeaViewModel
     /// </summary>
    public partial class K12SeaViewModel : ViewModelBase, Interfaces.IK12Sea
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12Sea";

        // member variable for the RefStateANSICodeId property
        private Guid? _RefStateANSICodeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12SeaViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStateANSICode"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19414">State ANSI Code</a>
        /// </para>
        /// </summary>
        [DisplayName("State ANSI Code")]
        public Guid? RefStateANSICodeId { get => _RefStateANSICodeId; set => SetProperty(ref _RefStateANSICodeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12Sea model)
        {
            IsBusy = true;
            Id = model.Id;
            RefStateANSICodeId = model.RefStateANSICodeId; // State ANSI Code
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
