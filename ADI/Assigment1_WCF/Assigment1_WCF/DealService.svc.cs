using Assigment1_WCF.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assigment1_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DealService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DealService.svc or DealService.svc.cs at the Solution Explorer and start debugging.
    public class DealService : IDealService
    {
        FRDbContext db;
        private List<Deal> deals;

        public DealService()
        {
            db = new FRDbContext();
        }
        public string AddDeal(Deal deal, string accountNumber, int codePin)
        {
            var dataAc = db.Accounts.ToList();
            foreach(var item in dataAc)
            {
                if (accountNumber == item.AccountNumber)
                {
                    if (codePin == item.CodePin)
                    {                      
                        if (deal.DealMoney < item.Money)
                        {
                            deal.Account_ID = accountNumber;
                            deal.TransactionFees = CheckPhanTram(deal.DealMoney, deal.TransactionFees);
                            Account ac1 = db.Accounts.Where(x => x.AccountNumber == accountNumber).First();
                            ac1.Money = ac1.Money - deal.DealMoney;
                            db.Entry(ac1).State = EntityState.Modified;

                            Account ac2 = db.Accounts.Where(x => x.AccountNumber == deal.RecipientAccount).First();
                            ac2.Money = ac2.Money + (deal.DealMoney - deal.TransactionFees);
                            db.Entry(ac2).State = EntityState.Modified;

                            db.Deals.Add(deal);
                            db.SaveChanges();
                            return "Giao dich thanh cong";
                        }
                        else  
                        {
                            return "So du tai khoan khong du de thuc hien giao dich";
                        }  
                    }
                    else
                    {
                        return "Mat khau khong dung";
                    }

                }
                else
                {
                    return "Tai khoan khong dung";
                }
                

            }
            return "Tai khoan khong ton tai";


        }

        public IEnumerable<Deal> GetDealList()
        {
            return db.Deals.AsEnumerable();
        }
        public float CheckPhanTram(float DealMoney,float TransactionFees)
        {
            if (DealMoney <= 100000)
            {
                TransactionFees = 10000;
                return TransactionFees;
            }
            else if (DealMoney > 100000 & DealMoney <= 500000)
            {
                float moneyTran = (DealMoney * 2) / 100;
                TransactionFees = moneyTran;
                return TransactionFees;
            }
            else if (DealMoney > 500000 & DealMoney <= 1000000)
            {
                float a = (float)1.5;
                float moneyTran = (DealMoney * a) / 100;
                TransactionFees = moneyTran;
                return TransactionFees;
            }else
            {
                float a = (float)0.5;
                float moneyTran = (DealMoney * a) / 100;
                TransactionFees = moneyTran;
                return TransactionFees;
            }
        }

        public List<Deal> GetDealListById(string accountNumber, int codePin)
        {
            /* var dataAc = db.Accounts.ToList();*/
            ; ; ;            
           /* foreach (var item in dataAc)
            {
                if (accountNumber == item.AccountName)
                {
                    if (codePin == item.CodePin)
                    {*/
                        List<Deal> deals = new List<Deal>();
                        var list = db.Deals.Where(x => x.Account_ID == accountNumber).ToList();
                        list.ForEach(b => deals.Add(new Deal()
                        {
                            Account =b.Account,
                            Account_ID=b.Account_ID,
                            Created=b.Created,
                            DealMoney=b.DealMoney,
                            Id=b.Id,
                            RecipientAccount=b.RecipientAccount,
                            Status=b.Status,
                            TransactionFees=b.TransactionFees
                        }));
                        
           /*         }
                }
            }*/
            return deals ;
        }
    }
}
