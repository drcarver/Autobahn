//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonFamilyViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonFamilyViewModel
     /// </summary>
    public partial class PersonFamilyViewModel : ViewModelBase, Interfaces.IPersonFamily
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonFamily";

        // member variable for the RefHighestEducationLevelCompletedId property
        private Guid? _RefHighestEducationLevelCompletedId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonFamilyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighestEducationLevelCompleted"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19141">Highest Level of Education Completed</a>
        /// </para>
        /// </summary>
        [DisplayName("Highest Level of Education Completed")]
        public Guid? RefHighestEducationLevelCompletedId { get => _RefHighestEducationLevelCompletedId; set => SetProperty(ref _RefHighestEducationLevelCompletedId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonFamily model)
        {
            IsBusy = true;
            Id = model.Id;
            RefHighestEducationLevelCompletedId = model.RefHighestEducationLevelCompletedId; // Highest Level of Education Completed
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
