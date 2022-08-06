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
        /// The complete <see cref="RefAssessmentNeedAlternativeRepresentationType"> List
         /// </summary>
        public static List<RefAssessmentNeedAlternativeRepresentationType> RefAssessmentNeedAlternativeRepresentationTypeList = new List<RefAssessmentNeedAlternativeRepresentationType> =
        {
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("7873b580-1908-482b-8594-4e9da4f1f03a"), Code="Audio is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", Description="Audio", Definition="", SortOrder=0 },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("b3c7ed4d-59ce-4f8e-bed2-1f9b5264781f"), Code="Video is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", Description="Video", Definition="", SortOrder=0 },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("6893422b-5279-47e4-851f-241ca939e4c6"), Code="Graphic is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", Description="Graphic", Definition="", SortOrder=0 },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("efcd3088-5892-4891-a561-22d0fc9583a4"), Code="Text is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", Description="Text", Definition="", SortOrder=0 },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("6fe04bd1-616d-4e34-9ca7-148d282f4eaf"), Code="Interactive is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", Description="Interactive", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentNeedAlternativeRepresentationType Pick List
         /// </summary>
        public static List<RefAssessmentNeedAlternativeRepresentationType> RefAssessmentNeedAlternativeRepresentationTypePickList = new List<RefAssessmentNeedAlternativeRepresentationType> =
        {
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("7873b580-1908-482b-8594-4e9da4f1f03a"), Code="Audio is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=0 },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("b3c7ed4d-59ce-4f8e-bed2-1f9b5264781f"), Code="Video is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=0 },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("6893422b-5279-47e4-851f-241ca939e4c6"), Code="Graphic is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=0 },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("efcd3088-5892-4891-a561-22d0fc9583a4"), Code="Text is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=0 },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("6fe04bd1-616d-4e34-9ca7-148d282f4eaf"), Code="Interactive is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=0 },
       };
   }
}
