//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildOutcomeSummaryViewModel.cs
//* Name:       Child Outcomes Summary Progress A Indicator
//* Definition: Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
     /// </summary>
    public partial class ELChildOutcomeSummaryViewModel : ViewModelBase, Interfaces.IELChildOutcomeSummary
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildOutcomeSummary";

        // COSProgressAIndicator -- (backing property for Child Outcomes Summary Progress A Indicator)
        private System.Boolean? _COSProgressAIndicator;

        // COSProgressBIndicator -- (backing property for Child Outcomes Summary Progress B Indicator)
        private System.Boolean? _COSProgressBIndicator;

        // COSProgressCIndicator -- (backing property for Child Outcomes Summary Progress C Indicator)
        private System.Boolean? _COSProgressCIndicator;

        // COSRatingAId -- (backing property for Child Outcomes Summary Rating A)
        private Guid? _COSRatingAId;

        // COSRatingBId -- (backing property for Child Outcomes Summary Rating B)
        private Guid? _COSRatingBId;

        // COSRatingCId -- (backing property for Child Outcomes Summary Rating C)
        private Guid? _COSRatingCId;

        // member variable for the PersonId property
        private Guid _PersonId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Child Outcomes Summary Progress A Indicator
        /// <para>
        /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20476">Child Outcomes Summary Progress A Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? COSProgressAIndicator { get => _COSProgressAIndicator; set => SetProperty(ref _COSProgressAIndicator, value); }

        /// <summary>
        /// Child Outcomes Summary Progress B Indicator
        /// <para>
        /// Indicates that the child demonstrates progress in acquisition and use of knowledge and skills, including early language/communication.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20477">Child Outcomes Summary Progress B Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? COSProgressBIndicator { get => _COSProgressBIndicator; set => SetProperty(ref _COSProgressBIndicator, value); }

        /// <summary>
        /// Child Outcomes Summary Progress C Indicator
        /// <para>
        /// Indicates that the child demonstrates progress in use of appropriate behaviors to meet their needs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20478">Child Outcomes Summary Progress C Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? COSProgressCIndicator { get => _COSProgressCIndicator; set => SetProperty(ref _COSProgressCIndicator, value); }

        /// <summary>
        /// Child Outcomes Summary Rating A
        /// <para>
        /// Child's level of functioning in positive social-emotional skills (including social relationships).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20479">Child Outcomes Summary Rating A</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? COSRatingAId { get => _COSRatingAId; set => SetProperty(ref _COSRatingAId, value); }

        /// <summary>
        /// Child Outcomes Summary Rating B
        /// <para>
        /// Child's level of functioning in the acquisition and use of knowledge and skills (including early language/communication.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20480">Child Outcomes Summary Rating B</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? COSRatingBId { get => _COSRatingBId; set => SetProperty(ref _COSRatingBId, value); }

        /// <summary>
        /// Child Outcomes Summary Rating C
        /// <para>
        /// Child's level of functioning in the use of appropriate behaviors to meet their needs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20481">Child Outcomes Summary Rating C</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? COSRatingCId { get => _COSRatingCId; set => SetProperty(ref _COSRatingCId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildOutcomeSummary model)
        {
            IsBusy = true;
            Id = model.Id;
            COSProgressAIndicator = model.COSProgressAIndicator; // Child Outcomes Summary Progress A Indicator
            COSProgressBIndicator = model.COSProgressBIndicator; // Child Outcomes Summary Progress B Indicator
            COSProgressCIndicator = model.COSProgressCIndicator; // Child Outcomes Summary Progress C Indicator
            COSRatingAId = model.COSRatingAId; // Child Outcomes Summary Rating A
            COSRatingBId = model.COSRatingBId; // Child Outcomes Summary Rating B
            COSRatingCId = model.COSRatingCId; // Child Outcomes Summary Rating C
            PersonId = model.PersonId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
