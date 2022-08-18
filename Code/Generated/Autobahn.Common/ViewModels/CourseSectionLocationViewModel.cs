//**********************************************************
//* DomainName: Common Models
//* FileName:   CourseSectionLocationViewModel.cs
//* Name:       Classroom Identifier
//* Definition: A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
     /// </summary>
    public partial class CourseSectionLocationViewModel : ViewModelBase, Interfaces.ICourseSectionLocation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSectionLocation";

        // ClassroomId -- (backing property for Classroom Identifier)
        private Guid _ClassroomId;

        // member variable for the CourseSectionId property
        private Guid _CourseSectionId;

        // RefInstructionLocationTypeId -- (backing property for Receiving Location of Instruction)
        private Guid? _RefInstructionLocationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Classroom Identifier
        /// <para>
        /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19507">Classroom Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid ClassroomId { get => _ClassroomId; set => SetProperty(ref _ClassroomId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourseSection"/> model
        /// </summary>
        public Guid CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

        /// <summary>
        /// Receiving Location of Instruction
        /// <para>
        /// The type of location at which instruction or service takes place.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19515">Receiving Location of Instruction</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefInstructionLocationTypeId { get => _RefInstructionLocationTypeId; set => SetProperty(ref _RefInstructionLocationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSectionLocation model)
        {
            IsBusy = true;
            Id = model.Id;
            ClassroomId = model.ClassroomId; // Classroom Identifier
            CourseSectionId = model.CourseSectionId; // 
            RefInstructionLocationTypeId = model.RefInstructionLocationTypeId; // Receiving Location of Instruction
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
