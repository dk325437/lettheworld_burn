using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace lettheworld_burn
{
    public class Schedule
    {
        public DateTime Time { get; set; }
        public string Content { get; set; }
        public Editor Editor { get; set; }

        public Schedule() { }
        public Schedule(DateTime time, string content, Editor editor)
        {
            Time = time;
            Content = content;
            Editor = editor;
        }
    }

}