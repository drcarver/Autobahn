//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentFinancialAidViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentFinancialAidViewModel
     /// </summary>
    public partial class PsStudentFinancialAidViewModel : ViewModelBase, Interfaces.IPsStudentFinancialAid
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentFinancialAid";

        // member variable for the TitleIVParticipantAndRecipient property
        private System.Boolean? _TitleIVParticipantAndRecipient;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentFinancialAidViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A person who receives Title IV aid.  Title IV aid includes grant aid, work study aid, and loan aid such as: Federal Pell Grant, Federal Supplemental Educational Opportunity Grant (FSEOG), Teacher Education Assistance for College and Higher Education (TEACH) Grant, Federal Work-Study, Federal Perkins Loan, Subsidized Direct or FFEL Stafford Loan, and Unsubsidized Direct or FFEL Stafford Loan.  Title IV aid specifications are defined by the instructions for the IPEDS Student Financial Aid survey.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19292">Title IV Participant and Recipient</a>
        /// </para>
        /// </summary>
        [DisplayName("Title IV Participant and Recipient")]
        public System.Boolean? TitleIVParticipantAndRecipient { get => _TitleIVParticipantAndRecipient; set => SetProperty(ref _TitleIVParticipantAndRecipient, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentFinancialAid model)
        {
            IsBusy = true;
            Id = model.Id;
            TitleIVParticipantAndRecipient = model.TitleIVParticipantAndRecipient; // Title IV Participant and Recipient
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
