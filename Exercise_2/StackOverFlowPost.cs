using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class StackOverFlowPost
    {
        public string title { get; set; }
        public string description { get; set; }
        public DateTime dateTime { get; set; }

        public int vote;
        public StackOverFlowPost(string title,string description)
        {
            this.title = title;
            this.description = description;
            vote = 0;
            dateTime = DateTime.Now;
        }
        public void UpVote()
        {
            vote++;
        }
        public void DownVote()
        {
            vote--;
        }
        public int getVoteValue() { return vote;}
    }
}
