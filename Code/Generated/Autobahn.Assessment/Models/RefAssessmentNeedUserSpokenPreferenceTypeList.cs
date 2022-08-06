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
        public static List<RefAssessmentNeedUserSpokenPreferenceType> RefAssessmentNeedUserSpokenPreferenceTypeList = new List<RefAssessmentNeedUserSpokenPreferenceType>
        {
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("9b494ef9-cf85-4bb0-bdef-c5f37964caa1"), Code="TextOnly", Description="Text only", Definition="Text only is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("bfa363ad-0ae6-43c3-a002-f783e79691ff"), Code="TextGraphics", Description="Text and graphics", Definition="Text and graphics is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("74a7ea65-cd31-46a8-b6f6-6ac77e71b684"), Code="GraphicsOnly", Description="Graphics only", Definition="Graphics only is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("0c10e9dd-c5bb-4096-b0f2-dc055ec4a11b"), Code="NonVisual", Description="Non-visual", Definition="Non-visual is specified as part of an Assessment Personal Needs Profile to define the type of material that should be rendered using the read aloud alternative content.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefAssessmentNeedUserSpokenPreferenceType Pick List
         /// </summary>
        public static List<RefAssessmentNeedUserSpokenPreferenceType> RefAssessmentNeedUserSpokenPreferenceTypePickList = new List<RefAssessmentNeedUserSpokenPreferenceType>
        {
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("9b494ef9-cf85-4bb0-bdef-c5f37964caa1"), Code="TextOnly", Description="Text only", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("bfa363ad-0ae6-43c3-a002-f783e79691ff"), Code="TextGraphics", Description="Text and graphics", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("74a7ea65-cd31-46a8-b6f6-6ac77e71b684"), Code="GraphicsOnly", Description="Graphics only", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentNeedUserSpokenPreferenceType { Id=Guid.Parse("0c10e9dd-c5bb-4096-b0f2-dc055ec4a11b"), Code="NonVisual", Description="Non-visual", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
