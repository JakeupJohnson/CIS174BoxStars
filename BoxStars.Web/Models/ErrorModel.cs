﻿using System;

namespace BoxStars.Web.Models
{
    public class ErrorModel
    {
        public Guid ErrorId { get; set; }
        public DateTime? ErrorDate { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
        public string InnerExceptions { get; set; }//include message from all inner exceptions or if there are none just print "None" in that field.
    }
}