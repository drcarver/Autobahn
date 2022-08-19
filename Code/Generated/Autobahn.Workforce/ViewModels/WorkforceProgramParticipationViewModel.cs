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
            new ReferenceModelBase { Id=Guid.Parse("40e491cb-b0ce-4a80-97bc-162ced4ae9ca"), Code="01", Description="Labor Exchange Services", Definition="The person's workforce and employment development program participation is Labor Exchange Services.", SortOrder=Convert.ToDecimal("0.00") },
            new ReferenceModelBase { Id=Guid.Parse("eb6960be-754e-4c6c-855a-99daedf28df2"), Code="02", Description="Adult Workforce Investment Act Program", Definition="The person's workforce and employment development program participation is an Adult Workforce Investment Act Program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("6bf1e017-4660-4d63-9bbc-60c6b4a75513"), Code="03", Description="Dislocated Worker Workforce Investment Act Program", Definition="The person's workforce and employment development program participation is a Dislocated Worker Workforce Investment Act Program.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("36730c08-9686-4e84-bd0f-658ceb4b6ba3"), Code="04", Description="Youth Workforce Investment Act Program", Definition="The person's workforce and employment development program participation is a Youth Workforce Investment Act Program.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("bafd6c17-4122-45af-8ee3-9ec592e96b83"), Code="05", Description="Job Corps", Definition="The person's workforce and employment development program participation is the Job Corps.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("7b26708b-5180-4eeb-9798-02fc5835e463"), Code="06", Description="Adult Education and Literacy", Definition="The person's workforce and employment development program participation is Adult Education and Literacy.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("ebbc286a-36e6-4ca9-bd56-cdc2b2dae77d"), Code="07", Description="National Farmworker Jobs Program", Definition="The person's workforce and employment development program participation is with the National Farmworker Jobs Program.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("da9127f2-b497-4ecc-a7e5-d1955921edf0"), Code="08", Description="Indian and Native American Programs", Definition="The person's workforce and employment development program participation is with the Indian and Native American Programs.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("8a85dff2-702d-4d4f-823a-e711f0680a8e"), Code="09", Description="Veteran's Programs", Definition="The person's workforce and employment development program participation is with the Veteran's Programs.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("66eb7aec-722a-4ac7-9e6c-f03af7597d48"), Code="10", Description="Trade Adjustment Assistance Program", Definition="The person's workforce and employment development program participation is with the Trade Adjustment Assistance Program.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("2326cdb7-3fb8-4bc9-945a-86481722e7b6"), Code="11", Description="YouthBuild Program", Definition="The person's workforce and employment development program participation is with the YouthBuild Program.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("69b29f12-2237-4de1-910b-464431bade9f"), Code="12", Description="Title V Older Worker Program", Definition="The person's workforce and employment development program participation is with the Title V Older Worker Program.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("77894a83-afd2-4c97-8a18-10ab0bfc13a7"), Code="13", Description="Registered Apprenticeship", Definition="The person's workforce and employment development program participation is a Registered Apprenticeship.", SortOrder=Convert.ToDecimal("21.00") },
            new ReferenceModelBase { Id=Guid.Parse("2daf7b13-bd9a-41f1-a0b8-cc7168c1caa5"), Code="14", Description="Non-traditional Apprenticeship", Definition="The person's workforce and employment development program participation is a Non-traditional Apprenticeship.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("75e65000-a180-47e0-be2e-6894e340287a"), Code="15", Description="Vocational Rehabilitation", Definition="The person's workforce and employment development program participation is Vocational Rehabilitation.", SortOrder=Convert.ToDecimal("23.00") },
            new ReferenceModelBase { Id=Guid.Parse("11c4756e-cd53-4dba-8a44-f645f8b37e29"), Code="16", Description="Food Stamp Employment and Training Program", Definition="The person's workforce and employment development program participation is with the Food Stamp Employment and Training Program.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("39716735-0d35-4928-a755-d4fdf85098ae"), Code="17", Description="TANF Employment and Training Program", Definition="The person's workforce and employment development program participation is with the TANF Employment and Training Program.", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("fec9dcce-11d7-46da-a7c5-d114202c81a7"), Code="18", Description="Other On-The-Job training Program", Definition="The person's workforce and employment development program participation is with an Other On-The-Job training Program.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("ec514349-970c-474a-96fa-4c2967ed232d"), Code="19", Description="Other Workforce Related Employment and Training Program", Definition="The person's workforce and employment development program participation is with the an Other Workforce Related Employment and Training Program.", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("2e3ca645-1a85-4141-82aa-cf2d000274a3"), Code="99", Description="No identified services", Definition="No identified services are related to the person's workforce and employment development program participation. ", SortOrder=Convert.ToDecimal("28.00") },
        };
        #endregion
    }
}
