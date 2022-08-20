//**********************************************************
//* DomainName: Common Models
//* FileName:   ApipInteractionViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ApipInteraction View Model
     /// </summary>
    public partial class ApipInteractionViewModel : ViewModelBase, Interfaces.IApipInteraction
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ApipInteraction";

        // APIPInteractionSequenceNumber -- (backing property for APIP Interaction Sequence Number)
        private System.Decimal? _APIPInteractionSequenceNumber;

        // member variable for the AssessmentItemApipId property
        private Guid _AssessmentItemApipId;

        // RefApipInteractionTypeId -- (backing property for Assessment Item Body Drawing Interaction XML)
        private Guid? _RefApipInteractionTypeId;

        // member variable for the SequenceNumber property
        private System.Int32? _SequenceNumber;

        // Xml -- (backing property for Assessment Item Body Custom Interaction XML)
        private System.String _Xml;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// APIP Interaction Sequence Number
        /// <para>
        /// The position of this APIP Interaction in a sequence of interactions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20504">APIP Interaction Sequence Number</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? APIPInteractionSequenceNumber { get => _APIPInteractionSequenceNumber; set => SetProperty(ref _APIPInteractionSequenceNumber, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IAssessmentItemApip"/> model
        /// </summary>
        public Guid AssessmentItemApipId { get => _AssessmentItemApipId; set => SetProperty(ref _AssessmentItemApipId, value); }

        /// <summary>
        /// Assessment Item Body Drawing Interaction XML
        /// <para>
        /// The drawing interaction allows the candidate to use a common set of drawing tools to modify a given graphical image (the canvas). It must be bound to a response variable with base-type file and single cardinality. The result is a file in the same format as the original image. The XML from the IMS Global APIP Specification would be included.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20080">Assessment Item Body Drawing Interaction XML</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefApipInteractionTypeId { get => _RefApipInteractionTypeId; set => SetProperty(ref _RefApipInteractionTypeId, value); }

        public System.Int32? SequenceNumber { get => _SequenceNumber; set => SetProperty(ref _SequenceNumber, value); }

        /// <summary>
        /// Assessment Item Body Custom Interaction XML
        /// <para>
        /// The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.  The XML from the IMS Global APIP Specification would be included.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20079">Assessment Item Body Custom Interaction XML</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Xml { get => _Xml; set => SetProperty(ref _Xml, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IApipInteraction model)
        {
            IsBusy = true;
            Id = model.Id;
            APIPInteractionSequenceNumber = model.APIPInteractionSequenceNumber; // APIP Interaction Sequence Number
            AssessmentItemApipId = model.AssessmentItemApipId; // 
            RefApipInteractionTypeId = model.RefApipInteractionTypeId; // Assessment Item Body Drawing Interaction XML
            SequenceNumber = model.SequenceNumber; // 
            Xml = model.Xml; // Assessment Item Body Custom Interaction XML
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefApipInteractionType List
        /// <summary>
        /// The complete <see cref="RefApipInteractionType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefApipInteractionTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("a6f66275-bba5-4233-b421-26face7f9a58"), Code="CustomInteraction", Description="Custom Interaction", Definition="The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("97c554d9-647c-4ade-8f64-15838b0361e0"), Code="DrawingInteraction", Description="Drawing Interaction", Definition="The drawing interaction allows the candidate to use a common set of drawing tools to modify a given graphical image (the canvas). It must be bound to a response variable with base-type file and single cardinality. The result is a file in the same format as the original image.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("8be5a06b-6b59-4122-bd5b-a9aa0d56b2a4"), Code="GapMatchInteraction", Description="Gap Match Interaction", Definition="A gap match interaction contains a number gaps that the candidate can fill from an associated set of choices. The candidate must be able to review the content with the gaps filled in context, as indicated by their choices.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("de882c75-1b75-4b76-ae91-1043319ee234"), Code="MatchInteraction", Description="Match Interaction", Definition="A match interaction presents candidates with two sets of choices and allows them to create associates between pairs of choices in the two sets, but not between pairs of choices in the same set. Further restrictions can still be placed on the allowable associations using the matchMax attribute of the choices.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("9e1713dc-52c9-4e40-91cd-bc36d16a80a7"), Code="GraphicGapMatchInteraction", Description="Graphic Gap Match Interaction", Definition="A graphic gap-match interaction is a graphical interaction with a set of gaps that are defined as areas (hotspots) of the graphic image and an additional set of gap choices that are defined outside the image. The candidate must associate the gap choices with the gaps in the image and be able to review the image with the gaps filled in context, as indicated by their choices. Care should be taken when designing these interactions to ensure that the gaps in the image are a suitable size to receive the required gap choices. It must be clear to the candidate which hotspot each choice has been associated with. When associated, choices must appear wholly inside the gaps if at all possible and, where overlaps are required, should not hide each other completely. If the candidate indicates the association by positioning the choice over the gap (e.g., drag and drop) the system should 'snap' it to the nearest position that satisfies these requirements.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("162dc7cc-2d5c-4b92-aa81-bb5f6dc70815"), Code="HotspotInteraction", Description="Hotspot Interaction", Definition="A hotspot interaction is a graphical interaction with a corresponding set of choices that are defined as areas of the graphic image. The candidate's task is to select one or more of the areas (hotspots). The hotspot interaction should only be used when the spatial relationship of the choices with respect to each other (as represented by the graphic image) is important to the needs of the item. Otherwise, choiceInteraction should be used instead with separate material for each option.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("9b9cb808-f7d3-4112-83cf-8242d13057d2"), Code="GraphicOrderInteraction", Description="Graphic Order Interaction", Definition="A graphic order interaction is a graphic interaction with a corresponding set of choices that are defined as areas of the graphic image. The candidate's task is to impose an ordering on the areas (hotspots). The order hotspot interaction should only be used when the spatial relationship of the choices with respect to each other (as represented by the graphic image) is important to the needs of the item. Otherwise, orderInteraction should be used instead with separate material for each option.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("ad5eb8eb-e84c-443e-9559-645714567ade"), Code="GraphicAssociateInteraction", Description="Graphic Associate Interaction", Definition="A graphic associate interaction is a graphic interaction with a corresponding set of choices that are defined as areas of the graphic image. The candidate's task is to associate the areas (hotspots) with each other. The graphic associate interaction should only be used when the graphical relationship of the choices with respect to each other (as represented by the graphic image) is important to the needs of the item. Otherwise, associateInteraction should be used instead with separate Material for each option.", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("f7644254-402a-4a62-a392-475dea5aaf25"), Code="8.00", Description="", Definition="", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("3ef0717b-27a1-43b6-8f3f-286bd1106cf6"), Code="ChoiceInteraction", Description="Choice Interaction", Definition="The choice interaction presents a set of choices to the candidate. The candidate's task is to select one or more of the choices, up to a maximum of maxChoices. The interaction is always initialized with no choices selected.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("8246a487-c389-4d6a-a89c-91f2b96c23bf"), Code="InlineChoiceInteraction", Description="Inline Choice Interaction", Definition="A inline choice is an inlineInteraction that presents the user with a set of choices, each of which is a simple piece of text. The candidate's task is to select one of the choices. Unlike the choiceInteraction, the delivery engine must allow the candidate to review their choice within the context of the surrounding text.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("5c4e8a0d-a477-4ba8-aaac-642c068e81e1"), Code="MediaInteraction", Description="Media Interaction", Definition="The media interaction allows more control over the way the candidate interacts with a time-based media object and allows the number of times the media object was experienced to be reported in the value of the associated response variable, which must be of base-type integer and single cardinality.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("5a4bf5ef-6f44-419c-81fe-77470bb367e3"), Code="HottextInteraction", Description="Hottext Interaction", Definition="The hottext interaction presents a set of choices to the candidate represented as selectable runs of text embedded within a surrounding context, such as a simple passage of text. Like choiceInteraction, the candidate's task is to select one or more of the choices, up to a maximum of maxChoices. The interaction is initialized from the defaultValue of the associated response variable, a NULL value indicating that no choices are selected (the usual case).", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("c3475049-fa39-45c9-a11e-0889c75eb24a"), Code="OrderInteraction", Description="Order Interaction", Definition="In an order interaction the candidate's task is to reorder the choices, the order in which the choices are displayed initially is significant. By default the candidate's task is to order all of the choices but a subset of the choices can be requested using the maxChoices and minChoices attributes. When specified the candidate must select a subset of the choices and impose an ordering on them.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("2df865fa-528c-4fe1-bceb-801ec16eec45"), Code="PositionObjectInteraction", Description="Position Object Interaction", Definition="The position object interaction consists of a single image which must be positioned on another graphic image (the stage) by the candidate. Like selectPointInteraction, the associated response may have an areaMapping that scores the response on the basis of comparing it against predefined areas but the delivery engine must not indicate these areas of the stage. Only the actual position(s) selected by the candidate shall be indicated.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("f3b4def7-71cc-404e-aef2-67d42dae445d"), Code="TextEntryInteraction", Description="Text Entry Interaction", Definition="A textEntry interaction obtains a simple piece of text from the candidate. Like inlineChoiceInteraction, the delivery engine must allow the candidate to review their choice within the context of the surrounding text.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("d60f1b1a-b1af-4f35-8633-b2b05bf0092f"), Code="ExtendedTextInteraction", Description="Extended Text Interaction", Definition="An extended text interaction allows the candidate to enter an extended amount of text.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("78ef5ca8-65ac-45d3-9954-ececccdd2208"), Code="EndAttemptInteraction", Description="End Attempt Interaction", Definition="The end attempt interaction is a special type of interaction which allows item authors to provide the candidate with control over the way in which the candidate terminates an attempt. The candidate can use the interaction to terminate the attempt (triggering response processing) immediately, typically to request a hint. It must be bound to a response variable with base-type boolean and single cardinality.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("3594b547-f3e7-4089-8470-2d510eb815c4"), Code="UploadInteraction", Description="Upload Interaction", Definition="The upload interaction allows the candidate to upload a pre-prepared file representing their response. It must be bound to a response variable with base-type file and single cardinality.", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("d20507e5-41ea-4ac3-920b-c0b65653b367"), Code="AssociateInteraction", Description="Associate Interaction", Definition="An associate interaction presents candidates with a number of choices and allows them to create associations between them.", SortOrder=Convert.ToDecimal("19.00") },
        };
        #endregion
    }
}