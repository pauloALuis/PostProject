using PostProject.Src.Entities;
using System;

namespace PostProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Post and comments ");

            Console.WriteLine("------------Post -------------");
            Console.WriteLine("Moment: (21/06/2022 13:15:00)");
            var moment = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Title : (Traveling to Angola)");
            string title = Console.ReadLine();


            Console.WriteLine("Content : (Im going to visit this wonderful country!)");
            string content = Console.ReadLine();

            Console.WriteLine("Like : (1)");
            int like = int.Parse ( Console.ReadLine());

            Post post = new Post(datePost:  moment, content: content, title:title, likes:like);




            Console.WriteLine("How many post you want to insert?");
            int numberPost = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberPost; i++)
            {

                Console.Write($"Comment #{i +1} :");
                string comment = Console.ReadLine();

                Console.WriteLine($"Date #{i +1}: (21/06/2022 13:15:00)");
                var dateComment = DateTime.Parse(Console.ReadLine());

                Console.WriteLine($"Like comment #{i+1}: (1)");
                 like = int.Parse(Console.ReadLine());

                //create comments
                Comment comments = new Comment(textComment: comment, dateComment: dateComment, likesComment:like);


                post.AddComment(comments);
            }


            Console.WriteLine("\n\n --------------Show Post---------------------------------------");
            Console.WriteLine("" + post);

            Console.WriteLine("\n Show Comment");
            //post.ShowListComments();
            Console.WriteLine("" + post.ShowListComments());
            Console.WriteLine("---------------------------------------");





        }
    }
}
