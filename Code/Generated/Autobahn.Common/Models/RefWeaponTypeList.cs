//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefWeaponTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefWeaponType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefWeaponType"> List
         /// </summary>
        public static List<RefWeaponType> RefWeaponTypeList = new List<RefWeaponType> =
        {
            new RefWeaponType { Id=Guid.Parse("752b1d94-1cc4-41c7-9717-5ffcd0bd84d9"), Code="Any weapon (including a starter gun) which will or is designed to or may readily be converted to expel a projectile by the action of an explosive;  the frame or receiver of any such weapon; any firearm muffler or firearm silencer; or any destructive device.", Description="Firearm", Definition="", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("1688a35a-b5d0-4405-88c0-0eb2b730e3e7"), Code="Any firearm which has a short stock and is designed to be held and fired by the use of a single hand.", Description="Handgun", Definition="", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("ce70b35d-1f76-4ffb-a932-3626902baafa"), Code="A weapon designed or redesigned, made or remade, and intended to be fired from the shoulder and designed or redesigned and made or remade to use the  energy of an explosive to fire through a smooth bore either a number of ball shots or a single projectile for each single pull of the trigger.", Description="Shotgun", Definition="", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("03ebdbbd-0350-4b64-ac61-95bba08a7924"), Code="A weapon designed or redesigned, made or remade, and intended to be fired from the shoulder and designed or redesigned and made or remade to use the energy of an explosive to fire only a single projectile through a rifled bore for each single pull of the trigger.", Description="Rifle", Definition="", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("60960ce2-e3cd-4db5-93df-200fec032b8f"), Code="Other type of firearm", Description="OtherFirearm", Definition="", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("b184f7ae-d1f9-485e-848c-c3f65b2dfb77"), Code="The weapon involved was a knife.", Description="Knife", Definition="", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("3b46fc74-09b8-4c98-8050-a53e069164f1"), Code="Knife with blade length less than 2.5 inches - the weapon involved was a knife with a blade less than 2.5 inches in length.", Description="KnifeLessThanTwoPointFiveInches", Definition="", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("c032841f-c71c-4e67-a2a5-a1d6d26390a8"), Code="Knife with blade length less than 3 inches in length - the weapon involved was a knife with a blade at least 2.5 inches in length, but less than 3 inches in length.", Description="KnifeLessThanThreeInches", Definition="", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("62c7efbd-1f58-4f7e-882c-bc4c5e11bbb3"), Code="Knife with blade length greater than or equal to 3 inches - the weapon involved was a knife with a blade 3 inches or greater in length.", Description="KnifeGreaterThanThreeInches", Definition="", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("f35152b0-39d4-4f55-826c-b8f8192624f8"), Code="The weapon involved was another type of sharp object, (e.g., razor blade, ice pick, dirk, Chinese star, other pointed instrument [used as a weapon]).", Description="OtherSharpObject", Definition="", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("063cc232-21e7-479e-be70-09b8ecad5631"), Code="The weapon involved was another known object (e.g., chain, nunchakus, brass knuckle, billy club, electrical weapon or device [stun gun], BB or pellet gun).", Description="OtherObject", Definition="", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("a3086127-1d62-48c0-914e-e4ee42ac7fb6"), Code="The weapon involved was a substance (e.g., mace, tear gas) that was used as a weapon.", Description="Substance", Definition="", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("21a4e763-ea5e-45d8-bcf3-a5f6293b35ba"), Code="The incident involved a weapon other than those described above.", Description="OtherWeapon", Definition="", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("8a65f392-f053-4668-b76e-5d86bb8cbdc2"), Code="No weapon was used in the incident", Description="None", Definition="", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("a5df64fb-0213-4a83-aa99-725cb345e8db"), Code="A weapon was used in the incident, but the type is unknown.", Description="Unknown", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefWeaponType Pick List
         /// </summary>
        public static List<RefWeaponType> RefWeaponTypePickList = new List<RefWeaponType> =
        {
            new RefWeaponType { Id=Guid.Parse("752b1d94-1cc4-41c7-9717-5ffcd0bd84d9"), Code="Any weapon (including a starter gun) which will or is designed to or may readily be converted to expel a projectile by the action of an explosive;  the frame or receiver of any such weapon; any firearm muffler or firearm silencer; or any destructive device.", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("1688a35a-b5d0-4405-88c0-0eb2b730e3e7"), Code="Any firearm which has a short stock and is designed to be held and fired by the use of a single hand.", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("ce70b35d-1f76-4ffb-a932-3626902baafa"), Code="A weapon designed or redesigned, made or remade, and intended to be fired from the shoulder and designed or redesigned and made or remade to use the  energy of an explosive to fire through a smooth bore either a number of ball shots or a single projectile for each single pull of the trigger.", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("03ebdbbd-0350-4b64-ac61-95bba08a7924"), Code="A weapon designed or redesigned, made or remade, and intended to be fired from the shoulder and designed or redesigned and made or remade to use the energy of an explosive to fire only a single projectile through a rifled bore for each single pull of the trigger.", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("60960ce2-e3cd-4db5-93df-200fec032b8f"), Code="Other type of firearm", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("b184f7ae-d1f9-485e-848c-c3f65b2dfb77"), Code="The weapon involved was a knife.", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("3b46fc74-09b8-4c98-8050-a53e069164f1"), Code="Knife with blade length less than 2.5 inches - the weapon involved was a knife with a blade less than 2.5 inches in length.", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("c032841f-c71c-4e67-a2a5-a1d6d26390a8"), Code="Knife with blade length less than 3 inches in length - the weapon involved was a knife with a blade at least 2.5 inches in length, but less than 3 inches in length.", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("62c7efbd-1f58-4f7e-882c-bc4c5e11bbb3"), Code="Knife with blade length greater than or equal to 3 inches - the weapon involved was a knife with a blade 3 inches or greater in length.", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("f35152b0-39d4-4f55-826c-b8f8192624f8"), Code="The weapon involved was another type of sharp object, (e.g., razor blade, ice pick, dirk, Chinese star, other pointed instrument [used as a weapon]).", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("063cc232-21e7-479e-be70-09b8ecad5631"), Code="The weapon involved was another known object (e.g., chain, nunchakus, brass knuckle, billy club, electrical weapon or device [stun gun], BB or pellet gun).", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("a3086127-1d62-48c0-914e-e4ee42ac7fb6"), Code="The weapon involved was a substance (e.g., mace, tear gas) that was used as a weapon.", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("21a4e763-ea5e-45d8-bcf3-a5f6293b35ba"), Code="The incident involved a weapon other than those described above.", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("8a65f392-f053-4668-b76e-5d86bb8cbdc2"), Code="No weapon was used in the incident", SortOrder=0 },
            new RefWeaponType { Id=Guid.Parse("a5df64fb-0213-4a83-aa99-725cb345e8db"), Code="A weapon was used in the incident, but the type is unknown.", SortOrder=0 },
       };
   }
}
