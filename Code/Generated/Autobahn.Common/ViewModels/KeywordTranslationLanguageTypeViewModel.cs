//**********************************************************
//* DomainName: Common Models
//* FileName:   KeywordTranslationLanguageTypeViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The KeywordTranslationLanguageType View Model
     /// </summary>
    public partial class KeywordTranslationLanguageTypeViewModel : ViewModelBase, Interfaces.IKeywordTranslationLanguageType
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from KeywordTranslationLanguageType";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IKeywordTranslationLanguageType model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
