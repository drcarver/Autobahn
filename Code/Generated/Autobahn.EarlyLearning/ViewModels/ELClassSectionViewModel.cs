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
            new ReferenceModelBase { Id=Guid.Parse("dfec7a46-8d3b-47a1-9e8d-425821a7db77"), Code="FullDayFullYear", Description="Full-day/full-year", Definition="Full-day/full-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("852cd793-6be1-4570-bdd8-c045624ed6b3"), Code="FullDayPartYear", Description="Full-day/part-year", Definition="Full-day/part-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("0891cef6-8ae5-49f1-8eec-005e3342bd48"), Code="PartDayFullYear", Description="Part-day/full-year", Definition="Part-day/full-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("55142275-9133-44a5-8435-fbb69010421c"), Code="PartDayPartYear", Description="Part-day/part-year", Definition="Part-day/part-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("08e1a198-dfd7-46b4-92d0-f07c42262ceb"), Code="HomeBased", Description="Home based", Definition="Home based is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("ad4d06b2-00a2-4c59-85a2-de39c49600c1"), Code="NA", Description="Not applicable", Definition="The nature of the early childhood program, class or group in which a person is enrolled is not applicable.", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion
    }
}
