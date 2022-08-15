//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDetailViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDetailViewModel
     /// </summary>
    public partial class PersonDetailViewModel : ViewModelBase, Interfaces.IPersonDetail
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDetail";

        // member variable for the Birthdate property
        private System.DateTime? _Birthdate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonDetailViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19033">Birthdate</a>
        /// </para>
        /// </summary>
        [DisplayName("Birthdate")]
        public System.DateTime? Birthdate { get => _Birthdate; set => SetProperty(ref _Birthdate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDetail model)
        {
            IsBusy = true;
            Id = model.Id;
            Birthdate = model.Birthdate; // Birthdate
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
