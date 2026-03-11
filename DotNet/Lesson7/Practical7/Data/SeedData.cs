using System;
using System.Collections.Generic;
using Practical7.Models;

namespace Practical7.Data
{
    public class SeedData
    {
        public List<Department> Departments { get; set; }
        public List<Group> Groups { get; set; }
        public List<UserProfile> UserProfiles { get; set; }
        public List<UserGroupMembership> UserGroupMemberships { get; set; }

        public static SeedData GetSeed()
        {
            return new SeedData
            {
                Departments = new List<Department>
                {
                    new Department{ Id=1, Name="Computer Science"},
                    new Department{ Id=2, Name="Mathematics"},
                    new Department{ Id=3, Name="Physics"},
                },
                Groups = new List<Group>
                {
                    new Group{ Id=1, Name="CS-201", Year=2, DepartmentId=1 },
                    new Group{ Id=2, Name="CS-202", Year=2, DepartmentId=1 },
                    new Group{ Id=3, Name="CS-301", Year=3, DepartmentId=1 },
                    new Group{ Id=4, Name="MATH-101", Year=1, DepartmentId=2 },
                    new Group{ Id=5, Name="PHYS-201", Year=2, DepartmentId=3 }
                },
                UserProfiles = new List<UserProfile>
                {
                    new UserProfile{ Id=1, FirstName="Arman", LastName="Petrosyan", Email="arman.petrosyan@example.com", Role="Student", IsActive=true },
                    new UserProfile{ Id=2, FirstName="Ani", LastName="Hakobyan", Email="ani.hakobyan@example.com", Role="Student", IsActive=true },
                    new UserProfile{ Id=3, FirstName="David", LastName="Sargsyan", Email="david.sargsyan@example.com", Role="Student", IsActive=true },
                    new UserProfile{ Id=4, FirstName="Mariam", LastName="Karapetyan", Email="mariam.karapetyan@example.com", Role="Student", IsActive=true },
                    new UserProfile{ Id=5, FirstName="Karen", LastName="Ghazaryan", Email="karen.ghazaryan@example.com", Role="Teacher", IsActive=true },
                    new UserProfile{ Id=6, FirstName="Lilit", LastName="Avetisyan", Email="lilit.avetisyan@example.com", Role="Teacher", IsActive=true },
                    new UserProfile{ Id=7, FirstName="Gor", LastName="Mkrtchyan", Email="gor.mkrtchyan@example.com", Role="Student", IsActive=true },
                    new UserProfile{ Id=8, FirstName="Narek", LastName="Stepanyan", Email="narek.stepanyan@example.com", Role="Student", IsActive=true },
                    new UserProfile{ Id=9, FirstName="Anna", LastName="Melkonyan", Email="anna.melkonyan@example.com", Role="Student", IsActive=true },
                    new UserProfile{ Id=10, FirstName="Tigran", LastName="Harutyunyan", Email="tigran.harutyunyan@example.com", Role="Student", IsActive=true }
                },
                UserGroupMemberships = new List<UserGroupMembership>
                {
                    new UserGroupMembership{ Id=1, UserProfileId=1, GroupId=1, IsPrimary=true, FromDate=new DateTime(2024,9,1), ToDate=null },
                    new UserGroupMembership{ Id=2, UserProfileId=2, GroupId=1, IsPrimary=true, FromDate=new DateTime(2024,9,1), ToDate=null },
                    new UserGroupMembership{ Id=3, UserProfileId=3, GroupId=2, IsPrimary=true, FromDate=new DateTime(2024,9,1), ToDate=null },
                    new UserGroupMembership{ Id=4, UserProfileId=4, GroupId=2, IsPrimary=true, FromDate=new DateTime(2024,9,1), ToDate=null },
                    new UserGroupMembership{ Id=5, UserProfileId=7, GroupId=3, IsPrimary=true, FromDate=new DateTime(2024,9,1), ToDate=null },
                    new UserGroupMembership{ Id=6, UserProfileId=8, GroupId=3, IsPrimary=true, FromDate=new DateTime(2024,9,1), ToDate=null },
                    new UserGroupMembership{ Id=7, UserProfileId=9, GroupId=4, IsPrimary=true, FromDate=new DateTime(2024,9,1), ToDate=null },
                    new UserGroupMembership{ Id=8, UserProfileId=10, GroupId=5, IsPrimary=true, FromDate=new DateTime(2024,9,1), ToDate=null },
                    new UserGroupMembership{ Id=9, UserProfileId=5, GroupId=1, IsPrimary=false, FromDate=new DateTime(2024,9,1), ToDate=null },
                    new UserGroupMembership{ Id=10, UserProfileId=5, GroupId=2, IsPrimary=false, FromDate=new DateTime(2024,9,1), ToDate=null },
                    new UserGroupMembership{ Id=11, UserProfileId=6, GroupId=3, IsPrimary=false, FromDate=new DateTime(2024,9,1), ToDate=null },
                    new UserGroupMembership{ Id=12, UserProfileId=6, GroupId=4, IsPrimary=false, FromDate=new DateTime(2024,9,1), ToDate=null }
                }
            };
        }
    }
}