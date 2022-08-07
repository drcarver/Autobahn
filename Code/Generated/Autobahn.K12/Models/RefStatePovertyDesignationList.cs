//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefStatePovertyDesignationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefStatePovertyDesignation Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefStatePovertyDesignationModel"> List
         /// </summary>
        public static List<RefStatePovertyDesignationModel> RefStatePovertyDesignationList = new List<RefStatePovertyDesignationModel>
        {
            new RefStatePovertyDesignation { Id=Guid.Parse("8b53dbc1-2018-41de-8113-2bab65f7bc90"), Code="HighQuartile", Description=" High poverty quartile school", Definition="The school is a high poverty quartile school according to state's indicator of poverty.", SortOrder=Convert.ToDecimal("1.00") },
            new RefStatePovertyDesignation { Id=Guid.Parse("b90184f0-0cc8-4ebd-8c69-9a3377c0bf7b"), Code="LowQuartile", Description="Low poverty quartile school", Definition="The school is a low poverty quartile school according to state's indicator of poverty.", SortOrder=Convert.ToDecimal("2.00") },
            new RefStatePovertyDesignation { Id=Guid.Parse("1f0b80d0-3856-452a-a1f2-a6609ab25bec"), Code="Neither", Description="Neither high nor low poverty quartile school", Definition="The school is neither high nor low poverty quartile school according to state's indicator of poverty.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefStatePovertyDesignation Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefStatePovertyDesignationViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefStatePovertyDesignation { Id=Guid.Parse("8b53dbc1-2018-41de-8113-2bab65f7bc90"), Description=" High poverty quartile school", SortOrder=Convert.ToDecimal("1.00") },
            new RefStatePovertyDesignation { Id=Guid.Parse("b90184f0-0cc8-4ebd-8c69-9a3377c0bf7b"), Description="Low poverty quartile school", SortOrder=Convert.ToDecimal("2.00") },
            new RefStatePovertyDesignation { Id=Guid.Parse("1f0b80d0-3856-452a-a1f2-a6609ab25bec"), Description="Neither high nor low poverty quartile school", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
