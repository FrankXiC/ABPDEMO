﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace TESTABP
{
    [Table("AppPersons")]
    public class Person : Entity, IHasCreationTime {
        public const int MaxNameLength = 32;

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
        public Person() {

        }

        public Person(string name) {
            Name = name;
        }
    }
}
