//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaGradeOfferedViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaGradeOffered View Model
     /// </summary>
    public partial class K12LeaGradeOfferedViewModel : ViewModelBase, Interfaces.IK12LeaGradeOffered
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaGradeOffered";

        // member variable for the K12LeaId property
        private Guid _K12LeaId;

        // RefGradeLevelId -- (backing property for Grades Offered)
        private Guid _RefGradeLevelId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get => _K12LeaId; set => SetProperty(ref _K12LeaId, value); }

        /// <summary>
        /// Grades Offered
        /// <para>
        /// The specific grade or combination of grades offered by an education institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19131">Grades Offered</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefGradeLevelId { get => _RefGradeLevelId; set => SetProperty(ref _RefGradeLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaGradeOffered model)
        {
            IsBusy = true;
            Id = model.Id;
            K12LeaId = model.K12LeaId; // 
            RefGradeLevelId = model.RefGradeLevelId; // Grades Offered
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
