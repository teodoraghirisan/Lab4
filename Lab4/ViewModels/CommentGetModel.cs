using Lab4.Models;

namespace Lab4.ViewModels
{
    public class CommentGetModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Important { get; set; }
        public int? ExpenseId { get; set; }
      


        public static CommentGetModel FromComment(Comment c)
        {
            return new CommentGetModel
            {
                Id = c.Id,
                ExpenseId = c.Expense?.Id,
                Important = c.Important,
                Text = c.Text,
           
            };
        }
    }

}