﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Messages.Events.Course
{
    public class CourseNameChangedEvent
    {
        public string CourseId { get; set; }
        public string UpdatedName { get; set; }
    }
}
