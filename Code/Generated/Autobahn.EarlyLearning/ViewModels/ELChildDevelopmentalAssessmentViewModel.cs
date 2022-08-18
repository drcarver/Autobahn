//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildDevelopmentalAssessmentViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildDevelopmentalAssessment View Model
     /// </summary>
    public partial class ELChildDevelopmentalAssessmentViewModel : ViewModelBase, Interfaces.IELChildDevelopmentalAssessment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildDevelopmentalAssessment";

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefChildDevelopmentalScreeningStatusId -- (backing property for Child Developmental Screening Status)
        private Guid? _RefChildDevelopmentalScreeningStatusId;

        // RefDevelopmentalEvaluationFindingId -- (backing property for Developmental Evaluation Finding)
        private Guid? _RefDevelopmentalEvaluationFindingId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Child Developmental Screening Status
        /// <para>
        /// The result of a brief standardized screening tool aiding in the identification of children at risk of a developmental delay/disorder.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19314">Child Developmental Screening Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefChildDevelopmentalScreeningStatusId { get => _RefChildDevelopmentalScreeningStatusId; set => SetProperty(ref _RefChildDevelopmentalScreeningStatusId, value); }

        /// <summary>
        /// Developmental Evaluation Finding
        /// <para>
        /// Child developmental delay/disability determined by procedure used by appropriate qualified personnel.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19315">Developmental Evaluation Finding</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDevelopmentalEvaluationFindingId { get => _RefDevelopmentalEvaluationFindingId; set => SetProperty(ref _RefDevelopmentalEvaluationFindingId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildDevelopmentalAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId; // 
            RefChildDevelopmentalScreeningStatusId = model.RefChildDevelopmentalScreeningStatusId; // Child Developmental Screening Status
            RefDevelopmentalEvaluationFindingId = model.RefDevelopmentalEvaluationFindingId; // Developmental Evaluation Finding
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
