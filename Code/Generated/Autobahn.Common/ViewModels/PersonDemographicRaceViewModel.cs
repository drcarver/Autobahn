//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDemographicRaceViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDemographicRaceViewModel
     /// </summary>
    public partial class PersonDemographicRaceViewModel : ViewModelBase, Interfaces.IPersonDemographicRace
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDemographicRace";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonDemographicRaceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDemographicRace model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
