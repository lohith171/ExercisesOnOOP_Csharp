

/*Design a class called Post.This class models a StackOverflow post.It should have properties
for title, description and the date/time it was created.We should be able to up-vote or down-vote
a post.We should also be able to see the current vote value.In the main method, create a post,
up-vote and down-vote it a few times and then display the the current vote value*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a title");
            string title =Console.ReadLine();
            Console.WriteLine("Please enter a description");
            string description = Console.ReadLine();
            StackOverFlowPost obj = new StackOverFlowPost(title,description);
            
            string input = Console.ReadLine();
            while (input != "")
            {
                if (input == "1") obj.UpVote();
                else if (input == "2") obj.DownVote();
                else if(input=="3") Console.WriteLine("Current Vote Value is: " + obj.getVoteValue());
                else Console.WriteLine("Please enter valid input");
                input = Console.ReadLine();
            }
            
            
            Console.ReadLine();
        }
    }
}
