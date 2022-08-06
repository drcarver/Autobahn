//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceControlFlexibilityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceControlFlexibilityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceControlFlexibilityType"> List
         /// </summary>
        public static List<RefLearningResourceControlFlexibilityType> RefLearningResourceControlFlexibilityTypeList = new List<RefLearningResourceControlFlexibilityType>
        {
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("89734d54-c555-4ad5-b9a2-0ebf01c110db"), Code="fullAudioControl", Description="Full Audio Control", Definition="Audio input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("4ce1a253-2c68-41d7-ad71-1bd8444abe54"), Code="fullKeyboardControl", Description="Full Keyboard Control", Definition="Keyboard input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("232d2e1f-2e6e-4541-bec4-47bf84156e2e"), Code="fullMouseControl", Description="Full Mouse Control", Definition="Mouse input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("9e5ac0a4-da3e-4406-889f-5305212078a3"), Code="fullTouchControl", Description="Full Touch Control", Definition="Touch input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("015cd6dc-e046-460e-9014-518eef2f751a"), Code="fullVideoControl", Description="Full Video Control", Definition=" Video input is sufficient to control the described learning resource.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The RefLearningResourceControlFlexibilityType Pick List
         /// </summary>
        public static List<RefLearningResourceControlFlexibilityType> RefLearningResourceControlFlexibilityTypePickList = new List<RefLearningResourceControlFlexibilityType>
        {
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("89734d54-c555-4ad5-b9a2-0ebf01c110db"), Code="fullAudioControl", Description="Full Audio Control", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("4ce1a253-2c68-41d7-ad71-1bd8444abe54"), Code="fullKeyboardControl", Description="Full Keyboard Control", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("232d2e1f-2e6e-4541-bec4-47bf84156e2e"), Code="fullMouseControl", Description="Full Mouse Control", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("9e5ac0a4-da3e-4406-889f-5305212078a3"), Code="fullTouchControl", Description="Full Touch Control", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("015cd6dc-e046-460e-9014-518eef2f751a"), Code="fullVideoControl", Description="Full Video Control", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
