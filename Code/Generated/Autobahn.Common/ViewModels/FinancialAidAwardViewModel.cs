//**********************************************************
//* DomainName: Common Models
//* FileName:   FinancialAidAwardViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The FinancialAidAward View Model
     /// </summary>
    public partial class FinancialAidAwardViewModel : ViewModelBase, Interfaces.IFinancialAidAward
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAidAward";

        // FinancialAidAwardAmount -- (backing property for Financial Aid Award Amount)
        private System.Decimal? _FinancialAidAwardAmount;

        // FinancialAidYearDesignator -- (backing property for Financial Aid Year Designator)
        private System.String _FinancialAidYearDesignator;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefFinancialAidAwardTypeId -- (backing property for Financial Aid Award Type)
        private Guid? _RefFinancialAidAwardTypeId;

        // RefFinancialAidStatusId -- (backing property for Financial Aid Award Status)
        private Guid? _RefFinancialAidStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Financial Aid Award Amount
        /// <para>
        /// The amount of financial aid awarded to a person for the term/year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19112">Financial Aid Award Amount</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? FinancialAidAwardAmount { get => _FinancialAidAwardAmount; set => SetProperty(ref _FinancialAidAwardAmount, value); }

        /// <summary>
        /// Financial Aid Year Designator
        /// <para>
        /// The school year for which the student's financial aid application and award data apply.  Generally, this is the 12-month period from July 1 to June 30.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20590">Financial Aid Year Designator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String FinancialAidYearDesignator { get => _FinancialAidYearDesignator; set => SetProperty(ref _FinancialAidYearDesignator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Financial Aid Award Type
        /// <para>
        /// The classification of financial aid awarded to a person for the academic term/year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19113">Financial Aid Award Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFinancialAidAwardTypeId { get => _RefFinancialAidAwardTypeId; set => SetProperty(ref _RefFinancialAidAwardTypeId, value); }

        /// <summary>
        /// Financial Aid Award Status
        /// <para>
        /// An indication of whether the financial aid type being reported is aid that has been awarded, accepted or dispersed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19362">Financial Aid Award Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFinancialAidStatusId { get => _RefFinancialAidStatusId; set => SetProperty(ref _RefFinancialAidStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAidAward model)
        {
            IsBusy = true;
            Id = model.Id;
            FinancialAidAwardAmount = model.FinancialAidAwardAmount; // Financial Aid Award Amount
            FinancialAidYearDesignator = model.FinancialAidYearDesignator; // Financial Aid Year Designator
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefFinancialAidAwardTypeId = model.RefFinancialAidAwardTypeId; // Financial Aid Award Type
            RefFinancialAidStatusId = model.RefFinancialAidStatusId; // Financial Aid Award Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
