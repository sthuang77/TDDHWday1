using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using FluentAssertions;
//using ExpectedObjects;


namespace TDDHWday1
{
    public class OrderCost
    {

        public int Cost { get; set; }
        public int Id { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
        

        public object Class1sub(IList<OrderCost> list, int size, string hwName)
        {
            ////throw new NotImplementedException();
            // int dbcount = list.Count();    

            int dbcount = (int)Math.Ceiling((double)list.Count() / size);
            decimal[] result = new decimal[dbcount];
            for (var i = 0; i < dbcount; ++i)
            {
                result[i] = list.Skip(i * size).Take(size).Select(x => Convert.ToDecimal(x.GetType().GetProperty(hwName).GetValue(x))).Sum();
            }
            return result;


        }



    }

       

    }

    


