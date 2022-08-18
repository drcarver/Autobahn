//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELClassSectionServiceViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELClassSectionService View Model
     /// </summary>
    public partial class ELClassSectionServiceViewModel : ViewModelBase, Interfaces.IELClassSectionService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELClassSectionService";

        // ELClassGroupCurriculumType -- (backing property for Early Learning Class Group Curriculum Type)
        private System.String _ELClassGroupCurriculumType;

        // member variable for the ELClassSectionId property
        private Guid _ELClassSectionId;

        // OldestAgeServed -- (backing property for Early Learning Oldest Age Authorized to Serve)
        private System.Int32? _OldestAgeServed;

        // RefELGroupSizeStandardMetId -- (backing property for Early Learning Group Size Standards Met)
        private Guid? _RefELGroupSizeStandardMetId;

        // RefFrequencyOfServiceId -- (backing property for Frequency of Service)
        private Guid? _RefFrequencyOfServiceId;

        // ServesChildrenWithSpecialNeeds -- (backing property for Serves Children with Special Needs)
        private System.Boolean? _ServesChildrenWithSpecialNeeds;

        // YoungestAgeServed -- (backing property for Early Learning Youngest Age Authorized to Serve)
        private System.Int32? _YoungestAgeServed;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Early Learning Class Group Curriculum Type
        /// <para>
        /// The type of curriculum used in an early learning classroom or group.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19822">Early Learning Class Group Curriculum Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ELClassGroupCurriculumType { get => _ELClassGroupCurriculumType; set => SetProperty(ref _ELClassGroupCurriculumType, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IELClassSection"/> model
        /// </summary>
        public Guid ELClassSectionId { get => _ELClassSectionId; set => SetProperty(ref _ELClassSectionId, value); }

        /// <summary>
        /// Early Learning Oldest Age Authorized to Serve
        /// <para>
        /// The oldest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20189">Early Learning Oldest Age Authorized to Serve</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? OldestAgeServed { get => _OldestAgeServed; set => SetProperty(ref _OldestAgeServed, value); }

        /// <summary>
        /// Early Learning Group Size Standards Met
        /// <para>
        /// An indication of whether a program meets NAEYC or NAFCC standards for infant group sizes.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19823">Early Learning Group Size Standards Met</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefELGroupSizeStandardMetId { get => _RefELGroupSizeStandardMetId; set => SetProperty(ref _RefELGroupSizeStandardMetId, value); }

        /// <summary>
        /// Frequency of Service
        /// <para>
        /// The frequency at which a service is planned to occur.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20323">Frequency of Service</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFrequencyOfServiceId { get => _RefFrequencyOfServiceId; set => SetProperty(ref _RefFrequencyOfServiceId, value); }

        /// <summary>
        /// Serves Children with Special Needs
        /// <para>
        /// An indication of whether a class or group serves children with special needs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19821">Serves Children with Special Needs</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ServesChildrenWithSpecialNeeds { get => _ServesChildrenWithSpecialNeeds; set => SetProperty(ref _ServesChildrenWithSpecialNeeds, value); }

        /// <summary>
        /// Early Learning Youngest Age Authorized to Serve
        /// <para>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19626">Early Learning Youngest Age Authorized to Serve</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? YoungestAgeServed { get => _YoungestAgeServed; set => SetProperty(ref _YoungestAgeServed, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELClassSectionService model)
        {
            IsBusy = true;
            Id = model.Id;
            ELClassGroupCurriculumType = model.ELClassGroupCurriculumType; // Early Learning Class Group Curriculum Type
            ELClassSectionId = model.ELClassSectionId; // 
            OldestAgeServed = model.OldestAgeServed; // Early Learning Oldest Age Authorized to Serve
            RefELGroupSizeStandardMetId = model.RefELGroupSizeStandardMetId; // Early Learning Group Size Standards Met
            RefFrequencyOfServiceId = model.RefFrequencyOfServiceId; // Frequency of Service
            ServesChildrenWithSpecialNeeds = model.ServesChildrenWithSpecialNeeds; // Serves Children with Special Needs
            YoungestAgeServed = model.YoungestAgeServed; // Early Learning Youngest Age Authorized to Serve
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
