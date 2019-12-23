using System;

namespace StackOverFlowPost
{
    class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Created { get; private set; }
        private int _vote;
        public int Vote
        {
            get { return _vote; }
            set {
                
                if (value > 0)
                {
                    _vote = value;
                }
                else
                {
                    _vote = 0;
                }
            }
        }

        public Post(string title, string description, DateTime created)
        {
            Title = title;
            Description = description;
            Created = created;
            Vote = 0;
        }

        public void UpVote()
        {
            Vote++;
        }

        public void DownVote()
        {
            Vote--;
        }
        public void DisplayCurrentVote() {
            Console.WriteLine($"Current vote: {Vote}");
        }
    }
}
