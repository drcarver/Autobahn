//**********************************************************
//* DomainName: Workforce
//* FileName:   WorkforceProgramParticipationViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Workforce.ViewModels
{
     /// <summary>
     /// The WorkforceProgramParticipation View Model
     /// </summary>
    public partial class WorkforceProgramParticipationViewModel : ViewModelBase, Interfaces.IWorkforceProgramParticipation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from WorkforceProgramParticipation";

        // DiplomaOrCredentialAwardDate -- (backing property for Diploma or Credential Award Date)
        private System.String _DiplomaOrCredentialAwardDate;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // RefProfessionalTechnicalCredentialTypeId -- (backing property for Professional or Technical Credential Conferred)
        private Guid? _RefProfessionalTechnicalCredentialTypeId;

        // RefWfProgramParticipationId -- (backing property for Workforce Program Type)
        private Guid? _RefWfProgramParticipationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Diploma or Credential Award Date
        /// <para>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Professional or Technical Credential Conferred
        /// <para>
        /// An indicator of the category of credential conferred by a state occupational licensing entity or industry organization for competency in a specific area measured by a set of pre-established standards.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19780">Professional or Technical Credential Conferred</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProfessionalTechnicalCredentialTypeId { get => _RefProfessionalTechnicalCredentialTypeId; set => SetProperty(ref _RefProfessionalTechnicalCredentialTypeId, value); }

        /// <summary>
        /// Workforce Program Type
        /// <para>
        /// The type of workforce and employment development program that an individual is participating in.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20000">Workforce Program Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefWfProgramParticipationId { get => _RefWfProgramParticipationId; set => SetProperty(ref _RefWfProgramParticipationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IWorkforceProgramParticipation model)
        {
            IsBusy = true;
            Id = model.Id;
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // Diploma or Credential Award Date
            PersonProgramParticipationId = model.PersonProgramParticipationId; // 
            RefProfessionalTechnicalCredentialTypeId = model.RefProfessionalTechnicalCredentialTypeId; // Professional or Technical Credential Conferred
            RefWfProgramParticipationId = model.RefWfProgramParticipationId; // Workforce Program Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefWfProgramParticipation List
        /// <summary>
        /// The complete <see cref="RefWfProgramParticipation"> List
        /// </summary>
        private static List<ReferenceModelBase> RefWfProgramParticipationList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("0b3ed97f-f811-4468-affa-6af0be4ca32a"), Code="01", Description="Labor Exchange Services", Definition="The person's workforce and employment development program participation is Labor Exchange Services.", SortOrder=Convert.ToDecimal("0.00") },
            new ReferenceModelBase { Id=Guid.Parse("3eea6f9f-d97e-4dbc-bdce-088a415bf71a"), Code="02", Description="Adult Workforce Investment Act Program", Definition="The person's workforce and employment development program participation is an Adult Workforce Investment Act Program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("c2035560-1f7c-473e-8f15-feeeb1d9b7e5"), Code="03", Description="Dislocated Worker Workforce Investment Act Program", Definition="The person's workforce and employment development program participation is a Dislocated Worker Workforce Investment Act Program.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("0c662e77-3011-4abb-8ab3-b8e4a4da5b82"), Code="04", Description="Youth Workforce Investment Act Program", Definition="The person's workforce and employment development program participation is a Youth Workforce Investment Act Program.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("38b2c81f-a623-436e-aa16-e6166bb69a36"), Code="05", Description="Job Corps", Definition="The person's workforce and employment development program participation is the Job Corps.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("809880c9-83d8-4fc4-b2c0-ebc68c04e7fc"), Code="06", Description="Adult Education and Literacy", Definition="The person's workforce and employment development program participation is Adult Education and Literacy.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("725282de-299f-4de5-8ba9-359a63f8ce9d"), Code="07", Description="National Farmworker Jobs Program", Definition="The person's workforce and employment development program participation is with the National Farmworker Jobs Program.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("f7c55337-a08f-43c4-8d5f-cf0eb0323f89"), Code="08", Description="Indian and Native American Programs", Definition="The person's workforce and employment development program participation is with the Indian and Native American Programs.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("7710d340-d530-4175-aeb5-464cd2ac5ab5"), Code="09", Description="Veteran's Programs", Definition="The person's workforce and employment development program participation is with the Veteran's Programs.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("f031098b-8a21-4873-a615-9b0e24589c7e"), Code="10", Description="Trade Adjustment Assistance Program", Definition="The person's workforce and employment development program participation is with the Trade Adjustment Assistance Program.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("fb17b1f9-14ff-4a08-92fc-518b796d0fe7"), Code="11", Description="YouthBuild Program", Definition="The person's workforce and employment development program participation is with the YouthBuild Program.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("213997ea-ccd1-4dfc-b1b4-f724458efe59"), Code="12", Description="Title V Older Worker Program", Definition="The person's workforce and employment development program participation is with the Title V Older Worker Program.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("52043003-74c1-4b99-9e27-3e719b0bc218"), Code="13", Description="Registered Apprenticeship", Definition="The person's workforce and employment development program participation is a Registered Apprenticeship.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("92dfe161-056b-4214-a72a-29798db6bdca"), Code="14", Description="Non-traditional Apprenticeship", Definition="The person's workforce and employment development program participation is a Non-traditional Apprenticeship.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("217b2c23-6601-4628-ae59-df9d733d6416"), Code="15", Description="Vocational Rehabilitation", Definition="The person's workforce and employment development program participation is Vocational Rehabilitation.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("eb40f013-c164-43f2-ae3e-075cff86cfc6"), Code="16", Description="Food Stamp Employment and Training Program", Definition="The person's workforce and employment development program participation is with the Food Stamp Employment and Training Program.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("b31fb917-c7c7-48fe-9d1d-79ea5d9f9803"), Code="17", Description="TANF Employment and Training Program", Definition="The person's workforce and employment development program participation is with the TANF Employment and Training Program.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("2b91e0d8-e6ad-41bc-9e4d-cbd50f71b602"), Code="18", Description="Other On-The-Job training Program", Definition="The person's workforce and employment development program participation is with an Other On-The-Job training Program.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("5b218015-4702-4906-a935-ec1d71c9b68f"), Code="19", Description="Other Workforce Related Employment and Training Program", Definition="The person's workforce and employment development program participation is with the an Other Workforce Related Employment and Training Program.", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("44f0410a-b7e4-480c-ba12-1f5e2e3e3188"), Code="99", Description="No identified services", Definition="No identified services are related to the person's workforce and employment development program participation. ", SortOrder=Convert.ToDecimal("28.00") },
        };
        #endregion
    }
}
