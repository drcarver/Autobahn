//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDisabilityViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDisability View Model
     /// </summary>
    public partial class PersonDisabilityViewModel : ViewModelBase, Interfaces.IPersonDisability
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDisability";

        // DisabilityStatus -- (backing property for Disability Status)
        private System.Boolean? _DisabilityStatus;

        // member variable for the PersonId property
        private Guid _PersonId;

        // PrimaryDisabilityTypeId -- (backing property for Primary Disability Type)
        private Guid? _PrimaryDisabilityTypeId;

        // RefAccommodationsNeededTypeId -- (backing property for Accommodations Needed Type)
        private Guid? _RefAccommodationsNeededTypeId;

        // RefDisabilityConditionStatusCodeId -- (backing property for Disability Condition Status Type)
        private Guid? _RefDisabilityConditionStatusCodeId;

        // RefDisabilityConditionTypeId -- (backing property for Disability Condition Type)
        private Guid? _RefDisabilityConditionTypeId;

        // RefDisabilityDeterminationSourceTypeId -- (backing property for Disability Determination Source Type)
        private Guid? _RefDisabilityDeterminationSourceTypeId;

        // RefIDEADisabilityTypeId -- (backing property for IDEA Disability Type)
        private Guid? _RefIDEADisabilityTypeId;

        // SignificantCognitiveDisabilityIndicator -- (backing property for Significant Cognitive Disability Indicator)
        private System.Boolean? _SignificantCognitiveDisabilityIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Disability Status
        /// <para>
        /// An indication of whether a person is classified as disabled under the American's with Disability Act (ADA).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19569">Disability Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? DisabilityStatus { get => _DisabilityStatus; set => SetProperty(ref _DisabilityStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Primary Disability Type
        /// <para>
        /// The major or overriding disability condition that best describes a person's impairment.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19218">Primary Disability Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? PrimaryDisabilityTypeId { get => _PrimaryDisabilityTypeId; set => SetProperty(ref _PrimaryDisabilityTypeId, value); }

        /// <summary>
        /// Accommodations Needed Type
        /// <para>
        /// Codes identifying the set of health accommodations.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20243">Accommodations Needed Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAccommodationsNeededTypeId { get => _RefAccommodationsNeededTypeId; set => SetProperty(ref _RefAccommodationsNeededTypeId, value); }

        /// <summary>
        /// Disability Condition Status Type
        /// <para>
        /// A code indicating the disability condition status.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20285">Disability Condition Status Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDisabilityConditionStatusCodeId { get => _RefDisabilityConditionStatusCodeId; set => SetProperty(ref _RefDisabilityConditionStatusCodeId, value); }

        /// <summary>
        /// Disability Condition Type
        /// <para>
        /// Codes identifying the set of disability conditions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20286">Disability Condition Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDisabilityConditionTypeId { get => _RefDisabilityConditionTypeId; set => SetProperty(ref _RefDisabilityConditionTypeId, value); }

        /// <summary>
        /// Disability Determination Source Type
        /// <para>
        /// Codes identifying the set of disability determination sources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20287">Disability Determination Source Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDisabilityDeterminationSourceTypeId { get => _RefDisabilityDeterminationSourceTypeId; set => SetProperty(ref _RefDisabilityDeterminationSourceTypeId, value); }

        /// <summary>
        /// IDEA Disability Type
        /// <para>
        /// A category of disability that describes a person's impairment defined by the Individuals with Disabilities Education Act.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20714">IDEA Disability Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIDEADisabilityTypeId { get => _RefIDEADisabilityTypeId; set => SetProperty(ref _RefIDEADisabilityTypeId, value); }

        /// <summary>
        /// Significant Cognitive Disability Indicator
        /// <para>
        /// Student has an existing IDEA disability with cognitive impairments which may prevent him/her from attaining grade-level achievement standards.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20746">Significant Cognitive Disability Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? SignificantCognitiveDisabilityIndicator { get => _SignificantCognitiveDisabilityIndicator; set => SetProperty(ref _SignificantCognitiveDisabilityIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDisability model)
        {
            IsBusy = true;
            Id = model.Id;
            DisabilityStatus = model.DisabilityStatus; // Disability Status
            PersonId = model.PersonId; // 
            PrimaryDisabilityTypeId = model.PrimaryDisabilityTypeId; // Primary Disability Type
            RefAccommodationsNeededTypeId = model.RefAccommodationsNeededTypeId; // Accommodations Needed Type
            RefDisabilityConditionStatusCodeId = model.RefDisabilityConditionStatusCodeId; // Disability Condition Status Type
            RefDisabilityConditionTypeId = model.RefDisabilityConditionTypeId; // Disability Condition Type
            RefDisabilityDeterminationSourceTypeId = model.RefDisabilityDeterminationSourceTypeId; // Disability Determination Source Type
            RefIDEADisabilityTypeId = model.RefIDEADisabilityTypeId; // IDEA Disability Type
            SignificantCognitiveDisabilityIndicator = model.SignificantCognitiveDisabilityIndicator; // Significant Cognitive Disability Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
