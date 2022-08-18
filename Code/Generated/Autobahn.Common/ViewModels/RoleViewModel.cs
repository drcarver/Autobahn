//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The Role View Model
     /// </summary>
    public partial class RoleViewModel : ViewModelBase, Interfaces.IRole
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Role";

        // member variable for the Name property
        private System.String _Name;

        // RefRoleId -- (backing property for Role)
        private Guid? _RefRoleId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Role
        /// <para>
        /// A description of the way in which a person relates to an organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20959">Role</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefRoleId { get => _RefRoleId; set => SetProperty(ref _RefRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRole model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name; // 
            RefRoleId = model.RefRoleId; // Role
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefRole List
        /// <summary>
        /// The complete <see cref="RefRole"> List
        /// </summary>
        private static List<ReferenceModelBase> RefRoleList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("4d611694-1607-46bf-9ead-d8639bf9c3a6"), Code="AEStaff", Description="AE Staff", Definition="A person for whom instruction and/or services are provided in an Adult Education program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("940d5bd5-65d1-4eb4-95b7-a5479cbe513e"), Code="AEStudent", Description="AE Student", Definition="An individual who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff in a Career and Technical Education program.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("f6dbcc6b-6c1b-400a-979e-afbae4ea0fc3"), Code="CTEStaff", Description="CTE Staff", Definition="A person for whom instruction, services, and/or care are provided in a Career and Technical Education program and who has met the state-defined threshold of Career and Technical Education participation.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("48d125ea-7235-45ea-b031-d497c83b35c8"), Code="CTEStudent", Description="CTE Student", Definition="An individual who is an applicant of a postsecondary institution.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("31ddcd94-2d1f-4f34-aeb8-6350eabedce4"), Code="ELChild", Description="EL Child", Definition="A person for whom instruction, services, and/or care are provided in an early childhood program under the jurisdiction of a school, education agency, or other institution or program.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("ae9a8600-52cb-4f13-8d65-30295e7d91ab"), Code="ELStaff", Description="EL Staff", Definition="A person who performs specified activities for a public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the early childhood level.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("c71527a2-e695-4c5f-b554-a73b8242e8c3"), Code="K12Staff", Description="K12 Staff", Definition="An individual who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the early childhood level through high school completion.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("ce06bb43-0d47-4999-9b31-ce47fcfdf911"), Code="K12Student", Description="K12 Student", Definition="A person for whom instruction, services, and/or care are provided in an elementary or secondary educational program under the jurisdiction of a school, education agency, or other institution or program.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("9808115f-5459-40ce-9887-9d061ae5b498"), Code="ParentGuardian", Description="Parent/Guardian", Definition="A person having parental or legal guardianship responsibility for a learner.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("4a90575f-3bfe-4a48-ba4f-5193ea23d29d"), Code="PSApplicant", Description="PS Applicant", Definition="A person who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the postsecondary level.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("ad3654a6-0dce-460c-9972-d7195b473195"), Code="PSStaff", Description="PS Staff", Definition="An individual who is a prospect, applicant, admitted student, enrolled student, or alum of a postsecondary institution.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("0b6f00c1-e591-4044-9b1f-e5e728779b74"), Code="PSStudent", Description="PS Student", Definition="", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("d544d857-d88f-4a88-8d15-b3ffb3cdee67"), Code="WorkforceProgramParticipant", Description="Workforce Program Participant", Definition="A person who is employed by an Adult Education program.", SortOrder=Convert.ToDecimal("13.00") },
        };
        #endregion
    }
}
