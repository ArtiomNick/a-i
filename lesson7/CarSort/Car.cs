using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSort
{
    class Car : IComparable
    {
        public int Id { get; set; }
        public int Speed { get; set; }
        public string Manufacturer { get; set; }

        public override string ToString()
        {
            return String.Format("Id: {0,3} MAnufacturer: {1,-7} Speed: {2,3}", Id, Manufacturer, Speed);
        }

        public static IComparer SortBySpeed
        {
            get
            {
                return (IComparer)new SpeedComparer();
            }
        }

        public int CompareTo(object obj)
        {
            Car temp = (Car)obj;
            if (this.Id > temp.Id)
                return 1;
            if (this.Id < temp.Id)
                return -1;
            else
                return 0;
        }

    }

    class SpeedComparer : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            Car t1 = (Car)x;
            Car t2 = (Car)y; 
            return String.Compare(t1.Speed.ToString(), t2.Speed.ToString());
        }
    }
}
