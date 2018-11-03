using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_5
{
    class Manager
    {
        IComand comand;

        public void SetCommand (IComand comand)
        {
            this.comand = comand;
        }

        public void CountTypes(Stock stock)
        {
            comand.Execute(stock);
        }

        public void AddToStock(Stock stock)
        {
            comand.Execute(stock);
        }

        public void ContentsOfStock(Stock stock)
        {
            comand.Execute(stock);
        }
    }
}
