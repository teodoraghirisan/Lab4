using System;
using Lab4.Models;

namespace Lab4.ViewModels
{
    public class ExpenseGetModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfComments { get; set; }
       
        public static ExpenseGetModel FromExpense(Expense expense)
        {
            return new ExpenseGetModel
            {
                Id = expense.Id,
                Description = expense.Description,
                Location = expense.Location,
                Date = expense.Date,
                NumberOfComments = expense.Comments.Count
               
                
            };
        }
    }
}
