using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDEMO.Models
{
    public class Card
    {
        public string id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string due { get; set; }
        public string dueComplete { get; set; }
        public bool closed { get; set; }
        public string cover { get; set; }
        public List<string> attachments { get; set; }
        public List<string> members { get; set; }
        public List<string> labels { get; set; }
        public string url { get; set; }
        public string shortLink { get; set; }
        public string idList { get; set; }
        public string idShort { get; set; }
        public DateTime dateLastActivity { get; set; }
        public Badges badges { get; set; }
        public List<string> customFieldItems { get; set; }
    }

    public class Badges
    {
        public int attachments { get; set; }
        public List<string> attachmentsByType { get; set; }
        public int checkItems { get; set; }
        public int checkItemsChecked { get; set; }        
        public int comments { get; set; }
        public bool description{ get; set; }
        public string due { get; set; }
        public bool dueComplete { get; set; }
        public string fogbugz { get; set; }
        public bool subscribed { get; set; }
        public bool viewingMemberVoted { get; set; }
        public int votes { get; set; }
    }
}