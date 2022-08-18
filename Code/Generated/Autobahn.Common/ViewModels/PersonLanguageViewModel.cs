//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLanguageViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonLanguage View Model
     /// </summary>
    public partial class PersonLanguageViewModel : ViewModelBase, Interfaces.IPersonLanguage
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonLanguage";

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefLanguageId -- (backing property for ISO 639-2 Language Code)
        private Guid _RefLanguageId;

        // RefLanguageUseTypeId -- (backing property for Language Type)
        private Guid _RefLanguageUseTypeId;

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
        /// ISO 639-2 Language Code
        /// <para>
        /// The code for the specific language or dialect that a person uses to communicate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19317">ISO 639-2 Language Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        /// <summary>
        /// Language Type
        /// <para>
        /// An indication of the function and context in which a person uses a language to communicate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19316">Language Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefLanguageUseTypeId { get => _RefLanguageUseTypeId; set => SetProperty(ref _RefLanguageUseTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonLanguage model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId; // 
            RefLanguageId = model.RefLanguageId; // ISO 639-2 Language Code
            RefLanguageUseTypeId = model.RefLanguageUseTypeId; // Language Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefLanguageUseType List
        /// <summary>
        /// The complete <see cref="RefLanguageUseType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefLanguageUseTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("907ffb22-379e-40f8-90c6-c5a0eb8644a1"), Code="", Description="Correspondence", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("974b1f71-5eaf-4d83-bf7a-ad836f2e2c1a"), Code="The language specified by the related Language Code is the language the person uses for both written and spoken correspondence.", Description="Correspondence", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("8219d9ea-c015-40f5-a8bf-9335002d5d6b"), Code="Dominant", Description="Dominant language", Definition="The language specified by the related Language Code is the person's dominant language.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("3f7f45e7-7149-4a7a-8f0f-b332c0e6dd8c"), Code="Home", Description="Home language", Definition="The language specified by the related Language Code is the language the person uses at home.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("b252ccc3-237b-467e-8d4f-0eab52d223b5"), Code="Native", Description="Native language", Definition="The language specified by the related Language Code is the person's native language.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("0f96a845-7082-46f8-b346-28866d527ac1"), Code="OtherLanguageProficiency", Description="Other language proficiency", Definition="The language specified by the related Language Code is the language the person's other language proficiency.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("91dd30e9-8ee4-48fc-9891-c763a3b15e1d"), Code="Other", Description="Other", Definition="The function and context in which a person uses the  language specified by the related Language Code is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("56aab2b0-f031-4cb3-99ad-ae5b95072501"), Code="Spoken", Description="Spoken Correspondence", Definition="The language specified by the related Language Code is the language the person uses for spoken correspondence.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("1cf858f3-e6e3-4d34-80b5-fec5c351d370"), Code="Written", Description="Written Correspondence", Definition="The language specified by the related Language Code is the language the person uses for written correspondence.", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion
    }
}
