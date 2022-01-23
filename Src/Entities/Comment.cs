using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostProject.Src.Entities
{
    class Comment
    {

        public string TextComment { get; set; }
        public DateTime DateComment { get; set; } = DateTime.Now;

        public int LikesComment { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public Comment()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="textComment"></param>
        /// <param name="dateComment"></param>
        /// <param name="likesComment"></param>
        public Comment(string textComment, DateTime dateComment, int likesComment)
        {
            TextComment = textComment;
            DateComment = dateComment;
            LikesComment = likesComment;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Comment ( Comment:  " + TextComment 
                + "\n \tLike(s)(" + LikesComment
                + ") Date:" + DateComment +")";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ShowComment()
        {
            return "Comment: " +  TextComment
                          + "\n\t Date: " +  DateComment
                          + "   Like: " + LikesComment + "\n";
        }

    }
}
