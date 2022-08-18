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
            new ReferenceModelBase { Id=Guid.Parse("bdbf0cbb-a6d2-4e55-b171-8daae813a3ea"), Code="WaitingList", Description="Waiting list", Definition="The student is on a waiting list to receive services based on the referral.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("10e24a9b-0019-47f3-8479-fbf409666ed6"), Code="ParentDeclined", Description="Parent declined service", Definition="Parent declined service offered based on the referral.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("81778bbf-f610-4413-bae4-faafeb003236"), Code="Enrolled", Description="Enrolled", Definition="The student is enrolled based on the referral.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("34f0fbd0-0388-42f4-afc4-9554fd2d432b"), Code="Unreachable", Description="Unable to contact parent/family/guardian", Definition="The service provider has been unable to contact parent/family/guardian.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("b30988cf-29b9-4297-bb37-be6baa0034d7"), Code="NotEligible", Description="Not eligible", Definition="The student is not eligible to receive services related to the referral.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("8dfe2634-7c4a-4b4c-80e9-53bad209d005"), Code="Other", Description="Other", Definition="The outcome of the referral is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };
        #endregion
    }
}
