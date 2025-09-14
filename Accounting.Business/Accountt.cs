using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.ViewModels.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Business
{
    public class Accountt
    {
        public static ReportViewModel ReportFormMain()
        {
            ReportViewModel rp = new ReportViewModel();

            DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));


            using (UnitOfWork db = new UnitOfWork())
            {


                var recive = db.AccountingRepository.Get(a=> a.TypeRef ==1 && a.DateTitle >= startDate && a.DateTitle <=endDate).Select(a=> a.Amount).ToList();
                var pay = db.AccountingRepository.Get(a=> a.TypeRef ==2 && a.DateTitle >= startDate && a.DateTitle <=endDate).Select(a=> a.Amount).ToList();

                rp.Recive = recive.Sum();
                rp.Pay = pay.Sum();
                rp.AccountBalance = (recive.Sum() - pay.Sum());


            }
            return rp;
        }
    }
}
