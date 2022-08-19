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
            new ReferenceModelBase { Id=Guid.Parse("02953fe0-0169-4fbc-b7fb-67e931c77c49"), Code="", Description="Correspondence", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("dd902690-7ca5-4fb3-a51e-1068423f8253"), Code="The language specified by the related Language Code is the language the person uses for both written and spoken correspondence.", Description="Correspondence", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("b4b144e6-02a5-466d-9eaa-8b4d87b10699"), Code="Dominant", Description="Dominant language", Definition="The language specified by the related Language Code is the person's dominant language.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("28d5ab3b-c7a5-46a8-bf20-26f9181b7d00"), Code="Home", Description="Home language", Definition="The language specified by the related Language Code is the language the person uses at home.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("cd0225c7-7b9a-4462-866a-2f8f82ebfc45"), Code="Native", Description="Native language", Definition="The language specified by the related Language Code is the person's native language.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("be20c019-0941-46d4-b1c7-3d002a77cd33"), Code="OtherLanguageProficiency", Description="Other language proficiency", Definition="The language specified by the related Language Code is the language the person's other language proficiency.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("89e3b807-bdd1-48ff-b729-34483d739562"), Code="Other", Description="Other", Definition="The function and context in which a person uses the  language specified by the related Language Code is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("b7fe27f7-48f8-4c43-a8ac-bcce16972132"), Code="Spoken", Description="Spoken Correspondence", Definition="The language specified by the related Language Code is the language the person uses for spoken correspondence.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("f2e53514-a0fa-443e-92a3-0f73249bef0c"), Code="Written", Description="Written Correspondence", Definition="The language specified by the related Language Code is the language the person uses for written correspondence.", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion
    }
}
