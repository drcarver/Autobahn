//**********************************************************
//* DomainName: Common Models
//* FileName:   FinancialAidApplicationViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The FinancialAidApplication View Model
     /// </summary>
    public partial class FinancialAidApplicationViewModel : ViewModelBase, Interfaces.IFinancialAidApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAidApplication";

        // FinancialAidYearDesignator -- (backing property for Financial Aid Year Designator)
        private System.String _FinancialAidYearDesignator;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefFinancialAidApplicationTypeId -- (backing property for Financial Aid Application Type)
        private Guid _RefFinancialAidApplicationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

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
        /// Financial Aid Application Type
        /// <para>
        /// The type of financial application completed by an individual.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20186">Financial Aid Application Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefFinancialAidApplicationTypeId { get => _RefFinancialAidApplicationTypeId; set => SetProperty(ref _RefFinancialAidApplicationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAidApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            FinancialAidYearDesignator = model.FinancialAidYearDesignator; // Financial Aid Year Designator
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefFinancialAidApplicationTypeId = model.RefFinancialAidApplicationTypeId; // Financial Aid Application Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
