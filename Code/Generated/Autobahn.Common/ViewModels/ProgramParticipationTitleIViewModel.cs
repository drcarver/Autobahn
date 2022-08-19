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
            new ReferenceModelBase { Id=Guid.Parse("6ce2a107-191d-428d-b255-72d536304f2c"), Code="01", Description="Public Targeted Assistance Program", Definition="Public Targeted Assistance Program", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("27e11082-f7d9-4585-9221-3f204c1985e2"), Code="02", Description="Public Schoolwide Program", Definition="Public Schoolwide Program", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("a6c38c38-1994-4781-aae8-e80d4b00cba2"), Code="03", Description="Private school students participating", Definition="Private school students participating", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("ed7c177c-e2af-4a0b-b67b-82a542db207f"), Code="04", Description="Local Neglected Program", Definition="Local Neglected Program", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("914c7c98-833c-4a9e-a5ad-07155144fb43"), Code="05", Description="Was not served", Definition="Was not served", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion
    }
}
