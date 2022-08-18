//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IEPPresentLevelViewModel.cs
//* Name:       IEP Present Level Academic Description
//* Definition: How the child's disability affects the child's academic achievement.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// How the child's disability affects the child's academic achievement.
     /// </summary>
    public partial class IEPPresentLevelViewModel : ViewModelBase, Interfaces.IIEPPresentLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IEPPresentLevel";

        // AcademicDescription -- (backing property for IEP Present Level Academic Description)
        private System.String _AcademicDescription;

        // FunctionalDescription -- (backing property for IEP Present Level Functional Description)
        private System.String _FunctionalDescription;

        // GeneralEducationDescription -- (backing property for IEP Present Level General Education Description)
        private System.String _GeneralEducationDescription;

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // ParentConcernDescription -- (backing property for IEP Present Level Parent Concern Description)
        private System.String _ParentConcernDescription;

        // PreschoolDescription -- (backing property for IEP Present Level Preschool Description)
        private System.String _PreschoolDescription;

        // StudentConcernDescription -- (backing property for IEP Present Level Student Concern Description)
        private System.String _StudentConcernDescription;

        // StudentStrengthsDescription -- (backing property for IEP Present Level Student Strengths Description)
        private System.String _StudentStrengthsDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// IEP Present Level Academic Description
        /// <para>
        /// How the child's disability affects the child's academic achievement.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20686">IEP Present Level Academic Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AcademicDescription { get => _AcademicDescription; set => SetProperty(ref _AcademicDescription, value); }

        /// <summary>
        /// IEP Present Level Functional Description
        /// <para>
        /// How the child's disability affects the child's functional performance.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20687">IEP Present Level Functional Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FunctionalDescription { get => _FunctionalDescription; set => SetProperty(ref _FunctionalDescription, value); }

        /// <summary>
        /// IEP Present Level General Education Description
        /// <para>
        /// How the child's disability affects the child's involvement and progress in the general education curriculum.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20688">IEP Present Level General Education Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String GeneralEducationDescription { get => _GeneralEducationDescription; set => SetProperty(ref _GeneralEducationDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// IEP Present Level Parent Concern Description
        /// <para>
        /// Parent's explanation of their interest in or concerns about the student's participation in special education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20691">IEP Present Level Parent Concern Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ParentConcernDescription { get => _ParentConcernDescription; set => SetProperty(ref _ParentConcernDescription, value); }

        /// <summary>
        /// IEP Present Level Preschool Description
        /// <para>
        /// For preschool children, as appropriate, how the disability affects the child's participation in appropriate activities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20689">IEP Present Level Preschool Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String PreschoolDescription { get => _PreschoolDescription; set => SetProperty(ref _PreschoolDescription, value); }

        /// <summary>
        /// IEP Present Level Student Concern Description
        /// <para>
        /// Student's explanation of his or her interest in or concerns about participation in special education.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20692">IEP Present Level Student Concern Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String StudentConcernDescription { get => _StudentConcernDescription; set => SetProperty(ref _StudentConcernDescription, value); }

        /// <summary>
        /// IEP Present Level Student Strengths Description
        /// <para>
        /// Explanation of perceived strengths and abilities of the student.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20690">IEP Present Level Student Strengths Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String StudentStrengthsDescription { get => _StudentStrengthsDescription; set => SetProperty(ref _StudentStrengthsDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIEPPresentLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicDescription = model.AcademicDescription; // IEP Present Level Academic Description
            FunctionalDescription = model.FunctionalDescription; // IEP Present Level Functional Description
            GeneralEducationDescription = model.GeneralEducationDescription; // IEP Present Level General Education Description
            IndividualizedProgramId = model.IndividualizedProgramId; // 
            ParentConcernDescription = model.ParentConcernDescription; // IEP Present Level Parent Concern Description
            PreschoolDescription = model.PreschoolDescription; // IEP Present Level Preschool Description
            StudentConcernDescription = model.StudentConcernDescription; // IEP Present Level Student Concern Description
            StudentStrengthsDescription = model.StudentStrengthsDescription; // IEP Present Level Student Strengths Description
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
