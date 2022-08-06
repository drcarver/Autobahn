//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefApipInteractionTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefApipInteractionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefApipInteractionType"> List
         /// </summary>
        public static List<RefApipInteractionType> RefApipInteractionTypeList = new List<RefApipInteractionType>
        {
            new RefApipInteractionType { Id=Guid.Parse("8ac24740-68cd-4a83-a91a-f9937a2dddf5"), Code="CustomInteraction", Description="Custom Interaction", Definition="The custom interaction provides an opportunity for extensibility of this specification to include support for interactions not currently documented.", SortOrder=Convert.ToDecimal("1.00") },
            new RefApipInteractionType { Id=Guid.Parse("d03b9577-736c-4a54-8307-4b3dd7b3efc3"), Code="DrawingInteraction", Description="Drawing Interaction", Definition="The drawing interaction allows the candidate to use a common set of drawing tools to modify a given graphical image (the canvas). It must be bound to a response variable with base-type file and single cardinality. The result is a file in the same format as the original image.", SortOrder=Convert.ToDecimal("2.00") },
            new RefApipInteractionType { Id=Guid.Parse("b0e3df35-aee4-4e67-bef2-9970397c32ce"), Code="GapMatchInteraction", Description="Gap Match Interaction", Definition="A gap match interaction contains a number gaps that the candidate can fill from an associated set of choices. The candidate must be able to review the content with the gaps filled in context, as indicated by their choices.", SortOrder=Convert.ToDecimal("3.00") },
            new RefApipInteractionType { Id=Guid.Parse("d043c754-5c2a-4b28-abfa-34122a2b0c15"), Code="MatchInteraction", Description="Match Interaction", Definition="A match interaction presents candidates with two sets of choices and allows them to create associates between pairs of choices in the two sets, but not between pairs of choices in the same set. Further restrictions can still be placed on the allowable associations using the matchMax attribute of the choices.", SortOrder=Convert.ToDecimal("4.00") },
            new RefApipInteractionType { Id=Guid.Parse("5ca2c6c9-2140-48c7-8559-0d8b2620d8d9"), Code="GraphicGapMatchInteraction", Description="Graphic Gap Match Interaction", Definition="A graphic gap-match interaction is a graphical interaction with a set of gaps that are defined as areas (hotspots) of the graphic image and an additional set of gap choices that are defined outside the image. The candidate must associate the gap choices with the gaps in the image and be able to review the image with the gaps filled in context, as indicated by their choices. Care should be taken when designing these interactions to ensure that the gaps in the image are a suitable size to receive the required gap choices. It must be clear to the candidate which hotspot each choice has been associated with. When associated, choices must appear wholly inside the gaps if at all possible and, where overlaps are required, should not hide each other completely. If the candidate indicates the association by positioning the choice over the gap (e.g., drag and drop) the system should 'snap' it to the nearest position that satisfies these requirements.", SortOrder=Convert.ToDecimal("5.00") },
            new RefApipInteractionType { Id=Guid.Parse("b8f24c22-ed79-4973-9081-cb2f22f1afb0"), Code="HotspotInteraction", Description="Hotspot Interaction", Definition="A hotspot interaction is a graphical interaction with a corresponding set of choices that are defined as areas of the graphic image. The candidate's task is to select one or more of the areas (hotspots). The hotspot interaction should only be used when the spatial relationship of the choices with respect to each other (as represented by the graphic image) is important to the needs of the item. Otherwise, choiceInteraction should be used instead with separate material for each option.", SortOrder=Convert.ToDecimal("6.00") },
            new RefApipInteractionType { Id=Guid.Parse("f3611000-c847-496e-b238-81d41316a8ea"), Code="GraphicOrderInteraction", Description="Graphic Order Interaction", Definition="A graphic order interaction is a graphic interaction with a corresponding set of choices that are defined as areas of the graphic image. The candidate's task is to impose an ordering on the areas (hotspots). The order hotspot interaction should only be used when the spatial relationship of the choices with respect to each other (as represented by the graphic image) is important to the needs of the item. Otherwise, orderInteraction should be used instead with separate material for each option.", SortOrder=Convert.ToDecimal("7.00") },
            new RefApipInteractionType { Id=Guid.Parse("28eaac50-e4db-4782-ba32-a693b8b7d298"), Code="GraphicAssociateInteraction", Description="Graphic Associate Interaction", Definition="A graphic associate interaction is a graphic interaction with a corresponding set of choices that are defined as areas of the graphic image. The candidate's task is to associate the areas (hotspots) with each other. The graphic associate interaction should only be used when the graphical relationship of the choices with respect to each other (as represented by the graphic image) is important to the needs of the item. Otherwise, associateInteraction should be used instead with separate Material for each option.", SortOrder=Convert.ToDecimal("") },
            new RefApipInteractionType { Id=Guid.Parse("eb9071ba-be86-4e93-9331-ca5fc146141c"), Code="8.00", Description="", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefApipInteractionType { Id=Guid.Parse("f6ef75b6-8766-48c5-a862-1dae7c2467ff"), Code="ChoiceInteraction", Description="Choice Interaction", Definition="The choice interaction presents a set of choices to the candidate. The candidate's task is to select one or more of the choices, up to a maximum of maxChoices. The interaction is always initialized with no choices selected.", SortOrder=Convert.ToDecimal("9.00") },
            new RefApipInteractionType { Id=Guid.Parse("c8d9292e-5a34-4e0f-a733-7ba489e815d1"), Code="InlineChoiceInteraction", Description="Inline Choice Interaction", Definition="A inline choice is an inlineInteraction that presents the user with a set of choices, each of which is a simple piece of text. The candidate's task is to select one of the choices. Unlike the choiceInteraction, the delivery engine must allow the candidate to review their choice within the context of the surrounding text.", SortOrder=Convert.ToDecimal("10.00") },
            new RefApipInteractionType { Id=Guid.Parse("ab4ff117-5067-4463-a716-1d459d6d53d2"), Code="MediaInteraction", Description="Media Interaction", Definition="The media interaction allows more control over the way the candidate interacts with a time-based media object and allows the number of times the media object was experienced to be reported in the value of the associated response variable, which must be of base-type integer and single cardinality.", SortOrder=Convert.ToDecimal("11.00") },
            new RefApipInteractionType { Id=Guid.Parse("993aa0c5-1260-4b6c-8709-984f1db22845"), Code="HottextInteraction", Description="Hottext Interaction", Definition="The hottext interaction presents a set of choices to the candidate represented as selectable runs of text embedded within a surrounding context, such as a simple passage of text. Like choiceInteraction, the candidate's task is to select one or more of the choices, up to a maximum of maxChoices. The interaction is initialized from the defaultValue of the associated response variable, a NULL value indicating that no choices are selected (the usual case).", SortOrder=Convert.ToDecimal("12.00") },
            new RefApipInteractionType { Id=Guid.Parse("cec47156-8f62-41be-b6b1-c6defe51cdb1"), Code="OrderInteraction", Description="Order Interaction", Definition="In an order interaction the candidate's task is to reorder the choices, the order in which the choices are displayed initially is significant. By default the candidate's task is to order all of the choices but a subset of the choices can be requested using the maxChoices and minChoices attributes. When specified the candidate must select a subset of the choices and impose an ordering on them.", SortOrder=Convert.ToDecimal("13.00") },
            new RefApipInteractionType { Id=Guid.Parse("c415b0c6-23f6-4062-a808-0e70a4776c6a"), Code="PositionObjectInteraction", Description="Position Object Interaction", Definition="The position object interaction consists of a single image which must be positioned on another graphic image (the stage) by the candidate. Like selectPointInteraction, the associated response may have an areaMapping that scores the response on the basis of comparing it against predefined areas but the delivery engine must not indicate these areas of the stage. Only the actual position(s) selected by the candidate shall be indicated.", SortOrder=Convert.ToDecimal("14.00") },
            new RefApipInteractionType { Id=Guid.Parse("9a72afc4-439a-484d-8ee4-f558a021fa92"), Code="TextEntryInteraction", Description="Text Entry Interaction", Definition="A textEntry interaction obtains a simple piece of text from the candidate. Like inlineChoiceInteraction, the delivery engine must allow the candidate to review their choice within the context of the surrounding text.", SortOrder=Convert.ToDecimal("15.00") },
            new RefApipInteractionType { Id=Guid.Parse("fe0b6507-4bff-47b9-8dc7-743d09f5cdb6"), Code="ExtendedTextInteraction", Description="Extended Text Interaction", Definition="An extended text interaction allows the candidate to enter an extended amount of text.", SortOrder=Convert.ToDecimal("16.00") },
            new RefApipInteractionType { Id=Guid.Parse("b60e8df8-3167-462e-bdbf-299a0d8950e4"), Code="EndAttemptInteraction", Description="End Attempt Interaction", Definition="The end attempt interaction is a special type of interaction which allows item authors to provide the candidate with control over the way in which the candidate terminates an attempt. The candidate can use the interaction to terminate the attempt (triggering response processing) immediately, typically to request a hint. It must be bound to a response variable with base-type boolean and single cardinality.", SortOrder=Convert.ToDecimal("17.00") },
            new RefApipInteractionType { Id=Guid.Parse("d5b0645f-ca24-4e7a-a9ad-c18054de8223"), Code="UploadInteraction", Description="Upload Interaction", Definition="The upload interaction allows the candidate to upload a pre-prepared file representing their response. It must be bound to a response variable with base-type file and single cardinality.", SortOrder=Convert.ToDecimal("18.00") },
            new RefApipInteractionType { Id=Guid.Parse("2881e03c-a541-491c-afe6-b13a0f6ff43c"), Code="AssociateInteraction", Description="Associate Interaction", Definition="An associate interaction presents candidates with a number of choices and allows them to create associations between them.", SortOrder=Convert.ToDecimal("19.00") },
        };

        /// <summary>
        /// The RefApipInteractionType Pick List
         /// </summary>
        public static List<RefApipInteractionType> RefApipInteractionTypePickList = new List<RefApipInteractionType>
        {
            new RefApipInteractionType { Id=Guid.Parse("8ac24740-68cd-4a83-a91a-f9937a2dddf5"), Code="CustomInteraction", Description="Custom Interaction", SortOrder=Convert.ToDecimal("1.00") },
            new RefApipInteractionType { Id=Guid.Parse("d03b9577-736c-4a54-8307-4b3dd7b3efc3"), Code="DrawingInteraction", Description="Drawing Interaction", SortOrder=Convert.ToDecimal("2.00") },
            new RefApipInteractionType { Id=Guid.Parse("b0e3df35-aee4-4e67-bef2-9970397c32ce"), Code="GapMatchInteraction", Description="Gap Match Interaction", SortOrder=Convert.ToDecimal("3.00") },
            new RefApipInteractionType { Id=Guid.Parse("d043c754-5c2a-4b28-abfa-34122a2b0c15"), Code="MatchInteraction", Description="Match Interaction", SortOrder=Convert.ToDecimal("4.00") },
            new RefApipInteractionType { Id=Guid.Parse("5ca2c6c9-2140-48c7-8559-0d8b2620d8d9"), Code="GraphicGapMatchInteraction", Description="Graphic Gap Match Interaction", SortOrder=Convert.ToDecimal("5.00") },
            new RefApipInteractionType { Id=Guid.Parse("b8f24c22-ed79-4973-9081-cb2f22f1afb0"), Code="HotspotInteraction", Description="Hotspot Interaction", SortOrder=Convert.ToDecimal("6.00") },
            new RefApipInteractionType { Id=Guid.Parse("f3611000-c847-496e-b238-81d41316a8ea"), Code="GraphicOrderInteraction", Description="Graphic Order Interaction", SortOrder=Convert.ToDecimal("7.00") },
            new RefApipInteractionType { Id=Guid.Parse("28eaac50-e4db-4782-ba32-a693b8b7d298"), Code="GraphicAssociateInteraction", Description="Graphic Associate Interaction", SortOrder=Convert.ToDecimal("") },
            new RefApipInteractionType { Id=Guid.Parse("eb9071ba-be86-4e93-9331-ca5fc146141c"), Code="8.00", Description="", SortOrder=Convert.ToDecimal("") },
            new RefApipInteractionType { Id=Guid.Parse("f6ef75b6-8766-48c5-a862-1dae7c2467ff"), Code="ChoiceInteraction", Description="Choice Interaction", SortOrder=Convert.ToDecimal("9.00") },
            new RefApipInteractionType { Id=Guid.Parse("c8d9292e-5a34-4e0f-a733-7ba489e815d1"), Code="InlineChoiceInteraction", Description="Inline Choice Interaction", SortOrder=Convert.ToDecimal("10.00") },
            new RefApipInteractionType { Id=Guid.Parse("ab4ff117-5067-4463-a716-1d459d6d53d2"), Code="MediaInteraction", Description="Media Interaction", SortOrder=Convert.ToDecimal("11.00") },
            new RefApipInteractionType { Id=Guid.Parse("993aa0c5-1260-4b6c-8709-984f1db22845"), Code="HottextInteraction", Description="Hottext Interaction", SortOrder=Convert.ToDecimal("12.00") },
            new RefApipInteractionType { Id=Guid.Parse("cec47156-8f62-41be-b6b1-c6defe51cdb1"), Code="OrderInteraction", Description="Order Interaction", SortOrder=Convert.ToDecimal("13.00") },
            new RefApipInteractionType { Id=Guid.Parse("c415b0c6-23f6-4062-a808-0e70a4776c6a"), Code="PositionObjectInteraction", Description="Position Object Interaction", SortOrder=Convert.ToDecimal("14.00") },
            new RefApipInteractionType { Id=Guid.Parse("9a72afc4-439a-484d-8ee4-f558a021fa92"), Code="TextEntryInteraction", Description="Text Entry Interaction", SortOrder=Convert.ToDecimal("15.00") },
            new RefApipInteractionType { Id=Guid.Parse("fe0b6507-4bff-47b9-8dc7-743d09f5cdb6"), Code="ExtendedTextInteraction", Description="Extended Text Interaction", SortOrder=Convert.ToDecimal("16.00") },
            new RefApipInteractionType { Id=Guid.Parse("b60e8df8-3167-462e-bdbf-299a0d8950e4"), Code="EndAttemptInteraction", Description="End Attempt Interaction", SortOrder=Convert.ToDecimal("17.00") },
            new RefApipInteractionType { Id=Guid.Parse("d5b0645f-ca24-4e7a-a9ad-c18054de8223"), Code="UploadInteraction", Description="Upload Interaction", SortOrder=Convert.ToDecimal("18.00") },
            new RefApipInteractionType { Id=Guid.Parse("2881e03c-a541-491c-afe6-b13a0f6ff43c"), Code="AssociateInteraction", Description="Associate Interaction", SortOrder=Convert.ToDecimal("19.00") },
       };
   }
}
