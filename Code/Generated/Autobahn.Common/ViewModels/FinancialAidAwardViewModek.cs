//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   FinancialAidAwardViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The FinancialAidAwardViewModel
     /// </summary>
    public partial class FinancialAidAwardViewModel : BindableBase, IFinancialAidAward
    {
#region "Backing Fields"
        // member variable for the FinancialAidAwardAmount property
        private System.Decimal? _FinancialAidAwardAmount;

        // member variable for the FinancialAidYearDesignator property
        private System.String _FinancialAidYearDesignator;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidAwardTypeId"/> model
        /// </summary>
        public Guid? RefFinancialAidAwardTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFinancialAidStatusId"/> model
        /// </summary>
        public Guid? RefFinancialAidStatusId { get; set; }

        public System.Decimal? FinancialAidAwardAmount { get => _FinancialAidAwardAmount; set => SetProperty(ref _FinancialAidAwardAmount, value); }

        public System.String FinancialAidYearDesignator  { get => _FinancialAidYearDesignator; set => SetProperty(ref _FinancialAidYearDesignator, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IFinancialAidAward model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefFinancialAidAwardTypeId = model.RefFinancialAidAwardTypeId;
            RefFinancialAidStatusId = model.RefFinancialAidStatusId;
            FinancialAidAwardAmount = model.FinancialAidAwardAmount;
            FinancialAidYearDesignator = model.FinancialAidYearDesignator;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
