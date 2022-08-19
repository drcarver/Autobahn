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
            new ReferenceModelBase { Id=Guid.Parse("dcbe26e7-87a9-4494-a28a-ce749cf462c8"), Code="AEStaff", Description="AE Staff", Definition="A person for whom instruction and/or services are provided in an Adult Education program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("b0de6465-2dde-432e-879b-fd4926b2b257"), Code="AEStudent", Description="AE Student", Definition="An individual who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff in a Career and Technical Education program.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("bf8ecdb6-7aa7-4226-a96b-dc9d602d0bbf"), Code="CTEStaff", Description="CTE Staff", Definition="A person for whom instruction, services, and/or care are provided in a Career and Technical Education program and who has met the state-defined threshold of Career and Technical Education participation.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("0406aedf-7644-4cef-884d-6307b7f4f6d7"), Code="CTEStudent", Description="CTE Student", Definition="An individual who is an applicant of a postsecondary institution.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("92db9eda-b6c0-4515-968a-17a6445a5845"), Code="ELChild", Description="EL Child", Definition="A person for whom instruction, services, and/or care are provided in an early childhood program under the jurisdiction of a school, education agency, or other institution or program.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("7164c4ff-f0ec-44a2-ab90-1228bb70fafe"), Code="ELStaff", Description="EL Staff", Definition="A person who performs specified activities for a public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the early childhood level.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("01c1b881-c473-4188-b794-ddcf2b1f8d81"), Code="K12Staff", Description="K12 Staff", Definition="An individual who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the early childhood level through high school completion.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("1bd72b27-b5d7-48f4-9d6d-4dbaf3f8f2c0"), Code="K12Student", Description="K12 Student", Definition="A person for whom instruction, services, and/or care are provided in an elementary or secondary educational program under the jurisdiction of a school, education agency, or other institution or program.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("eab3da8e-03b9-4c6e-b2b6-bacdeb072254"), Code="ParentGuardian", Description="Parent/Guardian", Definition="A person having parental or legal guardianship responsibility for a learner.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("a2928647-5511-4139-9cdf-55003f45971e"), Code="PSApplicant", Description="PS Applicant", Definition="A person who performs specified activities for any public or private education institution, agency, or household that provides instructional and/or support services to students or staff at the postsecondary level.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("6e1eccb6-8cef-44c7-a4f4-25ddfa144cd0"), Code="PSStaff", Description="PS Staff", Definition="An individual who is a prospect, applicant, admitted student, enrolled student, or alum of a postsecondary institution.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("8ec65471-98df-4c16-a03d-d07a254a7b6f"), Code="PSStudent", Description="PS Student", Definition="", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("843f6590-08f8-41f9-bdd0-8541d7c76c76"), Code="WorkforceProgramParticipant", Description="Workforce Program Participant", Definition="A person who is employed by an Adult Education program.", SortOrder=Convert.ToDecimal("13.00") },
        };
        #endregion
    }
}
