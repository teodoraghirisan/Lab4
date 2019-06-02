namespace Lab4.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Important { get; set; }
        public Expense Expense { get; set; }
        public User AddedBy { get; set; }
       
    }
}
