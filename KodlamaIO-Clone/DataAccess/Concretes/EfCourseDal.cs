﻿using Core.DataAccess.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, KodlamaIoContext>
    {
    }
}
