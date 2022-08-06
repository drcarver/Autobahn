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
        public static List<RefBillableBasisType> RefBillableBasisTypeList = new List<RefBillableBasisType>
        {
            new RefBillableBasisType { Id=Guid.Parse("f3d9c8ef-757e-4af9-a0fd-25f15724e2d7"), Code="FaceToFaceContact", Description="Face-to-Face Contact", Definition="Face-to-Face Contact is specified as the event/action that results in a billable action.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBillableBasisType { Id=Guid.Parse("4068cdd3-0197-4b85-a7c9-7d49aaf200db"), Code="EventBased", Description="Event-based", Definition="Event-based is specified as the event/action that results in a billable action.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBillableBasisType { Id=Guid.Parse("a0042b0e-a891-4d57-8d39-5ed1c2eb24ca"), Code="TimeBased", Description="Time-based", Definition="Time-based is specified as the event/action that results in a billable action.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefBillableBasisType Pick List
         /// </summary>
        public static List<RefBillableBasisType> RefBillableBasisTypePickList = new List<RefBillableBasisType>
        {
            new RefBillableBasisType { Id=Guid.Parse("f3d9c8ef-757e-4af9-a0fd-25f15724e2d7"), Code="FaceToFaceContact", Description="Face-to-Face Contact", SortOrder=Convert.ToDecimal("1.00") },
            new RefBillableBasisType { Id=Guid.Parse("4068cdd3-0197-4b85-a7c9-7d49aaf200db"), Code="EventBased", Description="Event-based", SortOrder=Convert.ToDecimal("2.00") },
            new RefBillableBasisType { Id=Guid.Parse("a0042b0e-a891-4d57-8d39-5ed1c2eb24ca"), Code="TimeBased", Description="Time-based", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
