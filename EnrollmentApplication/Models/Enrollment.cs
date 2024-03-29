﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }
        public virtual string Grade { get; set; }
        public virtual string StudentObj { get; set; }
        public virtual string CourseObj { get; set; }        
    }
}