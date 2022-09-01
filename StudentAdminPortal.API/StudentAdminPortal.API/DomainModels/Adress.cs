﻿using System;

namespace StudentAdminPortal.API.DomainModels
{
    public class Adress
    {
        public Guid Id { get; set; }
        public String PhysicalAdress { get; set; }
        public String PostalAdress { get; set; }

        //navigation prop
        public Guid StudentId { get; set; }
    }
}
