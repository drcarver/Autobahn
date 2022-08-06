//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefBillableBasisTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefBillableBasisType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBillableBasisType"> List
         /// </summary>
        public static List<RefBillableBasisType> RefBillableBasisTypeList = new List<RefBillableBasisType> =
        {
            new RefBillableBasisType { Id=Guid.Parse("68e1d846-ecef-408d-947b-4b6f51966e34"), Code="Face-to-Face Contact is specified as the event/action that results in a billable action.", Description="FaceToFaceContact", Definition="", SortOrder=0 },
            new RefBillableBasisType { Id=Guid.Parse("dad3ff35-a417-45f8-a094-6903b229d4af"), Code="Event-based is specified as the event/action that results in a billable action.", Description="EventBased", Definition="", SortOrder=0 },
            new RefBillableBasisType { Id=Guid.Parse("e9bf901d-8006-4e9c-90e5-607c946fd0f1"), Code="Time-based is specified as the event/action that results in a billable action.", Description="TimeBased", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefBillableBasisType Pick List
         /// </summary>
        public static List<RefBillableBasisType> RefBillableBasisTypePickList = new List<RefBillableBasisType> =
        {
            new RefBillableBasisType { Id=Guid.Parse("68e1d846-ecef-408d-947b-4b6f51966e34"), Code="Face-to-Face Contact is specified as the event/action that results in a billable action.", SortOrder=0 },
            new RefBillableBasisType { Id=Guid.Parse("dad3ff35-a417-45f8-a094-6903b229d4af"), Code="Event-based is specified as the event/action that results in a billable action.", SortOrder=0 },
            new RefBillableBasisType { Id=Guid.Parse("e9bf901d-8006-4e9c-90e5-607c946fd0f1"), Code="Time-based is specified as the event/action that results in a billable action.", SortOrder=0 },
       };
   }
}
