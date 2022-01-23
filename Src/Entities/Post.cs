using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostProject.Src.Entities
{
    class Post
    {
        /// <summary>
        /// composition relationship - with Class Comment
        /// </summary>
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public string Title { get; set; }

        public string Content { get; set; }
        public DateTime DatePost { get; set; } = DateTime.Now;

        public int Likes { get; set; } = 0;

        public Post(string title, string content, DateTime datePost, int likes)
        {
            Title = title;
            Content = content;
            DatePost = datePost;
            Likes = likes;
        }

        public override string ToString()
        {

         
            return  "Post ( Title:  "+ Title 
                    +"\nContet:"+ Content + "\n\t" 
                     + "Like(s) "+ Likes+"\tDate Post:"
                    + DatePost + ")";
        }




        public void AddComment (Comment commentPost){

            Comments.Add(commentPost);
        }

        public string ShowListComments()
        {

            string post = "";
            foreach (var itemComment in Comments)
            {
                post += itemComment.ShowComment();
            }

            return post;
        }
        public string ShowPost()
        {

            string post = "Post ( Title:  " + Title
                    + "\nContet:" + Content + "\n\t"
                     + "Like(s) " + Likes + "\tDate Post:"
                    + DatePost + ")\n ----\n ";
            foreach (var itemComment in Comments)
            {
                post += itemComment.ShowComment();
            }

            return ToString() + post;
        }
    }
}
