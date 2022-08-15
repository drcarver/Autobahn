//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildDevelopmentalAssessmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildDevelopmentalAssessmentViewModel
     /// </summary>
    public partial class ELChildDevelopmentalAssessmentViewModel : ViewModelBase, Interfaces.IELChildDevelopmentalAssessment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildDevelopmentalAssessment";

        // member variable for the RefChildDevelopmentalScreeningStatusId property
        private Guid? _RefChildDevelopmentalScreeningStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildDevelopmentalAssessmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefChildDevelopmentalScreeningStatus"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19314">Child Developmental Screening Status</a>
        /// </para>
        /// </summary>
        [DisplayName("Child Developmental Screening Status")]
        public Guid? RefChildDevelopmentalScreeningStatusId { get => _RefChildDevelopmentalScreeningStatusId; set => SetProperty(ref _RefChildDevelopmentalScreeningStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildDevelopmentalAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            RefChildDevelopmentalScreeningStatusId = model.RefChildDevelopmentalScreeningStatusId; // Child Developmental Screening Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
