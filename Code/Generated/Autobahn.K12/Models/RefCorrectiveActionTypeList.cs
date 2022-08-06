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
        public static List<RefCorrectiveActionType> RefCorrectiveActionTypeList = new List<RefCorrectiveActionType> =
        {
            new RefCorrectiveActionType { Id=Guid.Parse("d227e945-84eb-4294-9a48-bd6830323ad6"), Code="A corrective action requiring implementation of a new research-based curriculum or instructional program.", Description="CA1", Definition="", SortOrder=0 },
            new RefCorrectiveActionType { Id=Guid.Parse("5169000d-2c9a-44a3-b8ec-9af997e88d9b"), Code="A corrective action requiring extension of the school year or school day.", Description="CA2", Definition="", SortOrder=0 },
            new RefCorrectiveActionType { Id=Guid.Parse("1ed73db3-0e1a-4c5e-9638-3e833a288d00"), Code="A corrective action requiring replacement of staff members relevant to the school's low performance.", Description="CA3", Definition="", SortOrder=0 },
            new RefCorrectiveActionType { Id=Guid.Parse("670bf139-a689-4693-a879-9634ba304646"), Code="A corrective action requiring significant decrease in management authority at the school level.", Description="CA4", Definition="", SortOrder=0 },
            new RefCorrectiveActionType { Id=Guid.Parse("5ba74f10-8432-4985-a795-0bb5e074f668"), Code="A corrective action requiring replacement of the principal.", Description="CA5", Definition="", SortOrder=0 },
            new RefCorrectiveActionType { Id=Guid.Parse("0da506ae-6f4e-428b-847f-0ff4284a6340"), Code="A corrective action requiring restructuring of the internal organization of the school.", Description="CA6", Definition="", SortOrder=0 },
            new RefCorrectiveActionType { Id=Guid.Parse("526e7c77-5b9d-4942-a775-5974afbfd3f9"), Code="A corrective action requiring appointment of an outside expert to advise the school.", Description="CA7", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCorrectiveActionType Pick List
         /// </summary>
        public static List<RefCorrectiveActionType> RefCorrectiveActionTypePickList = new List<RefCorrectiveActionType> =
        {
            new RefCorrectiveActionType { Id=Guid.Parse("d227e945-84eb-4294-9a48-bd6830323ad6"), Code="A corrective action requiring implementation of a new research-based curriculum or instructional program.", SortOrder=0 },
            new RefCorrectiveActionType { Id=Guid.Parse("5169000d-2c9a-44a3-b8ec-9af997e88d9b"), Code="A corrective action requiring extension of the school year or school day.", SortOrder=0 },
            new RefCorrectiveActionType { Id=Guid.Parse("1ed73db3-0e1a-4c5e-9638-3e833a288d00"), Code="A corrective action requiring replacement of staff members relevant to the school's low performance.", SortOrder=0 },
            new RefCorrectiveActionType { Id=Guid.Parse("670bf139-a689-4693-a879-9634ba304646"), Code="A corrective action requiring significant decrease in management authority at the school level.", SortOrder=0 },
            new RefCorrectiveActionType { Id=Guid.Parse("5ba74f10-8432-4985-a795-0bb5e074f668"), Code="A corrective action requiring replacement of the principal.", SortOrder=0 },
            new RefCorrectiveActionType { Id=Guid.Parse("0da506ae-6f4e-428b-847f-0ff4284a6340"), Code="A corrective action requiring restructuring of the internal organization of the school.", SortOrder=0 },
            new RefCorrectiveActionType { Id=Guid.Parse("526e7c77-5b9d-4942-a775-5974afbfd3f9"), Code="A corrective action requiring appointment of an outside expert to advise the school.", SortOrder=0 },
       };
   }
}
