//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CharterSchoolAuthorizerAgencyViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12CharterSchoolAuthorizerAgencyViewModel
     /// </summary>
    public partial class K12CharterSchoolAuthorizerAgencyViewModel : ViewModelBase, Interfaces.IK12CharterSchoolAuthorizerAgency
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12CharterSchoolAuthorizerAgency";

        // member variable for the K12CharterSchoolAuthorizerAgencyId property
        private Guid? _K12CharterSchoolAuthorizerAgencyId;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCharterSchoolAuthorizerTypeId property
        private  _RefCharterSchoolAuthorizerTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12CharterSchoolAuthorizerAgency"/> model
        /// </summary>
        public Guid? K12CharterSchoolAuthorizerAgencyId { get => _K12CharterSchoolAuthorizerAgencyId; set => SetProperty(ref _K12CharterSchoolAuthorizerAgencyId, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterSchoolAuthorizerType"/> model
        /// </summary>
        public  RefCharterSchoolAuthorizerTypeId { get => _RefCharterSchoolAuthorizerTypeId; set => SetProperty(ref _RefCharterSchoolAuthorizerTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12CharterSchoolAuthorizerAgency model)
        {
            IsBusy = true;
            Id = model.Id;
            K12CharterSchoolAuthorizerAgencyId = model.K12CharterSchoolAuthorizerAgencyId; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCharterSchoolAuthorizerTypeId = model.RefCharterSchoolAuthorizerTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
