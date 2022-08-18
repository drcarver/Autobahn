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
            new ReferenceModelBase { Id=Guid.Parse("dd0663fc-b9da-4a24-aaa5-307ad35c38d2"), Code="DualLanguage", Description="Dual language", Definition="The type of Title III language instructional program is Dual language.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("29e52acd-ff44-40b0-a17c-bf2b74505ca5"), Code="TwoWayImmersion", Description="Two-way immersion", Definition="The type of Title III language instructional program is Two-way immersion.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("ff40681b-d19e-4633-aafe-12ac81ae2484"), Code="TransitionalBilingual", Description="Transitional bilingual", Definition="The type of Title III language instructional program is Transitional bilingual.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("aaf3eb45-5fb7-4c85-ae1d-f8757aef8991"), Code="DevelopmentalBilingual", Description="Developmental bilingual", Definition="The type of Title III language instructional program is Developmental bilingual.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("d250e191-21e4-4864-9964-b79b11c985f6"), Code="HeritageLanguage", Description="Heritage language", Definition="The type of Title III language instructional program is Heritage language.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("4b7b7469-755e-4c44-8768-146c6aa72c71"), Code="ShelteredEnglishInstruction", Description="Sheltered English instruction", Definition="The type of Title III language instructional program is Sheltered English instruction.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("c3c198c7-4a30-4b82-9bd9-26a54a20040c"), Code="StructuredEnglishImmersion", Description="Structured English immersion", Definition="The type of Title III language instructional program is Structured English immersion.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("ff755175-4ef8-492c-b7e9-908b6b75f454"), Code="SDAIE", Description="Specially designed academic instruction delivered in English (SDAIE)", Definition="The type of Title III language instructional program is Specially designed academic instruction delivered in English (SDAIE).", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("bfbca4d6-e238-4ed6-ac72-8e05a72407cf"), Code="ContentBasedESL", Description="Content-based ESL", Definition="The type of Title III language instructional program is Content-based ESL.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("c2fe5040-f156-4b0c-945c-b1256480d9f0"), Code="PullOutESL", Description="Pull-out ESL", Definition="The type of Title III language instructional program is Pull-out ESL.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("6ab742cc-a355-4d12-bc31-ffeb173d1119"), Code="NewcomerPrograms", Description="Newcomer Programs", Definition="The type of Title III language instructional program is Newcomer Programs.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("fb35fbbb-2434-426c-9413-8bcb9d631e08"), Code="Other", Description="Other", Definition="The type of Title III language instructional program is in a category not yet included in CEDS.", SortOrder=Convert.ToDecimal("12.00") },
        };
        #endregion
    }
}
