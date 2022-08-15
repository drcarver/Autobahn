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

        // member variable for the RefAcademicHonorTypeId property
        private Guid? _RefAcademicHonorTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentAcademicHonorViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicHonorType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19004">Academic Honors Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Academic Honors Type")]
        public Guid? RefAcademicHonorTypeId { get => _RefAcademicHonorTypeId; set => SetProperty(ref _RefAcademicHonorTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentAcademicHonor model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAcademicHonorTypeId = model.RefAcademicHonorTypeId; // Academic Honors Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
