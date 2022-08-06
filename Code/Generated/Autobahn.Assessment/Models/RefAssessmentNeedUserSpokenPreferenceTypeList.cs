//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentNeedUserSpokenPreferenceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentNeedUserSpokenPreferenceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentNeedUserSpokenPreferenceType"> List
         /// </summary>
        public static List<RefAssessmentNeedUserSpokenPreferenceType> RefAssessmentNeedUserSpokenPreferenceTypeList = new List<RefAssessmentNeedUserSpokenPreferenceType> =
        {
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("f4f55023-272e-4e3d-b426-5b66b99115ec"), Code="Text only is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", Description="TextOnly", Definition="", SortOrder=0 },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("19a895ae-32d4-499d-b0db-e1ae920a8de4"), Code="Text and graphics is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", Description="TextGraphics", Definition="", SortOrder=0 },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("0d569154-5766-42c2-bf00-169a79412e7d"), Code="Graphics only is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", Description="GraphicsOnly", Definition="", SortOrder=0 },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("977f5d9b-a74b-4227-b59a-c7009095e49b"), Code="Non-visual is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", Description="NonVisual", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentNeedUserSpokenPreferenceType Pick List
         /// </summary>
        public static List<RefAssessmentNeedUserSpokenPreferenceType> RefAssessmentNeedUserSpokenPreferenceTypePickList = new List<RefAssessmentNeedUserSpokenPreferenceType> =
        {
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("f4f55023-272e-4e3d-b426-5b66b99115ec"), Code="Text only is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", SortOrder=0 },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("19a895ae-32d4-499d-b0db-e1ae920a8de4"), Code="Text and graphics is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", SortOrder=0 },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("0d569154-5766-42c2-bf00-169a79412e7d"), Code="Graphics only is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", SortOrder=0 },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("977f5d9b-a74b-4227-b59a-c7009095e49b"), Code="Non-visual is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", SortOrder=0 },
       };
   }
}
