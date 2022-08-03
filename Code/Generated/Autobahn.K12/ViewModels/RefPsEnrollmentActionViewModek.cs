//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefPsEnrollmentActionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The RefPsEnrollmentActionViewModel
     /// </summary>
    public partial class RefPsEnrollmentActionViewModel : BindableBase, IRefPsEnrollmentAction
    {
#region "Backing Fields"
        // member variable for the Description property
        private System.String _Description;

        // member variable for the Code property
        private System.String _Code;

        // member variable for the Definition property
        private System.String _Definition;

        // member variable for the RefJurisdiction property
        private System.Int32? _RefJurisdiction;

        // member variable for the SortOrder property
        private System.Decimal? _SortOrder;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

        public System.String Code  { get => _Code; set => SetProperty(ref _Code, value); }

        public System.String Definition  { get => _Definition; set => SetProperty(ref _Definition, value); }

        public System.Int32? RefJurisdiction { get => _RefJurisdiction; set => SetProperty(ref _RefJurisdiction, value); }

        public System.Decimal? SortOrder { get => _SortOrder; set => SetProperty(ref _SortOrder, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IRefPsEnrollmentAction model)
        {
            IsBusy = true;
            Id = model.Id;
            Description = model.Description;
            Code = model.Code;
            Definition = model.Definition;
            RefJurisdiction = model.RefJurisdiction;
            SortOrder = model.SortOrder;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
