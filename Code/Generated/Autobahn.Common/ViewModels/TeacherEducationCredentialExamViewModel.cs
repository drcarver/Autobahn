//**********************************************************
//* DomainName: Common Models
//* FileName:   TeacherEducationCredentialExamViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The TeacherEducationCredentialExam View Model
     /// </summary>
    public partial class TeacherEducationCredentialExamViewModel : ViewModelBase, Interfaces.ITeacherEducationCredentialExam
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from TeacherEducationCredentialExam";

        // member variable for the ProgramParticipationTeacherPrepId property
        private Guid _ProgramParticipationTeacherPrepId;

        // RefTeacherEducationCredentialExamId -- (backing property for Teacher Education Credential Exam Type)
        private Guid? _RefTeacherEducationCredentialExamId;

        // RefTeacherEducationExamScoreTypeId -- (backing property for Teacher Education Credential Exam Score Type)
        private Guid? _RefTeacherEducationExamScoreTypeId;

        // RefTeacherEducationTestCompanyId -- (backing property for Teacher Education Test Company)
        private Guid? _RefTeacherEducationTestCompanyId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IProgramParticipationTeacherPrep"/> model
        /// </summary>
        public Guid ProgramParticipationTeacherPrepId { get => _ProgramParticipationTeacherPrepId; set => SetProperty(ref _ProgramParticipationTeacherPrepId, value); }

        /// <summary>
        /// Teacher Education Credential Exam Type
        /// <para>
        /// The type of examination used to assess teacher candidate's knowledge and skills.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19756">Teacher Education Credential Exam Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTeacherEducationCredentialExamId { get => _RefTeacherEducationCredentialExamId; set => SetProperty(ref _RefTeacherEducationCredentialExamId, value); }

        /// <summary>
        /// Teacher Education Credential Exam Score Type
        /// <para>
        /// An indication of the type of credential exam associated with a given exam score.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19757">Teacher Education Credential Exam Score Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTeacherEducationExamScoreTypeId { get => _RefTeacherEducationExamScoreTypeId; set => SetProperty(ref _RefTeacherEducationExamScoreTypeId, value); }

        /// <summary>
        /// Teacher Education Test Company
        /// <para>
        /// The name of the company that provides the examination used in the teacher education program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19748">Teacher Education Test Company</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTeacherEducationTestCompanyId { get => _RefTeacherEducationTestCompanyId; set => SetProperty(ref _RefTeacherEducationTestCompanyId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ITeacherEducationCredentialExam model)
        {
            IsBusy = true;
            Id = model.Id;
            ProgramParticipationTeacherPrepId = model.ProgramParticipationTeacherPrepId; // 
            RefTeacherEducationCredentialExamId = model.RefTeacherEducationCredentialExamId; // Teacher Education Credential Exam Type
            RefTeacherEducationExamScoreTypeId = model.RefTeacherEducationExamScoreTypeId; // Teacher Education Credential Exam Score Type
            RefTeacherEducationTestCompanyId = model.RefTeacherEducationTestCompanyId; // Teacher Education Test Company
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefTeacherEducationExamScoreType List
        /// <summary>
        /// The complete <see cref="RefTeacherEducationExamScoreType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTeacherEducationExamScoreTypeList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefTeacherEducationTestCompany List
        /// <summary>
        /// The complete <see cref="RefTeacherEducationTestCompany"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTeacherEducationTestCompanyList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("773378eb-bf8c-41d3-b789-df73da92a2ab"), Code="1", Description="Educational Testing Service (ETS)", Definition="Educational Testing Service (ETS) is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("14702501-c8d5-4088-944f-5c141f14dfe4"), Code="2", Description="Evaluation Systems Group of Pearson", Definition="Evaluation Systems Group of Pearson is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("2a985dcc-ff23-4c2d-b1cb-0d9b2667e3e2"), Code="3", Description="College Board", Definition="College Board is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("4e90ae14-cbb3-46f4-9b03-d0711adecf56"), Code="4", Description="American Board for Certification of Teacher Excellence (ABCTE)", Definition="American Board for Certification of Teacher Excellence (ABCTE) is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("624b2f6a-8390-44b5-a586-fbdc1b04188c"), Code="5", Description="American Council on the Teaching of Foreign Languages (ACTFL)", Definition="American Council on the Teaching of Foreign Languages (ACTFL) is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("569296f8-762e-48ce-a2a3-bd5d09156ad3"), Code="98", Description="State", Definition="The state provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("98.00") },
            new ReferenceModelBase { Id=Guid.Parse("c31bbe74-4632-4fa5-a4cd-a7f6e5fa8b95"), Code="99", Description="Other", Definition="The company that provides the examination used in the teacher education program is not yet included in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };
        #endregion
    }
}
