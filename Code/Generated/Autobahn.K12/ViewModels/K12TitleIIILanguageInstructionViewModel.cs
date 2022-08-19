//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12TitleIIILanguageInstructionViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12TitleIIILanguageInstruction View Model
     /// </summary>
    public partial class K12TitleIIILanguageInstructionViewModel : ViewModelBase, Interfaces.IK12TitleIIILanguageInstruction
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12TitleIIILanguageInstruction";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefTitleIIILanguageInstructionProgramTypeId -- (backing property for Title III Language Instruction Program Type)
        private Guid _RefTitleIIILanguageInstructionProgramTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Title III Language Instruction Program Type
        /// <para>
        /// The type of Title III language instructional education programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19437">Title III Language Instruction Program Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefTitleIIILanguageInstructionProgramTypeId { get => _RefTitleIIILanguageInstructionProgramTypeId; set => SetProperty(ref _RefTitleIIILanguageInstructionProgramTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12TitleIIILanguageInstruction model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            RefTitleIIILanguageInstructionProgramTypeId = model.RefTitleIIILanguageInstructionProgramTypeId; // Title III Language Instruction Program Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefTitleIIILanguageInstructionProgramType List
        /// <summary>
        /// The complete <see cref="RefTitleIIILanguageInstructionProgramType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTitleIIILanguageInstructionProgramTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("e5d0b691-4250-4d4e-8cbd-a82a705adcb1"), Code="DualLanguage", Description="Dual language", Definition="The type of Title III language instructional program is Dual language.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("c34d633b-a46a-4261-89d8-5a679f9f170f"), Code="TwoWayImmersion", Description="Two-way immersion", Definition="The type of Title III language instructional program is Two-way immersion.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("e7542a78-6c61-41f2-8755-04ade88c5a81"), Code="TransitionalBilingual", Description="Transitional bilingual", Definition="The type of Title III language instructional program is Transitional bilingual.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("6585df62-39e7-4154-a4c1-7919819c73f6"), Code="DevelopmentalBilingual", Description="Developmental bilingual", Definition="The type of Title III language instructional program is Developmental bilingual.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("1810a5b6-2d94-480c-ae9c-088032c9c0ad"), Code="HeritageLanguage", Description="Heritage language", Definition="The type of Title III language instructional program is Heritage language.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("05ee3d69-5ff2-4c99-bb94-504fe3ec0408"), Code="ShelteredEnglishInstruction", Description="Sheltered English instruction", Definition="The type of Title III language instructional program is Sheltered English instruction.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("733b15d0-984f-494d-b30c-ce79acd3e62e"), Code="StructuredEnglishImmersion", Description="Structured English immersion", Definition="The type of Title III language instructional program is Structured English immersion.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("aacbfea5-24a3-453e-a375-332ffddb5845"), Code="SDAIE", Description="Specially designed academic instruction delivered in English (SDAIE)", Definition="The type of Title III language instructional program is Specially designed academic instruction delivered in English (SDAIE).", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("0c1c5e20-db43-47c5-a622-0c74f24cea88"), Code="ContentBasedESL", Description="Content-based ESL", Definition="The type of Title III language instructional program is Content-based ESL.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("0392757b-9bd4-4f9b-87b6-b8886b9edae4"), Code="PullOutESL", Description="Pull-out ESL", Definition="The type of Title III language instructional program is Pull-out ESL.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("a1cfcdbd-b0bc-4b22-804d-3f70a22b0821"), Code="NewcomerPrograms", Description="Newcomer Programs", Definition="The type of Title III language instructional program is Newcomer Programs.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("d280a330-9e45-4734-a36a-4b02033d15c2"), Code="Other", Description="Other", Definition="The type of Title III language instructional program is in a category not yet included in CEDS.", SortOrder=Convert.ToDecimal("12.00") },
        };
        #endregion
    }
}
