//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonReferralViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonReferral View Model
     /// </summary>
    public partial class PersonReferralViewModel : ViewModelBase, Interfaces.IPersonReferral
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonReferral";

        // member variable for the PersonId property
        private Guid _PersonId;

        // Reason -- (backing property for Referral Reason)
        private System.String _Reason;

        // ReferralDate -- (backing property for Referral Date)
        private System.DateTime? _ReferralDate;

        // ReferralTypeReceived -- (backing property for Referral Type Received)
        private System.String _ReferralTypeReceived;

        // ReferredTo -- (backing property for Referred To)
        private System.String _ReferredTo;

        // RefReferralOutcomeId -- (backing property for Referral Outcome)
        private Guid? _RefReferralOutcomeId;

        // Source -- (backing property for Referral Source)
        private System.String _Source;

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
        /// Referral Reason
        /// <para>
        /// The reason for the referral.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20455">Referral Reason</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Reason { get => _Reason; set => SetProperty(ref _Reason, value); }

        /// <summary>
        /// Referral Date
        /// <para>
        /// The date of referral.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20453">Referral Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ReferralDate { get => _ReferralDate; set => SetProperty(ref _ReferralDate, value); }

        /// <summary>
        /// Referral Type Received
        /// <para>
        /// A type of service that a child or family has received a referral for.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20457">Referral Type Received</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ReferralTypeReceived { get => _ReferralTypeReceived; set => SetProperty(ref _ReferralTypeReceived, value); }

        /// <summary>
        /// Referred To
        /// <para>
        /// The program or organization to which the child/family was referred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20458">Referred To</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ReferredTo { get => _ReferredTo; set => SetProperty(ref _ReferredTo, value); }

        /// <summary>
        /// Referral Outcome
        /// <para>
        /// The outcome of the referral.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20454">Referral Outcome</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefReferralOutcomeId { get => _RefReferralOutcomeId; set => SetProperty(ref _RefReferralOutcomeId, value); }

        /// <summary>
        /// Referral Source
        /// <para>
        /// The person, program, or organization making the initial referral.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20456">Referral Source</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Source { get => _Source; set => SetProperty(ref _Source, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonReferral model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId; // 
            Reason = model.Reason; // Referral Reason
            ReferralDate = model.ReferralDate; // Referral Date
            ReferralTypeReceived = model.ReferralTypeReceived; // Referral Type Received
            ReferredTo = model.ReferredTo; // Referred To
            RefReferralOutcomeId = model.RefReferralOutcomeId; // Referral Outcome
            Source = model.Source; // Referral Source
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefReferralOutcome List
        /// <summary>
        /// The complete <see cref="RefReferralOutcome"> List
        /// </summary>
        private static List<ReferenceModelBase> RefReferralOutcomeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("a6a5a314-75e7-4d28-a325-4aaaaaaffbf3"), Code="WaitingList", Description="Waiting list", Definition="The student is on a waiting list to receive services based on the referral.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("38b0578d-6e3a-46b1-a89d-d7bf22745697"), Code="ParentDeclined", Description="Parent declined service", Definition="Parent declined service offered based on the referral.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("c656ab9d-4c05-416f-b931-6050c7395009"), Code="Enrolled", Description="Enrolled", Definition="The student is enrolled based on the referral.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("47450612-b8fd-4c64-b83b-5080e2703989"), Code="Unreachable", Description="Unable to contact parent/family/guardian", Definition="The service provider has been unable to contact parent/family/guardian.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("9b8c996c-86c8-44c9-8554-4f45654dd0eb"), Code="NotEligible", Description="Not eligible", Definition="The student is not eligible to receive services related to the referral.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("b22fe22b-a7e7-4599-96d0-a568794b1ba4"), Code="Other", Description="Other", Definition="The outcome of the referral is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };
        #endregion
    }
}
