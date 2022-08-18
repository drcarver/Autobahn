//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTechnicalAssistanceViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationTechnicalAssistance View Model
     /// </summary>
    public partial class OrganizationTechnicalAssistanceViewModel : ViewModelBase, Interfaces.IOrganizationTechnicalAssistance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationTechnicalAssistance";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefTechnicalAssistanceDeliveryTypeId -- (backing property for Technical Assistance Delivery Type)
        private Guid? _RefTechnicalAssistanceDeliveryTypeId;

        // RefTechnicalAssistanceTypeId -- (backing property for Technical Assistance Type)
        private Guid? _RefTechnicalAssistanceTypeId;

        // TechnicalAssistanceApprovedInd -- (backing property for Technical Assistance Approved Indicator)
        private System.Boolean? _TechnicalAssistanceApprovedInd;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Technical Assistance Delivery Type
        /// <para>
        /// The method of delivery of technical assistance received/provided
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20466">Technical Assistance Delivery Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTechnicalAssistanceDeliveryTypeId { get => _RefTechnicalAssistanceDeliveryTypeId; set => SetProperty(ref _RefTechnicalAssistanceDeliveryTypeId, value); }

        /// <summary>
        /// Technical Assistance Type
        /// <para>
        /// The type of technical assistance provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20467">Technical Assistance Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTechnicalAssistanceTypeId { get => _RefTechnicalAssistanceTypeId; set => SetProperty(ref _RefTechnicalAssistanceTypeId, value); }

        /// <summary>
        /// Technical Assistance Approved Indicator
        /// <para>
        /// Indicates whether or not the technical assistance was approved.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20465">Technical Assistance Approved Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? TechnicalAssistanceApprovedInd { get => _TechnicalAssistanceApprovedInd; set => SetProperty(ref _TechnicalAssistanceApprovedInd, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationTechnicalAssistance model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            RefTechnicalAssistanceDeliveryTypeId = model.RefTechnicalAssistanceDeliveryTypeId; // Technical Assistance Delivery Type
            RefTechnicalAssistanceTypeId = model.RefTechnicalAssistanceTypeId; // Technical Assistance Type
            TechnicalAssistanceApprovedInd = model.TechnicalAssistanceApprovedInd; // Technical Assistance Approved Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefTechnicalAssistanceType List
        /// <summary>
        /// The complete <see cref="RefTechnicalAssistanceType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTechnicalAssistanceTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("8377baa7-aff6-4a5d-8531-94e76f92f44b"), Code="01", Description="Core Knowledge Area", Definition="Core Knowledge Area is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("f907dee4-4844-4d71-b091-51ff4a61ae7f"), Code="02", Description="Health Safety Technical Assistance", Definition="Health Safety Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("cb4069e5-026d-461b-b135-a87f6af50916"), Code="03", Description="Inclusion Technical Assistance", Definition="Inclusion Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("91bf4227-5f85-4401-a53b-078104a868cd"), Code="04", Description="Infant Toddler Care Technical Assistance", Definition="Infant Toddler Care Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("7fb832a9-1bef-4db2-9491-08b46c64339b"), Code="05", Description="Mental Health Technical Assistance", Definition="Mental Health Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("ff84bbe6-5333-421c-a0dc-759b9758b60c"), Code="06", Description="Program Administration and Management Practices Technical Assistance", Definition="Program Administration and Management Practices Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("fa9e24e3-9d08-4793-b81f-aeabf83ceca3"), Code="07", Description="School Age Technical Assistance", Definition="School Age Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("9f3bf6a9-cbbe-46e4-8225-7393071ac8e5"), Code="08", Description="Understanding Developmental Screening Technical Assistance", Definition="Understanding Developmental Screening Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("e30990fd-a35f-44ef-876e-d632689c51d4"), Code="09", Description="Dual Language Learner Technical Assistance", Definition="Dual Language Learner Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("d4e7cca9-a429-4100-aad2-afc204e92d79"), Code="10", Description="Language and Literacy Development", Definition="Language and Literacy Development is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("35b55db0-b220-4627-88ab-013fbd46e4fd"), Code="11", Description="Cognition and General Knowledge (including early mathematics and early scientific development)", Definition="Cognition and General Knowledge (including early mathematics and early scientific development) is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("519b473a-422c-4313-91d6-4c529408c2a8"), Code="12", Description="Approaches Toward Learning", Definition="Approaches Toward Learning is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("cc3da646-28f5-433e-adab-1a4e408fb10c"), Code="13", Description="Physical Well-being and Motor Development (including adaptive skills)", Definition="Physical Well-being and Motor Development (including adaptive skills) is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("bb9e29fc-7e0c-46ad-8618-a0d8f1c51702"), Code="14", Description="Social and Emotional Development", Definition="Social and Emotional Development is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("28.00") },
        };
        #endregion
    }
}
