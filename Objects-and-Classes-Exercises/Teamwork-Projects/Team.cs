namespace Teamwork_Projects
{
    using System;
    using System.Collections.Generic;

    public class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members = new List<string>();
    }
}
