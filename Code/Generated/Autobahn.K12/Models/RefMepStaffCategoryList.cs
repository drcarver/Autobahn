//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefMepStaffCategoryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefMepStaffCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepStaffCategory"> List
         /// </summary>
        public static List<RefMepStaffCategory> RefMepStaffCategoryList = new List<RefMepStaffCategory> =
        {
            new RefMepStaffCategory { Id=Guid.Parse("8ad2f208-0b62-4507-be72-43602063c728"), Code="Teachers is the category of staff working in the Migrant Education Program.", Description="Teachers", Definition="", SortOrder=0 },
            new RefMepStaffCategory { Id=Guid.Parse("ffb9f14c-55e7-4798-a490-e15b826077f1"), Code="Paraprofessionals  is the category of staff working in the Migrant Education Program.", Description="Paraprofessionals", Definition="", SortOrder=0 },
            new RefMepStaffCategory { Id=Guid.Parse("2971acb5-5d08-4714-935a-f0c398167b85"), Code="Counselors is the category of staff working in the Migrant Education Program.", Description="Counselors", Definition="", SortOrder=0 },
            new RefMepStaffCategory { Id=Guid.Parse("260b0b26-881e-40a0-a85b-8ba8f2a148f2"), Code="Administrators is the category of staff working in the Migrant Education Program.", Description="Administrators", Definition="", SortOrder=0 },
            new RefMepStaffCategory { Id=Guid.Parse("506d5025-efb7-4dec-8d11-f8d4511a1535"), Code="Recruiters is the category of staff working in the Migrant Education Program.", Description="Recruiters", Definition="", SortOrder=0 },
            new RefMepStaffCategory { Id=Guid.Parse("f539e404-1069-4662-bb09-55e9a06d03e4"), Code="Records Transfer Staff is the category of staff working in the Migrant Education Program.", Description="RecordsTransferStaff", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefMepStaffCategory Pick List
         /// </summary>
        public static List<RefMepStaffCategory> RefMepStaffCategoryPickList = new List<RefMepStaffCategory> =
        {
            new RefMepStaffCategory { Id=Guid.Parse("8ad2f208-0b62-4507-be72-43602063c728"), Code="Teachers is the category of staff working in the Migrant Education Program.", SortOrder=0 },
            new RefMepStaffCategory { Id=Guid.Parse("ffb9f14c-55e7-4798-a490-e15b826077f1"), Code="Paraprofessionals  is the category of staff working in the Migrant Education Program.", SortOrder=0 },
            new RefMepStaffCategory { Id=Guid.Parse("2971acb5-5d08-4714-935a-f0c398167b85"), Code="Counselors is the category of staff working in the Migrant Education Program.", SortOrder=0 },
            new RefMepStaffCategory { Id=Guid.Parse("260b0b26-881e-40a0-a85b-8ba8f2a148f2"), Code="Administrators is the category of staff working in the Migrant Education Program.", SortOrder=0 },
            new RefMepStaffCategory { Id=Guid.Parse("506d5025-efb7-4dec-8d11-f8d4511a1535"), Code="Recruiters is the category of staff working in the Migrant Education Program.", SortOrder=0 },
            new RefMepStaffCategory { Id=Guid.Parse("f539e404-1069-4662-bb09-55e9a06d03e4"), Code="Records Transfer Staff is the category of staff working in the Migrant Education Program.", SortOrder=0 },
       };
   }
}
