//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildIndividualizedProgramViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildIndividualizedProgram View Model
     /// </summary>
    public partial class ELChildIndividualizedProgramViewModel : ViewModelBase, Interfaces.IELChildIndividualizedProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildIndividualizedProgram";

        // member variable for the IndividualizedProgramId property
        private Guid? _IndividualizedProgramId;

        // member variable for the PersonId property
        private Guid _PersonId;

        // RefIDEAIEPStatusId -- (backing property for IDEA IEP Status)
        private Guid? _RefIDEAIEPStatusId;

        // RefIDEAPartCEligibilityCategoryId -- (backing property for IDEA Part C Eligibility Category)
        private Guid? _RefIDEAPartCEligibilityCategoryId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid? IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// IDEA IEP Status
        /// <para>
        /// The status of an individualized services plan for a specified reporting period or on a specified date.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20473">IDEA IEP Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIDEAIEPStatusId { get => _RefIDEAIEPStatusId; set => SetProperty(ref _RefIDEAIEPStatusId, value); }

        /// <summary>
        /// IDEA Part C Eligibility Category
        /// <para>
        /// The category under which a person under 3 years of age is eligible for early intervention services under IDEA Part C.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20637">IDEA Part C Eligibility Category</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIDEAPartCEligibilityCategoryId { get => _RefIDEAPartCEligibilityCategoryId; set => SetProperty(ref _RefIDEAPartCEligibilityCategoryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildIndividualizedProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId; // 
            PersonId = model.PersonId; // 
            RefIDEAIEPStatusId = model.RefIDEAIEPStatusId; // IDEA IEP Status
            RefIDEAPartCEligibilityCategoryId = model.RefIDEAPartCEligibilityCategoryId; // IDEA Part C Eligibility Category
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
