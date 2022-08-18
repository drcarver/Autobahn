//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAllergyViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonAllergy View Model
     /// </summary>
    public partial class PersonAllergyViewModel : ViewModelBase, Interfaces.IPersonAllergy
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonAllergy";

        // member variable for the PersonId property
        private Guid _PersonId;

        // ReactionDescription -- (backing property for Allergy Reaction Description)
        private System.String _ReactionDescription;

        // RefAllergySeverityId -- (backing property for Allergy Severity)
        private Guid? _RefAllergySeverityId;

        // RefAllergyTypeId -- (backing property for Allergy Type)
        private Guid _RefAllergyTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Allergy Reaction Description
        /// <para>
        /// Describes symptoms know to be associated with a person's reaction to an allergen.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20247">Allergy Reaction Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ReactionDescription { get => _ReactionDescription; set => SetProperty(ref _ReactionDescription, value); }

        /// <summary>
        /// Allergy Severity
        /// <para>
        /// The level of severity of a person's reaction to an allergen.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20248">Allergy Severity</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAllergySeverityId { get => _RefAllergySeverityId; set => SetProperty(ref _RefAllergySeverityId, value); }

        /// <summary>
        /// Allergy Type
        /// <para>
        /// Type of allergy condition attributed to a person as defined by the SNOWMED Clinical Terms(r) vocabulary.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20249">Allergy Type</a>
        /// </para>
        /// </summary>
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
            PersonId = model.PersonId; // 
            ReactionDescription = model.ReactionDescription; // Allergy Reaction Description
            RefAllergySeverityId = model.RefAllergySeverityId; // Allergy Severity
            RefAllergyTypeId = model.RefAllergyTypeId; // Allergy Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
