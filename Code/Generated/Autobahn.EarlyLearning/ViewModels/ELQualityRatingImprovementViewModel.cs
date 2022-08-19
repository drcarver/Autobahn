//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELQualityRatingImprovementViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELQualityRatingImprovement View Model
     /// </summary>
    public partial class ELQualityRatingImprovementViewModel : ViewModelBase, Interfaces.IELQualityRatingImprovement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELQualityRatingImprovement";

        // NumberQrisLevels -- (backing property for Number of Quality Rating and Improvement System Levels)
        private System.Int32? _NumberQrisLevels;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // QrisAwardDate -- (backing property for Quality Rating and Improvement System Award Date)
        private System.DateTime? _QrisAwardDate;

        // QRISExpirationDate -- (backing property for Quality Rating and Improvement System Expiration Date)
        private System.DateTime? _QRISExpirationDate;

        // QrisScore -- (backing property for Quality Rating and Improvement System Score)
        private System.String _QrisScore;

        // RefQrisParticipationId -- (backing property for Quality Rating and Improvement System Participation)
        private Guid? _RefQrisParticipationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Number of Quality Rating and Improvement System Levels
        /// <para>
        /// Number of quality levels in the Quality Rating and Improvement System (QRIS).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19843">Number of Quality Rating and Improvement System Levels</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? NumberQrisLevels { get => _NumberQrisLevels; set => SetProperty(ref _NumberQrisLevels, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Quality Rating and Improvement System Award Date
        /// <para>
        /// Date Quality Rating and Improvement System score, level or rating was awarded.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19830">Quality Rating and Improvement System Award Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? QrisAwardDate { get => _QrisAwardDate; set => SetProperty(ref _QrisAwardDate, value); }

        /// <summary>
        /// Quality Rating and Improvement System Expiration Date
        /// <para>
        /// Date Quality Rating and Improvement System score, level or rating expires.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19831">Quality Rating and Improvement System Expiration Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? QRISExpirationDate { get => _QRISExpirationDate; set => SetProperty(ref _QRISExpirationDate, value); }

        /// <summary>
        /// Quality Rating and Improvement System Score
        /// <para>
        /// The score, rating or level received by a program for its Quality Rating and Improvement System (QRIS).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19357">Quality Rating and Improvement System Score</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String QrisScore { get => _QrisScore; set => SetProperty(ref _QrisScore, value); }

        /// <summary>
        /// Quality Rating and Improvement System Participation
        /// <para>
        /// Program site participates in a Quality Rating and Improvement System (QRIS).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19356">Quality Rating and Improvement System Participation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefQrisParticipationId { get => _RefQrisParticipationId; set => SetProperty(ref _RefQrisParticipationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELQualityRatingImprovement model)
        {
            IsBusy = true;
            Id = model.Id;
            NumberQrisLevels = model.NumberQrisLevels; // Number of Quality Rating and Improvement System Levels
            OrganizationId = model.OrganizationId; // 
            QrisAwardDate = model.QrisAwardDate; // Quality Rating and Improvement System Award Date
            QRISExpirationDate = model.QRISExpirationDate; // Quality Rating and Improvement System Expiration Date
            QrisScore = model.QrisScore; // Quality Rating and Improvement System Score
            RefQrisParticipationId = model.RefQrisParticipationId; // Quality Rating and Improvement System Participation
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefQrisParticipation List
        /// <summary>
        /// The complete <see cref="RefQrisParticipation"> List
        /// </summary>
        private static List<ReferenceModelBase> RefQrisParticipationList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("40e6937c-557a-41c8-bda6-0f0e77c18d0e"), Code="Yes", Description="Yes", Definition="Yes: Provider does participate in the QRIS", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("72079317-5111-4d58-bef9-e6722b88c1b3"), Code="No", Description="No", Definition="No: Provider is eligible, but does not participate in the QRIS", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("7fa7597e-4d7a-42a0-831a-f07caae4e5f0"), Code="NotEligible", Description="Not Eligible", Definition="The State has an operating QRIS in the provider's area, but the provider is not eligible to participate", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("e61a6fc4-9746-4a6c-8807-e67bf0c1e86c"), Code="NoOperatingQRIS", Description="No Operating QRIS", Definition="The State does not have an operating QRIS in the provider's area", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("4d281b54-3d41-4606-a0ec-1b09b3327143"), Code="InformationUnavailable", Description="Information Unavailable", Definition="The State has an operating QRIS in the provider's area, but information is currently unavailable at the provider level", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion
    }
}
