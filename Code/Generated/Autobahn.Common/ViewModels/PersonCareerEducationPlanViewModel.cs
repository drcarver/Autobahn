//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonCareerEducationPlanViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonCareerEducationPlan View Model
     /// </summary>
    public partial class PersonCareerEducationPlanViewModel : ViewModelBase, Interfaces.IPersonCareerEducationPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonCareerEducationPlan";

        // LastUpdated -- (backing property for Career Education Plan Date)
        private System.DateTime? _LastUpdated;

        // member variable for the PersonId property
        private Guid _PersonId;

        // ProfessionalDevelopmentPlanApprovedBySupervisor -- (backing property for Professional Development Plan Approved by Supervisor)
        private System.Boolean? _ProfessionalDevelopmentPlanApprovedBySupervisor;

        // ProfessionalDevelopmentPlanCompletion -- (backing property for Professional Development Plan Completion)
        private System.DateTime? _ProfessionalDevelopmentPlanCompletion;

        // RefCareerEducationPlanTypeId -- (backing property for Career Education Plan Type)
        private Guid? _RefCareerEducationPlanTypeId;

        // TuitionFunded -- (backing property for Tuition Funded)
        private System.Boolean? _TuitionFunded;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Career Education Plan Date
        /// <para>
        /// The date on which an individual's professional development career plan was last updated.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20255">Career Education Plan Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? LastUpdated { get => _LastUpdated; set => SetProperty(ref _LastUpdated, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Professional Development Plan Approved by Supervisor
        /// <para>
        /// Professional development plan is approved by the employee's supervisor.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20599">Professional Development Plan Approved by Supervisor</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ProfessionalDevelopmentPlanApprovedBySupervisor { get => _ProfessionalDevelopmentPlanApprovedBySupervisor; set => SetProperty(ref _ProfessionalDevelopmentPlanApprovedBySupervisor, value); }

        /// <summary>
        /// Professional Development Plan Completion
        /// <para>
        /// The date the professional development plan is completed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20600">Professional Development Plan Completion</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ProfessionalDevelopmentPlanCompletion { get => _ProfessionalDevelopmentPlanCompletion; set => SetProperty(ref _ProfessionalDevelopmentPlanCompletion, value); }

        /// <summary>
        /// Career Education Plan Type
        /// <para>
        /// An indication of whether an individual completed an individualized guidance and counseling plan
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20256">Career Education Plan Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCareerEducationPlanTypeId { get => _RefCareerEducationPlanTypeId; set => SetProperty(ref _RefCareerEducationPlanTypeId, value); }

        /// <summary>
        /// Tuition Funded
        /// <para>
        /// Indicates that tuition for person's participation in a program, service, or course is funded or partially funded by an external grant program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20554">Tuition Funded</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? TuitionFunded { get => _TuitionFunded; set => SetProperty(ref _TuitionFunded, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonCareerEducationPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            LastUpdated = model.LastUpdated; // Career Education Plan Date
            PersonId = model.PersonId; // 
            ProfessionalDevelopmentPlanApprovedBySupervisor = model.ProfessionalDevelopmentPlanApprovedBySupervisor; // Professional Development Plan Approved by Supervisor
            ProfessionalDevelopmentPlanCompletion = model.ProfessionalDevelopmentPlanCompletion; // Professional Development Plan Completion
            RefCareerEducationPlanTypeId = model.RefCareerEducationPlanTypeId; // Career Education Plan Type
            TuitionFunded = model.TuitionFunded; // Tuition Funded
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
