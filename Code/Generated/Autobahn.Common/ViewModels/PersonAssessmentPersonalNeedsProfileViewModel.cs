//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAssessmentPersonalNeedsProfileViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonAssessmentPersonalNeedsProfile View Model
     /// </summary>
    public partial class PersonAssessmentPersonalNeedsProfileViewModel : ViewModelBase, Interfaces.IPersonAssessmentPersonalNeedsProfile
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonAssessmentPersonalNeedsProfile";

        // member variable for the AssessmentPersonalNeedsProfileId property
        private Guid _AssessmentPersonalNeedsProfileId;

        // member variable for the PersonId property
        private Guid _PersonId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get => _AssessmentPersonalNeedsProfileId; set => SetProperty(ref _AssessmentPersonalNeedsProfileId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonAssessmentPersonalNeedsProfile model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentPersonalNeedsProfileId = model.AssessmentPersonalNeedsProfileId; // 
            PersonId = model.PersonId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
