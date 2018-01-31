﻿using System.Runtime.Serialization;

namespace Umbraco.Web.Models
{
    [DataContract(Name = "step", Namespace = "")]
    public class BackOfficeTourStep
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }
        [DataMember(Name = "content")]
        public string Content { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "element")]
        public string Element { get; set; }
        [DataMember(Name = "elementPreventClick")]
        public bool ElementPreventClick { get; set; }
        [DataMember(Name = "backdropOpacity")]
        public float BackdropOpacity { get; set; }
        [DataMember(Name = "event")]
        public string Event { get; set; }
    }
}