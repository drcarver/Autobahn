//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodProgramTypeOfferedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The EarlyChildhoodProgramTypeOfferedViewModel
     /// </summary>
    public partial class EarlyChildhoodProgramTypeOfferedViewModel : ViewModelBase, Interfaces.IEarlyChildhoodProgramTypeOffered
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from EarlyChildhoodProgramTypeOffered";

        // member variable for the RefEarlyChildhoodProgramEnrollmentTypeId property
        private Guid _RefEarlyChildhoodProgramEnrollmentTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the EarlyChildhoodProgramTypeOfferedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEarlyChildhoodProgramEnrollmentType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19829">Early Childhood Program Enrollment Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Early Childhood Program Enrollment Type")]
        public Guid RefEarlyChildhoodProgramEnrollmentTypeId { get => _RefEarlyChildhoodProgramEnrollmentTypeId; set => SetProperty(ref _RefEarlyChildhoodProgramEnrollmentTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IEarlyChildhoodProgramTypeOffered model)
        {
            IsBusy = true;
            Id = model.Id;
            RefEarlyChildhoodProgramEnrollmentTypeId = model.RefEarlyChildhoodProgramEnrollmentTypeId; // Early Childhood Program Enrollment Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
