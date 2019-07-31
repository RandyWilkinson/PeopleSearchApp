﻿using Microsoft.EntityFrameworkCore;
using PeopleSearchApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleSearchApi.Repositories
{
    public interface IPeopleRepository
    {
        DbSet<Person> Persons { get; set; }

    }
}