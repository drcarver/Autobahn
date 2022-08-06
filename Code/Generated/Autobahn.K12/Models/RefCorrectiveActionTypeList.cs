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
        /// The complete <see cref="RefCorrectiveActionType"> List
         /// </summary>
        public static List<RefCorrectiveActionType> RefCorrectiveActionTypeList = new List<RefCorrectiveActionType>
        {
            new RefCorrectiveActionType { Id=Guid.Parse("3646cd5c-632a-42ee-b204-e442e0f5ab12"), Code="CA1", Description="Required implementation of a new research-based curriculum or instructional program", Definition="A corrective action requiring implementation of a new research-based curriculum or instructional program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("646daf3e-a07a-4092-aa8b-c511d3727bcc"), Code="CA2", Description="Extension of the school year or school day ", Definition="A corrective action requiring extension of the school year or school day.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("0f0553ce-c6c2-428c-864b-5234c0d56357"), Code="CA3", Description="Replacement of staff members relevant to the school's low performance", Definition="A corrective action requiring replacement of staff members relevant to the school's low performance.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("d5894585-c474-4e8a-883a-91e5660ea478"), Code="CA4", Description="Significant decrease in management authority at the school level", Definition="A corrective action requiring significant decrease in management authority at the school level.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("4e8ce446-8189-48c1-b185-890afb429856"), Code="CA5", Description="Replacement of the principal", Definition="A corrective action requiring replacement of the principal.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("440af47d-0dbb-41ad-b303-3a9e47abaf05"), Code="CA6", Description="Restructuring of the internal organization of the school", Definition="A corrective action requiring restructuring of the internal organization of the school.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("7aef3539-924c-43b9-a390-4d442544e07f"), Code="CA7", Description="Appointment of an outside expert to advise the school", Definition="A corrective action requiring appointment of an outside expert to advise the school.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefCorrectiveActionType Pick List
         /// </summary>
        public static List<RefCorrectiveActionType> RefCorrectiveActionTypePickList = new List<RefCorrectiveActionType>
        {
            new RefCorrectiveActionType { Id=Guid.Parse("3646cd5c-632a-42ee-b204-e442e0f5ab12"), Code="CA1", Description="Required implementation of a new research-based curriculum or instructional program", SortOrder=Convert.ToDecimal("1.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("646daf3e-a07a-4092-aa8b-c511d3727bcc"), Code="CA2", Description="Extension of the school year or school day ", SortOrder=Convert.ToDecimal("2.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("0f0553ce-c6c2-428c-864b-5234c0d56357"), Code="CA3", Description="Replacement of staff members relevant to the school's low performance", SortOrder=Convert.ToDecimal("3.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("d5894585-c474-4e8a-883a-91e5660ea478"), Code="CA4", Description="Significant decrease in management authority at the school level", SortOrder=Convert.ToDecimal("4.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("4e8ce446-8189-48c1-b185-890afb429856"), Code="CA5", Description="Replacement of the principal", SortOrder=Convert.ToDecimal("5.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("440af47d-0dbb-41ad-b303-3a9e47abaf05"), Code="CA6", Description="Restructuring of the internal organization of the school", SortOrder=Convert.ToDecimal("6.00") },
            new RefCorrectiveActionType { Id=Guid.Parse("7aef3539-924c-43b9-a390-4d442544e07f"), Code="CA7", Description="Appointment of an outside expert to advise the school", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
