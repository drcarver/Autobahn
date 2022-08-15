//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAllergyViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonAllergyViewModel
     /// </summary>
    public partial class PersonAllergyViewModel : ViewModelBase, Interfaces.IPersonAllergy
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonAllergy";

        // member variable for the ReactionDescription property
        private System.String _ReactionDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonAllergyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Describes symptoms know to be associated with a person's reaction to an allergen.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20247">Allergy Reaction Description</a>
        /// </para>
        /// </summary>
        [DisplayName("Allergy Reaction Description")]
        public System.String ReactionDescription { get => _ReactionDescription; set => SetProperty(ref _ReactionDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAllergy model)
        {
            IsBusy = true;
            Id = model.Id;
            ReactionDescription = model.ReactionDescription; // Allergy Reaction Description
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
