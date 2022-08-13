//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAllergyViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

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

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the ReactionDescription property
        private System.String _ReactionDescription;

        // member variable for the RefAllergySeverityId property
        private Guid? _RefAllergySeverityId;

        // member variable for the RefAllergyTypeId property
        private Guid _RefAllergyTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonAllergyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Describes symptoms know to be associated with a person's reaction to an allergen.
        /// </summary>
        public System.String ReactionDescription { get => _ReactionDescription; set => SetProperty(ref _ReactionDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAllergySeverity"/> model
        /// </summary>
        public Guid? RefAllergySeverityId { get => _RefAllergySeverityId; set => SetProperty(ref _RefAllergySeverityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAllergyType"/> model
        /// </summary>
        public Guid RefAllergyTypeId { get => _RefAllergyTypeId; set => SetProperty(ref _RefAllergyTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAllergy model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            ReactionDescription = model.ReactionDescription;
            RefAllergySeverityId = model.RefAllergySeverityId;
            RefAllergyTypeId = model.RefAllergyTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
