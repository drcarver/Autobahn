//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingJointUseRationaleTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingJointUseRationaleType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingJointUseRationaleTypeModel"> List
         /// </summary>
        public static List<RefBuildingJointUseRationaleTypeModel> RefBuildingJointUseRationaleTypeList = new List<RefBuildingJointUseRationaleTypeModel>
        {
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("91db2a9f-bc06-4480-b160-967050f35fcd"), Code="13710", Description="Increase programs and services for students", Definition="Increase programs and services for students is specified as the reasons for permitting and participating in joint-use.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("1e107a5a-25b2-4111-b1b0-5ff0669fa43b"), Code="13711", Description="Increase programs and services for the community", Definition="Increase programs and services for the community is specified as the reasons for permitting and participating in joint-use.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("d97413b9-b8ab-43d8-a317-895eec29974a"), Code="13712", Description="Increase utilization of under used space", Definition="Increase utilization of under used space is specified as the reasons for permitting and participating in joint-use.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("7d248557-e5a0-49c6-9306-68faa8a3031b"), Code="13709", Description="Raise revenue", Definition="Raise revenue is specified as the reasons for permitting and participating in joint-use.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefBuildingJointUseRationaleType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingJointUseRationaleTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("91db2a9f-bc06-4480-b160-967050f35fcd"), Description="Increase programs and services for students", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("1e107a5a-25b2-4111-b1b0-5ff0669fa43b"), Description="Increase programs and services for the community", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("d97413b9-b8ab-43d8-a317-895eec29974a"), Description="Increase utilization of under used space", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("7d248557-e5a0-49c6-9306-68faa8a3031b"), Description="Raise revenue", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
