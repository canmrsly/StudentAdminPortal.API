using StudentAdminPortal.API.DataModels;
using System;

namespace StudentAdminPortal.API.DomainModels
{
    public class Student
    {
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Email { get; set; }
        public long Mobile { get; set; }
        public String ProfileImageUrl { get; set; }

        //nav prop  
        public Guid GenderId { get; set; }
        public Gender Gender { get; set; }
        public Adress Adress { get; set; }
    }
}
