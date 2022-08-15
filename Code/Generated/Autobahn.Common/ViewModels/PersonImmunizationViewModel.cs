//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonImmunizationViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonImmunizationViewModel
     /// </summary>
    public partial class PersonImmunizationViewModel : ViewModelBase, Interfaces.IPersonImmunization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonImmunization";

        // member variable for the ImmunizationDate property
        private System.DateTime _ImmunizationDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonImmunizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day of an immunization.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19306">Immunization Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Immunization Date")]
        public System.DateTime ImmunizationDate { get => _ImmunizationDate; set => SetProperty(ref _ImmunizationDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonImmunization model)
        {
            IsBusy = true;
            Id = model.Id;
            ImmunizationDate = model.ImmunizationDate; // Immunization Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
