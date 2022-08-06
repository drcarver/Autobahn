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
        public static List<RefAssessmentNeedAlternativeRepresentationType> RefAssessmentNeedAlternativeRepresentationTypeList = new List<RefAssessmentNeedAlternativeRepresentationType>
        {
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("fe27c3d4-9875-4817-9b2e-d50c2e7dc323"), Code="Audio", Description="Audio", Definition="Audio is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("04eda71c-2d2c-49ef-8a2d-7155f16b959e"), Code="Video", Description="Video", Definition="Video is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("97e571c5-5652-4227-b739-799502d5dd6b"), Code="Graphic", Description="Graphic", Definition="Graphic is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("a134d265-d0ff-4566-aabe-62e1f5da5d95"), Code="Text", Description="Text", Definition="Text is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("ed56f5f3-1c2a-48ef-a671-fa7be1263305"), Code="Interactive", Description="Interactive", Definition="Interactive is specified as part of an Assessment Personal Needs Profile to be the default presentation mode of the associated Alternative Representations accessibility.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefAssessmentNeedAlternativeRepresentationType Pick List
         /// </summary>
        public static List<RefAssessmentNeedAlternativeRepresentationType> RefAssessmentNeedAlternativeRepresentationTypePickList = new List<RefAssessmentNeedAlternativeRepresentationType>
        {
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("fe27c3d4-9875-4817-9b2e-d50c2e7dc323"), Code="Audio", Description="Audio", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("04eda71c-2d2c-49ef-8a2d-7155f16b959e"), Code="Video", Description="Video", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("97e571c5-5652-4227-b739-799502d5dd6b"), Code="Graphic", Description="Graphic", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("a134d265-d0ff-4566-aabe-62e1f5da5d95"), Code="Text", Description="Text", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentNeedAlternativeRepresentationType { Id=Guid.Parse("ed56f5f3-1c2a-48ef-a671-fa7be1263305"), Code="Interactive", Description="Interactive", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
