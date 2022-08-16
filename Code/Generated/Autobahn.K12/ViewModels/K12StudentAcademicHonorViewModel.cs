//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentAcademicHonorViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentAcademicHonorViewModel
     /// </summary>
    public partial class K12StudentAcademicHonorViewModel : ViewModelBase, Interfaces.IK12StudentAcademicHonor
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentAcademicHonor";

        // member variable for the HonorDescription property
        private  _HonorDescription;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAcademicHonorTypeId property
        private Guid? _RefAcademicHonorTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  HonorDescription { get => _HonorDescription; set => SetProperty(ref _HonorDescription, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicHonorType"/> model
        /// </summary>
        public Guid? RefAcademicHonorTypeId { get => _RefAcademicHonorTypeId; set => SetProperty(ref _RefAcademicHonorTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentAcademicHonor model)
        {
            IsBusy = true;
            Id = model.Id;
            HonorDescription = model.HonorDescription; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAcademicHonorTypeId = model.RefAcademicHonorTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
