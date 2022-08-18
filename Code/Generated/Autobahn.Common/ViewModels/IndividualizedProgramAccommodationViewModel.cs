//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAccommodationViewModel.cs
//* Name:       Individualized Program Accommodation Applicability
//* Definition: Circumstances in which the accommodation or change to standards or practices will be applied.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// Circumstances in which the accommodation or change to standards or practices will be applied.
     /// </summary>
    public partial class IndividualizedProgramAccommodationViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAccommodation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAccommodation";

        // Applicability -- (backing property for Individualized Program Accommodation Applicability)
        private System.String _Applicability;

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // RefAccommodationTypeId -- (backing property for Accommodation Type)
        private Guid? _RefAccommodationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Individualized Program Accommodation Applicability
        /// <para>
        /// Circumstances in which the accommodation or change to standards or practices will be applied.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20667">Individualized Program Accommodation Applicability</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Applicability { get => _Applicability; set => SetProperty(ref _Applicability, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Accommodation Type
        /// <para>
        /// The specific accommodation necessary for assessment or instruction.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19376">Accommodation Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAccommodationTypeId { get => _RefAccommodationTypeId; set => SetProperty(ref _RefAccommodationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAccommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            Applicability = model.Applicability; // Individualized Program Accommodation Applicability
            IndividualizedProgramId = model.IndividualizedProgramId; // 
            RefAccommodationTypeId = model.RefAccommodationTypeId; // Accommodation Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
