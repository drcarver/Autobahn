//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaViewModel
     /// </summary>
    public partial class K12LeaViewModel : ViewModelBase, Interfaces.IK12Lea
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12Lea";

        // member variable for the CharterSchoolIndicator property
        private Guid? _CharterSchoolIndicator;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefLEAImprovementStatusId property
        private  _RefLEAImprovementStatusId;

        // member variable for the RefLeaTypeId property
        private  _RefLeaTypeId;

        // member variable for the RefPublicSchoolChoiceStatusId property
        private  _RefPublicSchoolChoiceStatusId;

        // member variable for the SupervisoryUnionIdentificationNumber property
        private  _SupervisoryUnionIdentificationNumber;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? CharterSchoolIndicator { get => _CharterSchoolIndicator; set => SetProperty(ref _CharterSchoolIndicator, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLEAImprovementStatus"/> model
        /// </summary>
        public  RefLEAImprovementStatusId { get => _RefLEAImprovementStatusId; set => SetProperty(ref _RefLEAImprovementStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaType"/> model
        /// </summary>
        public  RefLeaTypeId { get => _RefLeaTypeId; set => SetProperty(ref _RefLeaTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPublicSchoolChoiceStatus"/> model
        /// </summary>
        public  RefPublicSchoolChoiceStatusId { get => _RefPublicSchoolChoiceStatusId; set => SetProperty(ref _RefPublicSchoolChoiceStatusId, value); }

        /// <summary>
        /// </summary>
        public  SupervisoryUnionIdentificationNumber { get => _SupervisoryUnionIdentificationNumber; set => SetProperty(ref _SupervisoryUnionIdentificationNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12Lea model)
        {
            IsBusy = true;
            Id = model.Id;
            CharterSchoolIndicator = model.CharterSchoolIndicator; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefLEAImprovementStatusId = model.RefLEAImprovementStatusId; // 
            RefLeaTypeId = model.RefLeaTypeId; // 
            RefPublicSchoolChoiceStatusId = model.RefPublicSchoolChoiceStatusId; // 
            SupervisoryUnionIdentificationNumber = model.SupervisoryUnionIdentificationNumber; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
