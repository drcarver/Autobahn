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
            new ReferenceModelBase { Id=Guid.Parse("e2d63b88-6b73-49d2-b386-242ea28a4534"), Code="1", Description="Educational Testing Service (ETS)", Definition="Educational Testing Service (ETS) is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("6c2670bd-8a12-4bc6-9234-d72bedf07721"), Code="2", Description="Evaluation Systems Group of Pearson", Definition="Evaluation Systems Group of Pearson is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("e8b546cf-38df-4483-aa18-9c8cff2fbbba"), Code="3", Description="College Board", Definition="College Board is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("e5f0e4a3-ee64-402c-a101-8e52049d6a32"), Code="4", Description="American Board for Certification of Teacher Excellence (ABCTE)", Definition="American Board for Certification of Teacher Excellence (ABCTE) is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("c963ab19-c80e-4c35-8c74-b56dd04c3365"), Code="5", Description="American Council on the Teaching of Foreign Languages (ACTFL)", Definition="American Council on the Teaching of Foreign Languages (ACTFL) is the company that provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("b7c12e86-65a6-424e-9a9b-0a06cbdbdf93"), Code="98", Description="State", Definition="The state provides the examination used in the teacher education program.", SortOrder=Convert.ToDecimal("98.00") },
            new ReferenceModelBase { Id=Guid.Parse("a3b27b3e-5609-4c56-b1a9-151231a287f0"), Code="99", Description="Other", Definition="The company that provides the examination used in the teacher education program is not yet included in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };
        #endregion
    }
}
