//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCampusResidencyTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefCampusResidencyType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCampusResidencyType"> List
         /// </summary>
        public static List<RefCampusResidencyType> RefCampusResidencyTypeList = new List<RefCampusResidencyType> =
        {
            new RefCampusResidencyType { Id=Guid.Parse("152b6a5c-efc2-4ee3-8935-f29f2c880ccc"), Code="On campus is specified as a person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).", Description="OnCampus", Definition="", SortOrder=0 },
            new RefCampusResidencyType { Id=Guid.Parse("554ac843-c125-4a6d-9a6d-9b0d27093adc"), Code="Off campus, with family is specified as a person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).", Description="OffCampusWFamily", Definition="", SortOrder=0 },
            new RefCampusResidencyType { Id=Guid.Parse("62df8c4d-16e4-47fe-a1b4-e8f4be17679e"), Code="Off campus, without family is specified as a person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).", Description="OffCampusWOFamily", Definition="", SortOrder=0 },
            new RefCampusResidencyType { Id=Guid.Parse("9b0475d0-f4ff-4aa4-940c-0d069a7bf387"), Code="A person's residency arrangement is unknown as defined in the Free Application for Federal Student Aid (FAFSA).", Description="Unknown", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCampusResidencyType Pick List
         /// </summary>
        public static List<RefCampusResidencyType> RefCampusResidencyTypePickList = new List<RefCampusResidencyType> =
        {
            new RefCampusResidencyType { Id=Guid.Parse("152b6a5c-efc2-4ee3-8935-f29f2c880ccc"), Code="On campus is specified as a person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).", SortOrder=0 },
            new RefCampusResidencyType { Id=Guid.Parse("554ac843-c125-4a6d-9a6d-9b0d27093adc"), Code="Off campus, with family is specified as a person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).", SortOrder=0 },
            new RefCampusResidencyType { Id=Guid.Parse("62df8c4d-16e4-47fe-a1b4-e8f4be17679e"), Code="Off campus, without family is specified as a person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).", SortOrder=0 },
            new RefCampusResidencyType { Id=Guid.Parse("9b0475d0-f4ff-4aa4-940c-0d069a7bf387"), Code="A person's residency arrangement is unknown as defined in the Free Application for Federal Student Aid (FAFSA).", SortOrder=0 },
       };
   }
}
