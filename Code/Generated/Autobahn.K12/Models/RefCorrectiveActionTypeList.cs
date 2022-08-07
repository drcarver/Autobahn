//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefCorrectiveActionTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefCorrectiveActionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCorrectiveActionTypeModel"> List
         /// </summary>
        public static List<RefCorrectiveActionTypeModel> RefCorrectiveActionTypeList = new List<RefCorrectiveActionTypeModel>
        {
            new RefCorrectiveActionType { Id=Guid.Parse("fe4e5899-89cb-4d4a-a41f-db02d4e4896e"), Code="CA1", Description="Required implementation of a new research-based curriculum or instructional program", Definition="A corrective action requiring implementation of a new research-based curriculum or instructional program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("7dfa6262-05b9-4bcc-a158-1e95400928dc"), Code="CA2", Description="Extension of the school year or school day ", Definition="A corrective action requiring extension of the school year or school day.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("2dc47635-8822-4da4-8916-9de9c3b18841"), Code="CA3", Description="Replacement of staff members relevant to the school's low performance", Definition="A corrective action requiring replacement of staff members relevant to the school's low performance.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("dfbda8d1-14ba-4316-af57-276933d6ed5e"), Code="CA4", Description="Significant decrease in management authority at the school level", Definition="A corrective action requiring significant decrease in management authority at the school level.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("5d0299e7-ba63-4ad3-a45f-3ccc77d81fb4"), Code="CA5", Description="Replacement of the principal", Definition="A corrective action requiring replacement of the principal.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("dd31571b-7c94-45f5-9580-f2dac6ae5d2d"), Code="CA6", Description="Restructuring of the internal organization of the school", Definition="A corrective action requiring restructuring of the internal organization of the school.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("4f65b107-4447-426f-983d-28b1ef875bfa"), Code="CA7", Description="Appointment of an outside expert to advise the school", Definition="A corrective action requiring appointment of an outside expert to advise the school.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefCorrectiveActionType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCorrectiveActionTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCorrectiveActionType { Id=Guid.Parse("fe4e5899-89cb-4d4a-a41f-db02d4e4896e"), Description="Required implementation of a new research-based curriculum or instructional program", SortOrder=Convert.ToDecimal("1.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("7dfa6262-05b9-4bcc-a158-1e95400928dc"), Description="Extension of the school year or school day ", SortOrder=Convert.ToDecimal("2.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("2dc47635-8822-4da4-8916-9de9c3b18841"), Description="Replacement of staff members relevant to the school's low performance", SortOrder=Convert.ToDecimal("3.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("dfbda8d1-14ba-4316-af57-276933d6ed5e"), Description="Significant decrease in management authority at the school level", SortOrder=Convert.ToDecimal("4.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("5d0299e7-ba63-4ad3-a45f-3ccc77d81fb4"), Description="Replacement of the principal", SortOrder=Convert.ToDecimal("5.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("dd31571b-7c94-45f5-9580-f2dac6ae5d2d"), Description="Restructuring of the internal organization of the school", SortOrder=Convert.ToDecimal("6.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("4f65b107-4447-426f-983d-28b1ef875bfa"), Description="Appointment of an outside expert to advise the school", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
