//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedAlternativeRepresentationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedAlternativeRepresentationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedAlternativeRepresentationTypeModel"> List
         /// </summary>
        public static List<RefAssessmentNeedAlternativeRepresentationTypeModel> RefAssessmentNeedAlternativeRepresentationTypeList = new List<RefAssessmentNeedAlternativeRepresentationTypeModel>
        {
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("dd921503-0293-4736-9463-394d7815e3c4"), Code="Audio", Description="Audio", Definition="Audio is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("325bacc0-030e-42bb-b3c4-ffadf154042b"), Code="Video", Description="Video", Definition="Video is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("f021779b-5956-4084-8e78-8fe1d1401fcd"), Code="Graphic", Description="Graphic", Definition="Graphic is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("207a012b-49cb-4925-999b-2944a2974d54"), Code="Text", Description="Text", Definition="Text is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("6cc5693e-155f-4041-acef-8437aafc83b4"), Code="Interactive", Description="Interactive", Definition="Interactive is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentNeedAlternativeRepresentationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentNeedAlternativeRepresentationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("dd921503-0293-4736-9463-394d7815e3c4"), Description="Audio", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("325bacc0-030e-42bb-b3c4-ffadf154042b"), Description="Video", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("f021779b-5956-4084-8e78-8fe1d1401fcd"), Description="Graphic", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("207a012b-49cb-4925-999b-2944a2974d54"), Description="Text", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("6cc5693e-155f-4041-acef-8437aafc83b4"), Description="Interactive", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
