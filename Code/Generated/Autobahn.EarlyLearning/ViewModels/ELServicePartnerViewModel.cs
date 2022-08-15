//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELServicePartnerViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELServicePartnerViewModel
     /// </summary>
    public partial class ELServicePartnerViewModel : ViewModelBase, Interfaces.IELServicePartner
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELServicePartner";

        // member variable for the MemorandumOfUnderstandingEndDate property
        private System.DateTime? _MemorandumOfUnderstandingEndDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELServicePartnerViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The date that a Memorandum of Understanding between the Early Learning Organization and the Service Partner is determined to expire.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20593">Memorandum of Understanding End Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Memorandum of Understanding End Date")]
        public System.DateTime? MemorandumOfUnderstandingEndDate { get => _MemorandumOfUnderstandingEndDate; set => SetProperty(ref _MemorandumOfUnderstandingEndDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELServicePartner model)
        {
            IsBusy = true;
            Id = model.Id;
            MemorandumOfUnderstandingEndDate = model.MemorandumOfUnderstandingEndDate; // Memorandum of Understanding End Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
