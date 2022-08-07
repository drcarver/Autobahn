//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefReasonDelayTransitionConfList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefReasonDelayTransitionConf Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefReasonDelayTransitionConfModel"> List
         /// </summary>
        public static List<RefReasonDelayTransitionConfModel> RefReasonDelayTransitionConfList = new List<RefReasonDelayTransitionConfModel>
        {
            new RefReasonDelayTransitionConf { Id=Guid.Parse("4dae8fac-f141-4f3d-9d32-85dde1ad5cb5"), Code="Family", Description="Family", Definition="The reasons for the delay of a transition conference is attributed to the family.", SortOrder=Convert.ToDecimal("2.00") },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("6c421de6-d912-43e8-9d37-16f47ed5b52f"), Code="Program", Description="Program", Definition="The reasons for the delay of a transition conference is attributed to the program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("33a56011-0d95-45f8-9f3b-d6080ba54e91"), Code="BeyondProgramControl", Description="Other beyond the control of the program", Definition="The reasons for the delay of a transition conference is other, beyond the control of the program.", SortOrder=Convert.ToDecimal("6.00") },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("1dc77351-31b6-4372-9d38-26b866e7ca1f"), Code="Promotion", Description="Promotion or advancement", Definition="The reasons for the delay of a transition conference is attributed to promotion or advancement.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefReasonDelayTransitionConf Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefReasonDelayTransitionConfViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefReasonDelayTransitionConf { Id=Guid.Parse("4dae8fac-f141-4f3d-9d32-85dde1ad5cb5"), Description="Family", SortOrder=Convert.ToDecimal("2.00") },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("6c421de6-d912-43e8-9d37-16f47ed5b52f"), Description="Program", SortOrder=Convert.ToDecimal("4.00") },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("33a56011-0d95-45f8-9f3b-d6080ba54e91"), Description="Other beyond the control of the program", SortOrder=Convert.ToDecimal("6.00") },
            new RefReasonDelayTransitionConf { Id=Guid.Parse("1dc77351-31b6-4372-9d38-26b866e7ca1f"), Description="Promotion or advancement", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
