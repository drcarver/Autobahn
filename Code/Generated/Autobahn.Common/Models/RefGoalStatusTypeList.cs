//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefGoalStatusTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefGoalStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefGoalStatusType"> List
         /// </summary>
        public static List<RefGoalStatusType> RefGoalStatusTypeList = new List<RefGoalStatusType> =
        {
            new RefGoalStatusType { Id=Guid.Parse("011b53bb-1866-4df9-a220-ea72647c1cc0"), Code="Completed is specified as the status toward achievement of the annual goal or short-term objectives.", Description="Completed", Definition="", SortOrder=0 },
            new RefGoalStatusType { Id=Guid.Parse("fcf4c688-d659-420f-96cf-273e76d7e57e"), Code="The status toward achievement of the annual goal or short-term objectives is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
            new RefGoalStatusType { Id=Guid.Parse("e0c23573-746a-49fb-8abf-308495032b72"), Code="Satisfactory Progress is specified as the status toward achievement of the annual goal or short-term objectives.", Description="SatisfactoryProgress", Definition="", SortOrder=0 },
            new RefGoalStatusType { Id=Guid.Parse("4a6f4f90-f868-4307-8492-b18446bbd64e"), Code="Unsatisfactory Progress is specified as the status toward achievement of the annual goal or short-term objectives.", Description="UnsatisfactoryProgress", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefGoalStatusType Pick List
         /// </summary>
        public static List<RefGoalStatusType> RefGoalStatusTypePickList = new List<RefGoalStatusType> =
        {
            new RefGoalStatusType { Id=Guid.Parse("011b53bb-1866-4df9-a220-ea72647c1cc0"), Code="Completed is specified as the status toward achievement of the annual goal or short-term objectives.", SortOrder=0 },
            new RefGoalStatusType { Id=Guid.Parse("fcf4c688-d659-420f-96cf-273e76d7e57e"), Code="The status toward achievement of the annual goal or short-term objectives is in a category not yet defined in CEDS.", SortOrder=0 },
            new RefGoalStatusType { Id=Guid.Parse("e0c23573-746a-49fb-8abf-308495032b72"), Code="Satisfactory Progress is specified as the status toward achievement of the annual goal or short-term objectives.", SortOrder=0 },
            new RefGoalStatusType { Id=Guid.Parse("4a6f4f90-f868-4307-8492-b18446bbd64e"), Code="Unsatisfactory Progress is specified as the status toward achievement of the annual goal or short-term objectives.", SortOrder=0 },
       };
   }
}
