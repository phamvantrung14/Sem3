using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestAccountAs1.AccountServiceReference;

namespace TestAccountAs1.Models
{
    public class Accountclient
    {
        AccountServiceClient client = new AccountServiceClient();
        public List<Account> getAllAccounts()
        {
            var list = client.GetAccountList().ToList();
            var rt = new List<Account>();
            list.ForEach(a => rt.Add(new Account()
            {
                AccountNumber = a.AccountNumber,
                AccountName = a.AccountName,
                CMND = a.CMND,
                CodePin = a.CodePin,
                Created = a.Created,
                Money = a.Money
            }));
            return rt;
        }
        public void storeAccount(Account newAccount)
        {
            var ac = new AccountServiceReference.Account()
            {
                AccountName = newAccount.AccountName,
                AccountNumber = newAccount.AccountNumber,
                CMND = newAccount.CMND,
                CodePin = newAccount.CodePin,
                Created = newAccount.Created,
                Money = newAccount.Money
            };
            client.AddAccount(ac);     
        }

        public Account getAccountById(string id)
        {
            var data = client.GetAccountById(Convert.ToString(id));
            Account a = new Account();
            a.AccountName = data.AccountName;
            a.AccountNumber = data.AccountNumber;
            a.CMND = data.CMND;
            a.CodePin = data.CodePin;
            a.Created = data.Created;
            a.Money = data.Money;
            return a;
        }
        public void editAccount(Account ac)
        {
            var account = new AccountServiceReference.Account()
            {
                AccountName = ac.AccountName,
                AccountNumber = ac.AccountNumber,
                CMND = ac.CMND,
                CodePin = ac.CodePin,
                Created = ac.Created,
                Money = ac.Money
            };
            client.UpdateAccount(account);
        }

        public void deleteAc(string id)
        {
            client.DeleteAccount(id);
        }
    }
}