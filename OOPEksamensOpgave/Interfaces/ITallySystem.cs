using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPEksamensOpgave.Models;


namespace OOPEksamensOpgave.Interfaces
{
    public interface ITallySystem
    {
        IEnumerable<Product> ActiveProducts();
        InsertCashTransaction AddCreditsToAccount(User user, decimal amount);
        BuyTransaction BuyProduct(User user, Product product);
        Product GetProductByID(int id);
        IEnumerable<Transaction> GetTransactions(User user, int count);
        User GetUsers(Func<User, bool> predicate);
        User GetUserByUsername(string username);
       
        event UserBalanceNotification UserBalanceWarning;
    }
}
