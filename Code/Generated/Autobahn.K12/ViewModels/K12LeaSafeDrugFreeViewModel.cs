//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaSafeDrugFreeViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaSafeDrugFreeViewModel
     /// </summary>
    public partial class K12LeaSafeDrugFreeViewModel : ViewModelBase, Interfaces.IK12LeaSafeDrugFree
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaSafeDrugFree";

        // member variable for the IndicatorName property
        private System.String _IndicatorName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaSafeDrugFreeViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19461">Safe and Drug Free Indicator Name</a>
        /// </para>
        /// </summary>
        [DisplayName("Safe and Drug Free Indicator Name")]
        public System.String IndicatorName { get => _IndicatorName; set => SetProperty(ref _IndicatorName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaSafeDrugFree model)
        {
            IsBusy = true;
            Id = model.Id;
            IndicatorName = model.IndicatorName; // Safe and Drug Free Indicator Name
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
