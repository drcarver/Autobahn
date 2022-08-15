//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLanguageViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonLanguageViewModel
     /// </summary>
    public partial class PersonLanguageViewModel : ViewModelBase, Interfaces.IPersonLanguage
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonLanguage";

        // member variable for the RefLanguageUseTypeId property
        private Guid _RefLanguageUseTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonLanguageViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLanguageUseType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19316">Language Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Language Type")]
        public Guid RefLanguageUseTypeId { get => _RefLanguageUseTypeId; set => SetProperty(ref _RefLanguageUseTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonLanguage model)
        {
            IsBusy = true;
            Id = model.Id;
            RefLanguageUseTypeId = model.RefLanguageUseTypeId; // Language Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
