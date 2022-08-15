//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStaffEmploymentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStaffEmploymentViewModel
     /// </summary>
    public partial class PsStaffEmploymentViewModel : ViewModelBase, Interfaces.IPsStaffEmployment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStaffEmployment";

        // member variable for the RefIpedsOccupationalCategoryId property
        private Guid? _RefIpedsOccupationalCategoryId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStaffEmploymentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIpedsOccupationalCategory"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19708">IPEDS Occupational Category</a>
        /// </para>
        /// </summary>
        [DisplayName("IPEDS Occupational Category")]
        public Guid? RefIpedsOccupationalCategoryId { get => _RefIpedsOccupationalCategoryId; set => SetProperty(ref _RefIpedsOccupationalCategoryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            RefIpedsOccupationalCategoryId = model.RefIpedsOccupationalCategoryId; // IPEDS Occupational Category
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
