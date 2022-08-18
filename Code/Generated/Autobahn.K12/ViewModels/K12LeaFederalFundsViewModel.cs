//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaFederalFundsViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaFederalFunds View Model
     /// </summary>
    public partial class K12LeaFederalFundsViewModel : ViewModelBase, Interfaces.IK12LeaFederalFunds
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaFederalFunds";

        // InnovativeDollarsSpent -- (backing property for Innovative Dollars Spent)
        private System.Decimal? _InnovativeDollarsSpent;

        // InnovativeDollarsSpentOnStrategicPriorities -- (backing property for Innovative Dollars Spent on Strategic Priorities)
        private System.Decimal? _InnovativeDollarsSpentOnStrategicPriorities;

        // InnovativeProgramsFundsReceived -- (backing property for Innovative Programs Funds Received)
        private System.Decimal? _InnovativeProgramsFundsReceived;

        // member variable for the OrganizationCalendarSessionId property
        private Guid _OrganizationCalendarSessionId;

        // member variable for the ParentalInvolvementReservationFunds property
        private System.Decimal? _ParentalInvolvementReservationFunds;

        // PublicSchoolChoiceFundsSpent -- (backing property for Public School Choice Funds Spent)
        private System.Decimal? _PublicSchoolChoiceFundsSpent;

        // RefRlisProgramUseId -- (backing property for Type of Use of the Rural Low-Income Schools Program)
        private Guid? _RefRlisProgramUseId;

        // SesFundsSpent -- (backing property for Supplemental Educational Services Funds Spent)
        private System.Decimal? _SesFundsSpent;

        // SesSchoolChoice20PercentObligation -- (backing property for Supplemental Education Services Public School Choice Twenty Percent Obligation)
        private System.Decimal? _SesSchoolChoice20PercentObligation;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Innovative Dollars Spent
        /// <para>
        /// The total Title V, Part A funds expended by LEAs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19451">Innovative Dollars Spent</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? InnovativeDollarsSpent { get => _InnovativeDollarsSpent; set => SetProperty(ref _InnovativeDollarsSpent, value); }

        /// <summary>
        /// Innovative Dollars Spent on Strategic Priorities
        /// <para>
        /// The total amount of Title V, Part A funds expended by LEAs for the four strategic priorities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19452">Innovative Dollars Spent on Strategic Priorities</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? InnovativeDollarsSpentOnStrategicPriorities { get => _InnovativeDollarsSpentOnStrategicPriorities; set => SetProperty(ref _InnovativeDollarsSpentOnStrategicPriorities, value); }

        /// <summary>
        /// Innovative Programs Funds Received
        /// <para>
        /// The total Title V, Part A funds received by LEAs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19454">Innovative Programs Funds Received</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? InnovativeProgramsFundsReceived { get => _InnovativeProgramsFundsReceived; set => SetProperty(ref _InnovativeProgramsFundsReceived, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationCalendarSession"/> model
        /// </summary>
        public Guid OrganizationCalendarSessionId { get => _OrganizationCalendarSessionId; set => SetProperty(ref _OrganizationCalendarSessionId, value); }

        public System.Decimal? ParentalInvolvementReservationFunds { get => _ParentalInvolvementReservationFunds; set => SetProperty(ref _ParentalInvolvementReservationFunds, value); }

        /// <summary>
        /// Public School Choice Funds Spent
        /// <para>
        /// The dollar amount spent on transportation for public school choice during the school year under Title I of ESEA as amended, Part A, Section 1116.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19560">Public School Choice Funds Spent</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? PublicSchoolChoiceFundsSpent { get => _PublicSchoolChoiceFundsSpent; set => SetProperty(ref _PublicSchoolChoiceFundsSpent, value); }

        /// <summary>
        /// Type of Use of the Rural Low-Income Schools Program
        /// <para>
        /// The type of use of the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19477">Type of Use of the Rural Low-Income Schools Program</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefRlisProgramUseId { get => _RefRlisProgramUseId; set => SetProperty(ref _RefRlisProgramUseId, value); }

        /// <summary>
        /// Supplemental Educational Services Funds Spent
        /// <para>
        /// The dollar amount spent on supplemental educational services during the school year under Title I, Part A, Section 1116 of ESEA as amended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19559">Supplemental Educational Services Funds Spent</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? SesFundsSpent { get => _SesFundsSpent; set => SetProperty(ref _SesFundsSpent, value); }

        /// <summary>
        /// Supplemental Education Services Public School Choice Twenty Percent Obligation
        /// <para>
        /// The dollar amount of the 20 percent reservation for supplemental educational services and choice-related transportation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19566">Supplemental Education Services Public School Choice Twenty Percent Obligation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? SesSchoolChoice20PercentObligation { get => _SesSchoolChoice20PercentObligation; set => SetProperty(ref _SesSchoolChoice20PercentObligation, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaFederalFunds model)
        {
            IsBusy = true;
            Id = model.Id;
            InnovativeDollarsSpent = model.InnovativeDollarsSpent; // Innovative Dollars Spent
            InnovativeDollarsSpentOnStrategicPriorities = model.InnovativeDollarsSpentOnStrategicPriorities; // Innovative Dollars Spent on Strategic Priorities
            InnovativeProgramsFundsReceived = model.InnovativeProgramsFundsReceived; // Innovative Programs Funds Received
            OrganizationCalendarSessionId = model.OrganizationCalendarSessionId; // 
            ParentalInvolvementReservationFunds = model.ParentalInvolvementReservationFunds; // 
            PublicSchoolChoiceFundsSpent = model.PublicSchoolChoiceFundsSpent; // Public School Choice Funds Spent
            RefRlisProgramUseId = model.RefRlisProgramUseId; // Type of Use of the Rural Low-Income Schools Program
            SesFundsSpent = model.SesFundsSpent; // Supplemental Educational Services Funds Spent
            SesSchoolChoice20PercentObligation = model.SesSchoolChoice20PercentObligation; // Supplemental Education Services Public School Choice Twenty Percent Obligation
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefRlisProgramUse List
        /// <summary>
        /// The complete <see cref="RefRlisProgramUse"> List
        /// </summary>
        private static List<ReferenceModelBase> RefRlisProgramUseList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("f64fa429-f218-4576-a8dc-e9a6fbcc05e9"), Code="01", Description="Teacher recruitment and retention", Definition="Teacher recruitment and retention, including the use of signing bonuses and other financial incentives", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("2b9d3e2e-b06c-4f3a-953f-82327bbea205"), Code="02", Description="Teacher professional development", Definition="Teacher professional development, including programs that train teachers to utilize technology to improve teaching and to train special needs teachers", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("be55e421-60d8-4c5f-9eca-42191319191e"), Code="03", Description="Educational technology", Definition="Educational technology, including software and hardware as described in Title II, Part D", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("2c5dfc44-b1b6-4c42-aa75-4f0d1f4ab6a7"), Code="04", Description="Parental involvement activities", Definition="Parental involvement activities uses of the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("b6312a27-d291-43b3-a4c8-1a1b4f54502d"), Code="05", Description="Activities authorized under the Safe and Drug-Free Schools Program (Title IV, Part A)", Definition="Activities authorized under the Safe and Drug-Free Schools Program (Title IV, Part A) using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("11a0378a-1d38-4a17-adc8-3f97f28f3fe8"), Code="06", Description="Activities authorized under Title I, Part A", Definition="Activities authorized under Title I, Part A using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("e359bd8b-d741-411e-8cac-706b929b2c1a"), Code="07", Description="Activities authorized under Title III (Language instruction for English Learner and immigrant students)", Definition="Activities authorized under Title III (Language instruction for English Learner and immigrant students) using the Rural Low-Income Schools Program (RLIS) (Title VI, Part B, Subpart 2) Grant Funds.", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion
    }
}
