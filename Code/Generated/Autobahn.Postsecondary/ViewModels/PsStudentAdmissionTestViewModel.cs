//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAdmissionTestViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentAdmissionTestViewModel
     /// </summary>
    public partial class PsStudentAdmissionTestViewModel : ViewModelBase, Interfaces.IPsStudentAdmissionTest
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentAdmissionTest";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefStandardizedAdmissionTestId property
        private  _RefStandardizedAdmissionTestId;

        // member variable for the StandardizedAdmissionTestScore property
        private Guid? _StandardizedAdmissionTestScore;

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
        /// Reference to an optional instance of the <see cref="RefStandardizedAdmissionTest"/> model
        /// </summary>
        public  RefStandardizedAdmissionTestId { get => _RefStandardizedAdmissionTestId; set => SetProperty(ref _RefStandardizedAdmissionTestId, value); }

        /// <summary>
        /// </summary>
        public Guid? StandardizedAdmissionTestScore { get => _StandardizedAdmissionTestScore; set => SetProperty(ref _StandardizedAdmissionTestScore, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentAdmissionTest model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefStandardizedAdmissionTestId = model.RefStandardizedAdmissionTestId; // 
            StandardizedAdmissionTestScore = model.StandardizedAdmissionTestScore; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
