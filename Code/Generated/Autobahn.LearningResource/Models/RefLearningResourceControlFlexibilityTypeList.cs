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
        public static List<RefLearningResourceControlFlexibilityType> RefLearningResourceControlFlexibilityTypeList = new List<RefLearningResourceControlFlexibilityType> =
        {
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("35512918-0c4b-4818-b536-3aacf062f0bc"), Code="Audio input is sufficient to control the described learning resource.", Description="fullAudioControl", Definition="", SortOrder=0 },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("0ddccdae-1295-4eae-bafe-025bb8f77dd9"), Code="Keyboard input is sufficient to control the described learning resource.", Description="fullKeyboardControl", Definition="", SortOrder=0 },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("46f1e874-8d5b-4780-a1a1-e70026d333ae"), Code="Mouse input is sufficient to control the described learning resource.", Description="fullMouseControl", Definition="", SortOrder=0 },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("fee5b8fe-43df-472f-8cc0-73c21a839957"), Code="Touch input is sufficient to control the described learning resource.", Description="fullTouchControl", Definition="", SortOrder=0 },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("b372cf07-9959-4257-854a-7199ab65725e"), Code=" Video input is sufficient to control the described learning resource.", Description="fullVideoControl", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLearningResourceControlFlexibilityType Pick List
         /// </summary>
        public static List<RefLearningResourceControlFlexibilityType> RefLearningResourceControlFlexibilityTypePickList = new List<RefLearningResourceControlFlexibilityType> =
        {
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("35512918-0c4b-4818-b536-3aacf062f0bc"), Code="Audio input is sufficient to control the described learning resource.", SortOrder=0 },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("0ddccdae-1295-4eae-bafe-025bb8f77dd9"), Code="Keyboard input is sufficient to control the described learning resource.", SortOrder=0 },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("46f1e874-8d5b-4780-a1a1-e70026d333ae"), Code="Mouse input is sufficient to control the described learning resource.", SortOrder=0 },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("fee5b8fe-43df-472f-8cc0-73c21a839957"), Code="Touch input is sufficient to control the described learning resource.", SortOrder=0 },
            new RefLearningResourceControlFlexibilityType { Id=Guid.Parse("b372cf07-9959-4257-854a-7199ab65725e"), Code=" Video input is sufficient to control the described learning resource.", SortOrder=0 },
       };
   }
}
