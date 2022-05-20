using CharlieV2._0.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class BlackDailyProduction : IDailyProduction
    {

        public int ChocosPerDay { get; set; }
        public BlackDailyProduction(int totalChocosPerDay)
        {
            ChocosPerDay = totalChocosPerDay*3/5;
        }

        public List<IChocolate> Create()
        {
            List<IChocolate> list = new List<IChocolate>();
            for (int i = 0; i < ChocosPerDay; i++)
            {
                list.Add(new BlackChocolate());
            }
            return list;
        }
       
    }
}
