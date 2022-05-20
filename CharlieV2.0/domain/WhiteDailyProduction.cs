using CharlieV2._0.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieV2._0.domain
{
    class WhiteDailyProduction : IDailyProduction
    {
        public int ChocosPerDay { get; set; }
        public WhiteDailyProduction(int totalChocosPerDay)
        {
            ChocosPerDay = totalChocosPerDay*1/5;
        }

        public List<IChocolate> Create()
        {
            List<IChocolate> list = new List<IChocolate>();
            for (int i = 0; i < ChocosPerDay; i++)
            {
                list.Add(new WhiteChocolate());
            }
            return list;
        }

    }
}
