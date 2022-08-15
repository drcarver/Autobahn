//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaFederalReportingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaFederalReportingViewModel
     /// </summary>
    public partial class K12LeaFederalReportingViewModel : ViewModelBase, Interfaces.IK12LeaFederalReporting
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaFederalReporting";

        // member variable for the DesegregationOrderOrPlan property
        private System.Boolean? _DesegregationOrderOrPlan;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaFederalReportingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication whether the LEA is covered by a desegregation plan either ordered by a court or entered into with the Office for Civil Rights under Title VI of the Civil Rights Act of 1964.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19080">Desegregation Order or Plan</a>
        /// </para>
        /// </summary>
        [DisplayName("Desegregation Order or Plan")]
        public System.Boolean? DesegregationOrderOrPlan { get => _DesegregationOrderOrPlan; set => SetProperty(ref _DesegregationOrderOrPlan, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaFederalReporting model)
        {
            IsBusy = true;
            Id = model.Id;
            DesegregationOrderOrPlan = model.DesegregationOrderOrPlan; // Desegregation Order or Plan
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
