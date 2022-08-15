//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicRecordViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentAcademicRecordViewModel
     /// </summary>
    public partial class PsStudentAcademicRecordViewModel : ViewModelBase, Interfaces.IPsStudentAcademicRecord
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentAcademicRecord";

        // member variable for the AdvancedPlacementCreditsAwarded property
        private System.Int32? _AdvancedPlacementCreditsAwarded;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentAcademicRecordViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19018">Advanced Placement Credits Awarded</a>
        /// </para>
        /// </summary>
        [DisplayName("Advanced Placement Credits Awarded")]
        public System.Int32? AdvancedPlacementCreditsAwarded { get => _AdvancedPlacementCreditsAwarded; set => SetProperty(ref _AdvancedPlacementCreditsAwarded, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentAcademicRecord model)
        {
            IsBusy = true;
            Id = model.Id;
            AdvancedPlacementCreditsAwarded = model.AdvancedPlacementCreditsAwarded; // Advanced Placement Credits Awarded
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
