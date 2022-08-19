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
            new ReferenceModelBase { Id=Guid.Parse("e0344a9e-0c54-4435-8dab-ad555ca0da4d"), Code="01", Description="Core Knowledge Area", Definition="Core Knowledge Area is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("f69e586e-52ba-4931-aa26-1e2a5de5d7f2"), Code="02", Description="Health Safety Technical Assistance", Definition="Health Safety Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("61375e19-fc9b-401a-a893-4f8e720e4e43"), Code="03", Description="Inclusion Technical Assistance", Definition="Inclusion Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("cd681ff7-aad9-450a-858b-4cd1c0523950"), Code="04", Description="Infant Toddler Care Technical Assistance", Definition="Infant Toddler Care Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("7df342ab-fed2-442c-8467-9923a1c62f20"), Code="05", Description="Mental Health Technical Assistance", Definition="Mental Health Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("fd01466a-408e-49b7-bef1-5ca1a4c5ae13"), Code="06", Description="Program Administration and Management Practices Technical Assistance", Definition="Program Administration and Management Practices Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("bbaec8a8-064b-44de-bd98-53fa1fc6f196"), Code="07", Description="School Age Technical Assistance", Definition="School Age Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("eb2e447a-1613-40fb-acef-4678b00d1482"), Code="08", Description="Understanding Developmental Screening Technical Assistance", Definition="Understanding Developmental Screening Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("7b5c4212-28e0-4e90-be86-f1a4744be6ac"), Code="09", Description="Dual Language Learner Technical Assistance", Definition="Dual Language Learner Technical Assistance is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("ca1ebdc9-e502-4d7c-b103-b26f1d3720db"), Code="10", Description="Language and Literacy Development", Definition="Language and Literacy Development is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("8c467d1b-4d9a-45ae-9ebd-5330a46a5526"), Code="11", Description="Cognition and General Knowledge (including early mathematics and early scientific development)", Definition="Cognition and General Knowledge (including early mathematics and early scientific development) is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("bbec5419-696f-413a-9d88-cee9080cce03"), Code="12", Description="Approaches Toward Learning", Definition="Approaches Toward Learning is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("c76af4f6-e44a-44ee-ac4f-a7faf5d7a954"), Code="13", Description="Physical Well-being and Motor Development (including adaptive skills)", Definition="Physical Well-being and Motor Development (including adaptive skills) is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("76a0139c-4f28-4006-8c9f-f0bdcd1cd07a"), Code="14", Description="Social and Emotional Development", Definition="Social and Emotional Development is the type of technical assistance provided.", SortOrder=Convert.ToDecimal("28.00") },
        };
        #endregion
    }
}
