//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentLocationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentLocation Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentLocation"> List
         /// </summary>
        public static List<RefIncidentLocation> RefIncidentLocationList = new List<RefIncidentLocation>
        {
            new RefIncidentLocation { Id=Guid.Parse("1e0f6662-f0b2-4cf3-b806-95e447265f5e"), Code="03011", Description="On campus", Definition="The incident occurred on campus.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentLocation { Id=Guid.Parse("a7b95d8a-5b99-4890-92c4-518155fd9ccc"), Code="03012", Description="Administrative offices area", Definition="The incident occurred in an Administrative offices area.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentLocation { Id=Guid.Parse("5bbb4e4d-f004-4a42-afb4-26f0c3173bae"), Code="03013", Description="Cafeteria area", Definition="The incident occurred in a cafeteria area.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentLocation { Id=Guid.Parse("798e1434-0937-456e-9fba-7975ba2ccd1f"), Code="03014", Description="Classroom", Definition="The incident occurred in a classroom.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentLocation { Id=Guid.Parse("fd644773-2de3-4db5-8b1b-28b0afd24471"), Code="03015", Description="Hallway or stairs", Definition="The incident occurred in a hallway or stairs.", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentLocation { Id=Guid.Parse("ba86d0f9-6d36-4aa2-9960-7e8ae10ecbc5"), Code="03016", Description="Locker room or gym areas", Definition="The incident occurred in locker room or gym areas.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncidentLocation { Id=Guid.Parse("314fc130-16ea-4edb-8308-40ef09981123"), Code="03017", Description="Restroom", Definition="The incident occurred in a restroom.", SortOrder=Convert.ToDecimal("7.00") },
            new RefIncidentLocation { Id=Guid.Parse("a8638cb3-153b-4226-90e5-7c39ff475dac"), Code="03018", Description="Library/media center", Definition="The incident occurred in a library/media center.", SortOrder=Convert.ToDecimal("8.00") },
            new RefIncidentLocation { Id=Guid.Parse("97f8e4a4-0a12-4cd8-8f5a-85a8cc7b1647"), Code="03019", Description="Computer lab", Definition="The incident occurred in a computer lab.", SortOrder=Convert.ToDecimal("9.00") },
            new RefIncidentLocation { Id=Guid.Parse("027b0816-4023-463c-bac8-4d62f0a13eab"), Code="03020", Description="Auditorium", Definition="The incident occurred in an auditorium.", SortOrder=Convert.ToDecimal("10.00") },
            new RefIncidentLocation { Id=Guid.Parse("d4ed93a3-d4fa-42cf-9d2b-9408db81e296"), Code="03021", Description="On-campus other inside area", Definition="The incident occurred on-campus other inside area.", SortOrder=Convert.ToDecimal("11.00") },
            new RefIncidentLocation { Id=Guid.Parse("86542e6b-b466-47dc-8a79-f163a69015ed"), Code="03022", Description="Athletic field or playground", Definition="The incident occurred on an athletic field or playground.", SortOrder=Convert.ToDecimal("12.00") },
            new RefIncidentLocation { Id=Guid.Parse("f3f7ee77-310c-4df1-a550-e06e9114c762"), Code="03023", Description="Stadium", Definition="The incident occurred in a stadium.", SortOrder=Convert.ToDecimal("13.00") },
            new RefIncidentLocation { Id=Guid.Parse("593d0e67-ee06-4c36-9807-c809458ea03d"), Code="03024", Description="Parking lot", Definition="The incident occurred in a parking lot.", SortOrder=Convert.ToDecimal("14.00") },
            new RefIncidentLocation { Id=Guid.Parse("38c6780f-762e-487d-ab5f-706bb86cd6fe"), Code="03025", Description="On-campus other outside area", Definition="The incident occurred in on-campus other outside area.", SortOrder=Convert.ToDecimal("15.00") },
            new RefIncidentLocation { Id=Guid.Parse("0f1a552d-de9c-4516-b222-59d08a405115"), Code="03026", Description="Off campus", Definition="The incident occurred in off campus.", SortOrder=Convert.ToDecimal("16.00") },
            new RefIncidentLocation { Id=Guid.Parse("adf56a6c-daa2-4cb2-8d02-801c51b987b1"), Code="03027", Description="Bus stop", Definition="The incident occurred at a bus stop.", SortOrder=Convert.ToDecimal("17.00") },
            new RefIncidentLocation { Id=Guid.Parse("9cbcd25e-0839-48a4-b392-5c0020a937fc"), Code="03028", Description="School bus", Definition="The incident occurred on a school bus.", SortOrder=Convert.ToDecimal("18.00") },
            new RefIncidentLocation { Id=Guid.Parse("11b9e67c-0c40-4a67-a79e-fe2993e1079c"), Code="03029", Description="Walking to or from school", Definition="The incident occurred walking to or from school.", SortOrder=Convert.ToDecimal("19.00") },
            new RefIncidentLocation { Id=Guid.Parse("1cfa868b-91ba-4fc5-88d8-3f192dd9cfdf"), Code="03030", Description="Off-campus at other school", Definition="The incident occurred off-campus at other school.", SortOrder=Convert.ToDecimal("20.00") },
            new RefIncidentLocation { Id=Guid.Parse("dd441a32-f1c0-405c-995f-491935eece0e"), Code="03031", Description="Off-campus at other school district facility", Definition="The incident occurred off-campus at other school district facility.", SortOrder=Convert.ToDecimal("21.00") },
            new RefIncidentLocation { Id=Guid.Parse("2bba3832-8f8f-4f0f-8181-ad03fe49fbc8"), Code="03413", Description="Online", Definition="The incident occurred online.", SortOrder=Convert.ToDecimal("22.00") },
            new RefIncidentLocation { Id=Guid.Parse("0111cb00-d333-4be3-b654-a95a5d6f7529"), Code="13773", Description="Off-campus at a school sponsored activity", Definition="The incident occurred off-campus at a school sponsored activity.", SortOrder=Convert.ToDecimal("23.00") },
            new RefIncidentLocation { Id=Guid.Parse("e6563dd4-e636-4586-b768-27eb50bc32ae"), Code="13774", Description="Off-campus at another location unrelated to school", Definition="The incident occurred off-campus at another location unrelated to school.", SortOrder=Convert.ToDecimal("24.00") },
            new RefIncidentLocation { Id=Guid.Parse("203907d8-b96b-4f4d-8ee8-690399137802"), Code="09997", Description="Unknown", Definition="The location where the incident occurred is unknown.", SortOrder=Convert.ToDecimal("25.00") },
        };

        /// <summary>
        /// The RefIncidentLocation Pick List
         /// </summary>
        public static List<RefIncidentLocation> RefIncidentLocationPickList = new List<RefIncidentLocation>
        {
            new RefIncidentLocation { Id=Guid.Parse("1e0f6662-f0b2-4cf3-b806-95e447265f5e"), Code="03011", Description="On campus", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentLocation { Id=Guid.Parse("a7b95d8a-5b99-4890-92c4-518155fd9ccc"), Code="03012", Description="Administrative offices area", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentLocation { Id=Guid.Parse("5bbb4e4d-f004-4a42-afb4-26f0c3173bae"), Code="03013", Description="Cafeteria area", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentLocation { Id=Guid.Parse("798e1434-0937-456e-9fba-7975ba2ccd1f"), Code="03014", Description="Classroom", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentLocation { Id=Guid.Parse("fd644773-2de3-4db5-8b1b-28b0afd24471"), Code="03015", Description="Hallway or stairs", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentLocation { Id=Guid.Parse("ba86d0f9-6d36-4aa2-9960-7e8ae10ecbc5"), Code="03016", Description="Locker room or gym areas", SortOrder=Convert.ToDecimal("6.00") },
            new RefIncidentLocation { Id=Guid.Parse("314fc130-16ea-4edb-8308-40ef09981123"), Code="03017", Description="Restroom", SortOrder=Convert.ToDecimal("7.00") },
            new RefIncidentLocation { Id=Guid.Parse("a8638cb3-153b-4226-90e5-7c39ff475dac"), Code="03018", Description="Library/media center", SortOrder=Convert.ToDecimal("8.00") },
            new RefIncidentLocation { Id=Guid.Parse("97f8e4a4-0a12-4cd8-8f5a-85a8cc7b1647"), Code="03019", Description="Computer lab", SortOrder=Convert.ToDecimal("9.00") },
            new RefIncidentLocation { Id=Guid.Parse("027b0816-4023-463c-bac8-4d62f0a13eab"), Code="03020", Description="Auditorium", SortOrder=Convert.ToDecimal("10.00") },
            new RefIncidentLocation { Id=Guid.Parse("d4ed93a3-d4fa-42cf-9d2b-9408db81e296"), Code="03021", Description="On-campus other inside area", SortOrder=Convert.ToDecimal("11.00") },
            new RefIncidentLocation { Id=Guid.Parse("86542e6b-b466-47dc-8a79-f163a69015ed"), Code="03022", Description="Athletic field or playground", SortOrder=Convert.ToDecimal("12.00") },
            new RefIncidentLocation { Id=Guid.Parse("f3f7ee77-310c-4df1-a550-e06e9114c762"), Code="03023", Description="Stadium", SortOrder=Convert.ToDecimal("13.00") },
            new RefIncidentLocation { Id=Guid.Parse("593d0e67-ee06-4c36-9807-c809458ea03d"), Code="03024", Description="Parking lot", SortOrder=Convert.ToDecimal("14.00") },
            new RefIncidentLocation { Id=Guid.Parse("38c6780f-762e-487d-ab5f-706bb86cd6fe"), Code="03025", Description="On-campus other outside area", SortOrder=Convert.ToDecimal("15.00") },
            new RefIncidentLocation { Id=Guid.Parse("0f1a552d-de9c-4516-b222-59d08a405115"), Code="03026", Description="Off campus", SortOrder=Convert.ToDecimal("16.00") },
            new RefIncidentLocation { Id=Guid.Parse("adf56a6c-daa2-4cb2-8d02-801c51b987b1"), Code="03027", Description="Bus stop", SortOrder=Convert.ToDecimal("17.00") },
            new RefIncidentLocation { Id=Guid.Parse("9cbcd25e-0839-48a4-b392-5c0020a937fc"), Code="03028", Description="School bus", SortOrder=Convert.ToDecimal("18.00") },
            new RefIncidentLocation { Id=Guid.Parse("11b9e67c-0c40-4a67-a79e-fe2993e1079c"), Code="03029", Description="Walking to or from school", SortOrder=Convert.ToDecimal("19.00") },
            new RefIncidentLocation { Id=Guid.Parse("1cfa868b-91ba-4fc5-88d8-3f192dd9cfdf"), Code="03030", Description="Off-campus at other school", SortOrder=Convert.ToDecimal("20.00") },
            new RefIncidentLocation { Id=Guid.Parse("dd441a32-f1c0-405c-995f-491935eece0e"), Code="03031", Description="Off-campus at other school district facility", SortOrder=Convert.ToDecimal("21.00") },
            new RefIncidentLocation { Id=Guid.Parse("2bba3832-8f8f-4f0f-8181-ad03fe49fbc8"), Code="03413", Description="Online", SortOrder=Convert.ToDecimal("22.00") },
            new RefIncidentLocation { Id=Guid.Parse("0111cb00-d333-4be3-b654-a95a5d6f7529"), Code="13773", Description="Off-campus at a school sponsored activity", SortOrder=Convert.ToDecimal("23.00") },
            new RefIncidentLocation { Id=Guid.Parse("e6563dd4-e636-4586-b768-27eb50bc32ae"), Code="13774", Description="Off-campus at another location unrelated to school", SortOrder=Convert.ToDecimal("24.00") },
            new RefIncidentLocation { Id=Guid.Parse("203907d8-b96b-4f4d-8ee8-690399137802"), Code="09997", Description="Unknown", SortOrder=Convert.ToDecimal("25.00") },
       };
   }
}
