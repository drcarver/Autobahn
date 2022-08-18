//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationAttainmentViewModel.cs
//* Name:       Adult Education Credential Attainment Employed Indicator
//* Definition: An indication of whether the adult education participant received a secondary school diploma or its recognized equivalent while enrolled in the adult education program or within one year of exiting the adult education program and was employed within one year of exiting the adult education program.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// An indication of whether the adult education participant received a secondary school diploma or its recognized equivalent while enrolled in the adult education program or within one year of exiting the adult education program and was employed within one year of exiting the adult education program.
     /// </summary>
    public partial class ProgramParticipationAttainmentViewModel : ViewModelBase, Interfaces.IProgramParticipationAttainment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationAttainment";

        // AECredentialAttainmentEmployedIndicator -- (backing property for Adult Education Credential Attainment Employed Indicator)
        private System.Boolean? _AECredentialAttainmentEmployedIndicator;

        // AECredentialAttainmentPSCredentialIndicator -- (backing property for Adult Education Credential Attainment Postsecondary Credential Indicator)
        private System.Boolean? _AECredentialAttainmentPSCredentialIndicator;

        // AECredentialAttainmentPSEnrollmentIndicator -- (backing property for Adult Education Credential Attainment Postsecondary Enrollment Indicator)
        private System.Boolean? _AECredentialAttainmentPSEnrollmentIndicator;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId -- (backing property for EDFacts Academic or Career and Technical Outcome Exit Type)
        private Guid? _RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId;

        // RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId -- (backing property for EDFacts Academic or Career and Technical Outcome Type)
        private Guid? _RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Adult Education Credential Attainment Employed Indicator
        /// <para>
        /// An indication of whether the adult education participant received a secondary school diploma or its recognized equivalent while enrolled in the adult education program or within one year of exiting the adult education program and was employed within one year of exiting the adult education program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20912">Adult Education Credential Attainment Employed Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? AECredentialAttainmentEmployedIndicator { get => _AECredentialAttainmentEmployedIndicator; set => SetProperty(ref _AECredentialAttainmentEmployedIndicator, value); }

        /// <summary>
        /// Adult Education Credential Attainment Postsecondary Credential Indicator
        /// <para>
        /// An indication of whether the adult education participant received a postsecondary credential while enrolled in the adult education program or within one year of exiting the adult education program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20913">Adult Education Credential Attainment Postsecondary Credential Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? AECredentialAttainmentPSCredentialIndicator { get => _AECredentialAttainmentPSCredentialIndicator; set => SetProperty(ref _AECredentialAttainmentPSCredentialIndicator, value); }

        /// <summary>
        /// Adult Education Credential Attainment Postsecondary Enrollment Indicator
        /// <para>
        /// An indication of whether the adult education participant received a secondary school diploma or its recognized equivalent while enrolled in the adult education program or within one year of exiting the adult education program and entered into postsecondary education within one year of exiting the adult education program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20914">Adult Education Credential Attainment Postsecondary Enrollment Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? AECredentialAttainmentPSEnrollmentIndicator { get => _AECredentialAttainmentPSEnrollmentIndicator; set => SetProperty(ref _AECredentialAttainmentPSEnrollmentIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// EDFacts Academic or Career and Technical Outcome Exit Type
        /// <para>
        /// The type of academic or career and technical outcome attained up to 90 days after exiting the facility or program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20927">EDFacts Academic or Career and Technical Outcome Exit Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId { get => _RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId; set => SetProperty(ref _RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId, value); }

        /// <summary>
        /// EDFacts Academic or Career and Technical Outcome Type
        /// <para>
        /// The type of academic or career and technical outcome attained while enrolled in the program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20928">EDFacts Academic or Career and Technical Outcome Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId { get => _RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId; set => SetProperty(ref _RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationAttainment model)
        {
            IsBusy = true;
            Id = model.Id;
            AECredentialAttainmentEmployedIndicator = model.AECredentialAttainmentEmployedIndicator; // Adult Education Credential Attainment Employed Indicator
            AECredentialAttainmentPSCredentialIndicator = model.AECredentialAttainmentPSCredentialIndicator; // Adult Education Credential Attainment Postsecondary Credential Indicator
            AECredentialAttainmentPSEnrollmentIndicator = model.AECredentialAttainmentPSEnrollmentIndicator; // Adult Education Credential Attainment Postsecondary Enrollment Indicator
            PersonProgramParticipationId = model.PersonProgramParticipationId; // 
            RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId = model.RefEdFactsAcademicOrCareerAndTechnicalOutcomeExitTypeId; // EDFacts Academic or Career and Technical Outcome Exit Type
            RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId = model.RefEdFactsAcademicOrCareerAndTechnicalOutcomeTypeId; // EDFacts Academic or Career and Technical Outcome Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
