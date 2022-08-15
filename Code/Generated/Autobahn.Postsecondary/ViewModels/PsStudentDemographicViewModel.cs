//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentDemographicViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentDemographicViewModel
     /// </summary>
    public partial class PsStudentDemographicViewModel : ViewModelBase, Interfaces.IPsStudentDemographic
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentDemographic";

        // member variable for the RefCampusResidencyTypeId property
        private Guid? _RefCampusResidencyTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentDemographicViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCampusResidencyType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19035">Campus Residency Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Campus Residency Type")]
        public Guid? RefCampusResidencyTypeId { get => _RefCampusResidencyTypeId; set => SetProperty(ref _RefCampusResidencyTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentDemographic model)
        {
            IsBusy = true;
            Id = model.Id;
            RefCampusResidencyTypeId = model.RefCampusResidencyTypeId; // Campus Residency Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
