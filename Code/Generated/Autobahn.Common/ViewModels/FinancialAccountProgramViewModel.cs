//**********************************************************
//* DomainName: Common Models
//* FileName:   FinancialAccountProgramViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The FinancialAccountProgram View Model
     /// </summary>
    public partial class FinancialAccountProgramViewModel : ViewModelBase, Interfaces.IFinancialAccountProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from FinancialAccountProgram";

        // Name -- (backing property for Financial Account Program Name)
        private System.String _Name;

        // ProgramNumber -- (backing property for Financial Account Program Number)
        private System.String _ProgramNumber;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Financial Account Program Name
        /// <para>
        /// The name given to the program area in an educational institution's accounting system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20626">Financial Account Program Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Financial Account Program Number
        /// <para>
        /// A number given to a program area within an educational institution's accounting system.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20627">Financial Account Program Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ProgramNumber { get => _ProgramNumber; set => SetProperty(ref _ProgramNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IFinancialAccountProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name; // Financial Account Program Name
            ProgramNumber = model.ProgramNumber; // Financial Account Program Number
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
