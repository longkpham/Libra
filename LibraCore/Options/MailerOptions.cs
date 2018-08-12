﻿using System;
using System.Collections.Generic;

namespace LibraCore.Options
{
    public class MailerOptions
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Pwd { get; set; }
        public string Suffix { get; set; }
        public IEnumerable<string> Receivers { get; set; }
        public bool Disabled { get; set; }
    }
}
