using System;

namespace BugBox.Models

{
    public class MDPMenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }
    }
}