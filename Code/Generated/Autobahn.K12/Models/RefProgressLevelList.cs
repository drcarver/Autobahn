//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefProgressLevelList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefProgressLevel Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProgressLevel"> List
         /// </summary>
        public static List<RefProgressLevel> RefProgressLevelList = new List<RefProgressLevel> =
        {
            new RefProgressLevel { Id=Guid.Parse("41d4a424-bbf0-452e-ac46-8c8809e565ac"), Code="The students showed a negative grade level change from the pre- to post- test", Description="NEGGRADE", Definition="", SortOrder=0 },
            new RefProgressLevel { Id=Guid.Parse("2e084900-65e4-4263-9c87-d4453a519699"), Code="The students showed no change from the pre- to post- test", Description="NOCHANGE", Definition="", SortOrder=0 },
            new RefProgressLevel { Id=Guid.Parse("0d5feb3a-8bf6-4077-a8f5-dd17e8c25225"), Code="The students showed improvement of up to one half grade level from the pre- to post- test", Description="UPHALFGRADE", Definition="", SortOrder=0 },
            new RefProgressLevel { Id=Guid.Parse("776f50fa-c733-471e-9034-cfb1efbd3257"), Code="The students showed improvement from one half grade level up to one full grade level from the pre- to post- test", Description="UPONEGRADE", Definition="", SortOrder=0 },
            new RefProgressLevel { Id=Guid.Parse("3b5e5665-6302-400c-ada0-3a290cfc2892"), Code="The students showed improvement of more than one full grade level from the pre- to post- test", Description="UPGTONE", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefProgressLevel Pick List
         /// </summary>
        public static List<RefProgressLevel> RefProgressLevelPickList = new List<RefProgressLevel> =
        {
            new RefProgressLevel { Id=Guid.Parse("41d4a424-bbf0-452e-ac46-8c8809e565ac"), Code="The students showed a negative grade level change from the pre- to post- test", SortOrder=0 },
            new RefProgressLevel { Id=Guid.Parse("2e084900-65e4-4263-9c87-d4453a519699"), Code="The students showed no change from the pre- to post- test", SortOrder=0 },
            new RefProgressLevel { Id=Guid.Parse("0d5feb3a-8bf6-4077-a8f5-dd17e8c25225"), Code="The students showed improvement of up to one half grade level from the pre- to post- test", SortOrder=0 },
            new RefProgressLevel { Id=Guid.Parse("776f50fa-c733-471e-9034-cfb1efbd3257"), Code="The students showed improvement from one half grade level up to one full grade level from the pre- to post- test", SortOrder=0 },
            new RefProgressLevel { Id=Guid.Parse("3b5e5665-6302-400c-ada0-3a290cfc2892"), Code="The students showed improvement of more than one full grade level from the pre- to post- test", SortOrder=0 },
       };
   }
}
