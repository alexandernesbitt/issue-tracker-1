﻿namespace Case.IssueTracker.Data
{
    public class UpdateAuthor
    {
        public string self { get; set; }
        public string name { get; set; }
        public string emailAddress { get; set; }
        public AvatarUrls avatarUrls { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
    }
}
