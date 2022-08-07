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
        /// The complete <see cref="RefBillableBasisTypeModel"> List
         /// </summary>
        public static List<RefBillableBasisTypeModel> RefBillableBasisTypeList = new List<RefBillableBasisTypeModel>
        {
            new RefBillableBasisType { Id=Guid.Parse("f49b4fbf-dc3c-4075-8f0e-a16882100283"), Code="FaceToFaceContact", Description="Face-to-Face Contact", Definition="Face-to-Face Contact is specified as the event/action that results in a billable action.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBillableBasisType { Id=Guid.Parse("70862ea0-4696-4a14-95fb-363689638b30"), Code="EventBased", Description="Event-based", Definition="Event-based is specified as the event/action that results in a billable action.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBillableBasisType { Id=Guid.Parse("b5d2618d-d18e-46b5-9046-238894f4a28a"), Code="TimeBased", Description="Time-based", Definition="Time-based is specified as the event/action that results in a billable action.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefBillableBasisType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBillableBasisTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBillableBasisType { Id=Guid.Parse("f49b4fbf-dc3c-4075-8f0e-a16882100283"), Description="Face-to-Face Contact", SortOrder=Convert.ToDecimal("1.00") },
            new RefBillableBasisType { Id=Guid.Parse("70862ea0-4696-4a14-95fb-363689638b30"), Description="Event-based", SortOrder=Convert.ToDecimal("2.00") },
            new RefBillableBasisType { Id=Guid.Parse("b5d2618d-d18e-46b5-9046-238894f4a28a"), Description="Time-based", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
