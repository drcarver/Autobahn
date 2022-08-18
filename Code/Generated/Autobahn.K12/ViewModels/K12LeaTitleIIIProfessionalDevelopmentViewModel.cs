//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LEATitleIIIProfessionalDevelopmentViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LEATitleIIIProfessionalDevelopment View Model
     /// </summary>
    public partial class K12LEATitleIIIProfessionalDevelopmentViewModel : ViewModelBase, Interfaces.IK12LEATitleIIIProfessionalDevelopment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LEATitleIIIProfessionalDevelopment";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LEATitleIIIProfessionalDevelopment model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
