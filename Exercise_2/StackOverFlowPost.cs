using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class StackOverFlowPost
    {
         string title { get; set; }
         string description { get; set; }
         DateTime dateTime { get; set; }

         int vote;
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
