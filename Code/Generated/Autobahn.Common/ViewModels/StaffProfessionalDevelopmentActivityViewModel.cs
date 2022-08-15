//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffProfessionalDevelopmentActivityViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffProfessionalDevelopmentActivityViewModel
     /// </summary>
    public partial class StaffProfessionalDevelopmentActivityViewModel : ViewModelBase, Interfaces.IStaffProfessionalDevelopmentActivity
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffProfessionalDevelopmentActivity";

        // member variable for the RefCourseCreditUnitId property
        private Guid? _RefCourseCreditUnitId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the StaffProfessionalDevelopmentActivityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseCreditUnit"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19057">Course Credit Units</a>
        /// </para>
        /// </summary>
        [DisplayName("Course Credit Units")]
        public Guid? RefCourseCreditUnitId { get => _RefCourseCreditUnitId; set => SetProperty(ref _RefCourseCreditUnitId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffProfessionalDevelopmentActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            RefCourseCreditUnitId = model.RefCourseCreditUnitId; // Course Credit Units
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
