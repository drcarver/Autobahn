//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthBirthViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonHealthBirthViewModel
     /// </summary>
    public partial class PersonHealthBirthViewModel : ViewModelBase, Interfaces.IPersonHealthBirth
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonHealthBirth";

        // member variable for the WeightAtBirth property
        private System.String _WeightAtBirth;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonHealthBirthViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The weight of a child at birth in pounds and ounces.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19312">Weight at Birth</a>
        /// </para>
        /// </summary>
        [DisplayName("Weight at Birth")]
        public System.String WeightAtBirth { get => _WeightAtBirth; set => SetProperty(ref _WeightAtBirth, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonHealthBirth model)
        {
            IsBusy = true;
            Id = model.Id;
            WeightAtBirth = model.WeightAtBirth; // Weight at Birth
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
