//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeStaffViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The AeStaffViewModel
     /// </summary>
    public partial class AeStaffViewModel : ViewModelBase, Interfaces.IAeStaff
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AeStaff";

        // member variable for the RefAeStaffClassificationId property
        private Guid? _RefAeStaffClassificationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AeStaffViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeStaffClassification"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19770">Adult Education Staff Classification</a>
        /// </para>
        /// </summary>
        [DisplayName("Adult Education Staff Classification")]
        public Guid? RefAeStaffClassificationId { get => _RefAeStaffClassificationId; set => SetProperty(ref _RefAeStaffClassificationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAeStaff model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAeStaffClassificationId = model.RefAeStaffClassificationId; // Adult Education Staff Classification
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
