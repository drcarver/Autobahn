//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELClassSectionViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELClassSection View Model
     /// </summary>
    public partial class ELClassSectionViewModel : ViewModelBase, Interfaces.IELClassSection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELClassSection";

        // DaysAvailablePerWeek -- (backing property for Days Available Per Week)
        private System.Int32? _DaysAvailablePerWeek;

        // ELProgramAnnualOperatingWeeks -- (backing property for Early Learning Program Annual Operating Weeks)
        private System.Int32? _ELProgramAnnualOperatingWeeks;

        // GroupSize -- (backing property for Early Learning Group Size)
        private System.Int32? _GroupSize;

        // HoursAvailablePerDay -- (backing property for Hours Available Per Day)
        private System.Decimal? _HoursAvailablePerDay;

        // LanguageTranslationPolicy -- (backing property for Language Translation Policy)
        private System.Boolean? _LanguageTranslationPolicy;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefEnvironmentSettingId -- (backing property for Early Childhood Setting)
        private Guid? _RefEnvironmentSettingId;

        // RefServiceOptionId -- (backing property for Service Option Variation)
        private Guid? _RefServiceOptionId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Days Available Per Week
        /// <para>
        /// The number of days per week the site or classroom is open for children to attend.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19354">Days Available Per Week</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? DaysAvailablePerWeek { get => _DaysAvailablePerWeek; set => SetProperty(ref _DaysAvailablePerWeek, value); }

        /// <summary>
        /// Early Learning Program Annual Operating Weeks
        /// <para>
        /// The number of operating weeks per year for an early learning program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19824">Early Learning Program Annual Operating Weeks</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? ELProgramAnnualOperatingWeeks { get => _ELProgramAnnualOperatingWeeks; set => SetProperty(ref _ELProgramAnnualOperatingWeeks, value); }

        /// <summary>
        /// Early Learning Group Size
        /// <para>
        /// The number of slots/spaces available.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20295">Early Learning Group Size</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? GroupSize { get => _GroupSize; set => SetProperty(ref _GroupSize, value); }

        /// <summary>
        /// Hours Available Per Day
        /// <para>
        /// The number of hours per day the site or classroom is open for children to attend.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19353">Hours Available Per Day</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? HoursAvailablePerDay { get => _HoursAvailablePerDay; set => SetProperty(ref _HoursAvailablePerDay, value); }

        /// <summary>
        /// Language Translation Policy
        /// <para>
        /// Indicates that the organization or class/group has  translation services available .
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20190">Language Translation Policy</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? LanguageTranslationPolicy { get => _LanguageTranslationPolicy; set => SetProperty(ref _LanguageTranslationPolicy, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Early Childhood Setting
        /// <para>
        /// The site or setting in which  early childhood care, education, and/or services are provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19355">Early Childhood Setting</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefEnvironmentSettingId { get => _RefEnvironmentSettingId; set => SetProperty(ref _RefEnvironmentSettingId, value); }

        /// <summary>
        /// Service Option Variation
        /// <para>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19352">Service Option Variation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefServiceOptionId { get => _RefServiceOptionId; set => SetProperty(ref _RefServiceOptionId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELClassSection model)
        {
            IsBusy = true;
            Id = model.Id;
            DaysAvailablePerWeek = model.DaysAvailablePerWeek; // Days Available Per Week
            ELProgramAnnualOperatingWeeks = model.ELProgramAnnualOperatingWeeks; // Early Learning Program Annual Operating Weeks
            GroupSize = model.GroupSize; // Early Learning Group Size
            HoursAvailablePerDay = model.HoursAvailablePerDay; // Hours Available Per Day
            LanguageTranslationPolicy = model.LanguageTranslationPolicy; // Language Translation Policy
            OrganizationId = model.OrganizationId; // 
            RefEnvironmentSettingId = model.RefEnvironmentSettingId; // Early Childhood Setting
            RefServiceOptionId = model.RefServiceOptionId; // Service Option Variation
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefServiceOption List
        /// <summary>
        /// The complete <see cref="RefServiceOption"> List
        /// </summary>
        private static List<ReferenceModelBase> RefServiceOptionList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("ae9941ba-b9ca-4c49-8bd2-51b13fb68135"), Code="FullDayFullYear", Description="Full-day/full-year", Definition="Full-day/full-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("eeed6a0f-5940-4a3d-9aac-8e97100be4a0"), Code="FullDayPartYear", Description="Full-day/part-year", Definition="Full-day/part-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("379f6f92-dc63-4555-8fd5-ff0fc51f17a9"), Code="PartDayFullYear", Description="Part-day/full-year", Definition="Part-day/full-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("ed45f545-1649-4d88-ab66-092c6a47cad9"), Code="PartDayPartYear", Description="Part-day/part-year", Definition="Part-day/part-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("425451b4-1a3d-41d2-9968-aa5871f0a98d"), Code="HomeBased", Description="Home based", Definition="Home based is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("be10df6a-38d4-41df-81e6-1f9151901b73"), Code="NA", Description="Not applicable", Definition="The nature of the early childhood program, class or group in which a person is enrolled is not applicable.", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion
    }
}
