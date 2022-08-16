//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12TitleIIILanguageInstructionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12TitleIIILanguageInstructionViewModel
     /// </summary>
    public partial class K12TitleIIILanguageInstructionViewModel : ViewModelBase, Interfaces.IK12TitleIIILanguageInstruction
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12TitleIIILanguageInstruction";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefTitleIIILanguageInstructionProgramTypeId property
        private Guid? _RefTitleIIILanguageInstructionProgramTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIILanguageInstructionProgramType"/> model
        /// </summary>
        public Guid? RefTitleIIILanguageInstructionProgramTypeId { get => _RefTitleIIILanguageInstructionProgramTypeId; set => SetProperty(ref _RefTitleIIILanguageInstructionProgramTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12TitleIIILanguageInstruction model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefTitleIIILanguageInstructionProgramTypeId = model.RefTitleIIILanguageInstructionProgramTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
