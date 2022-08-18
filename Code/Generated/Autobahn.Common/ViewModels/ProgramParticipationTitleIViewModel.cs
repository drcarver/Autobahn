//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationTitleIViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ProgramParticipationTitleI View Model
     /// </summary>
    public partial class ProgramParticipationTitleIViewModel : ViewModelBase, Interfaces.IProgramParticipationTitleI
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationTitleI";

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // RefTitleIIndicatorId -- (backing property for Title I Indicator)
        private Guid? _RefTitleIIndicatorId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Title I Indicator
        /// <para>
        /// An indication that the student is participating in and served by programs under Title I, Part A of ESEA as amended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19281">Title I Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTitleIIndicatorId { get => _RefTitleIIndicatorId; set => SetProperty(ref _RefTitleIIndicatorId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationTitleI model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonProgramParticipationId = model.PersonProgramParticipationId; // 
            RefTitleIIndicatorId = model.RefTitleIIndicatorId; // Title I Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefTitleIIndicator List
        /// <summary>
        /// The complete <see cref="RefTitleIIndicator"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTitleIIndicatorList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("81e9052a-9514-41cf-b73d-e14ce238139c"), Code="01", Description="Public Targeted Assistance Program", Definition="Public Targeted Assistance Program", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("248184b5-0eba-4dc9-9eba-49d49865c211"), Code="02", Description="Public Schoolwide Program", Definition="Public Schoolwide Program", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("e49ae04a-3400-41cc-8bd9-fe3adbf16e18"), Code="03", Description="Private school students participating", Definition="Private school students participating", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("66aa6010-7493-4fce-acf2-0aa20ab51016"), Code="04", Description="Local Neglected Program", Definition="Local Neglected Program", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("62ca313c-60e3-4cf7-8fbe-cf88021a1347"), Code="05", Description="Was not served", Definition="Was not served", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion
    }
}
