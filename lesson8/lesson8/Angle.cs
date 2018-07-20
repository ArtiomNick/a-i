using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    struct Angle
    {

        double degrees;
        double minutes;
        double seconds;

        public double Degrees
        {
            get
            {
                return this.degrees;
            }
        }

        public double Minutes
        {
            get
            {
                return this.minutes;
            }
        }

        public double Seconds
        {
            get
            {
                return this.seconds;
            }
        }

        public Angle(double degrees, double minutes, double seconds)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            /*
            if (this.minutes > 59)
            {
                this.degrees += this.minutes / 60;
                this.minutes = this.minutes % 60;
            }
            */
            this.seconds = seconds;
            /*
            if (this.seconds > 59)
            {
                this.minutes += this.seconds / 60;
                this.seconds = this.minutes % 60;
            }
            */
        }

        public Angle(Angle angle)
        {
            this.degrees = angle.degrees;
            this.minutes = angle.minutes;
            this.seconds = angle.seconds;
        }

        public override string ToString()
        {
            return "( " + degrees + " , " + minutes + " , " + seconds + " )";
        }

        public static Angle operator +(Angle angle1, Angle angle2)
        {
            Angle result = new Angle(angle1);

            result.seconds += angle2.seconds;
            if (result.seconds > 59)
            {
                result.minutes++;
                result.seconds -= 60;
            }

            result.minutes += angle2.minutes;
            if (result.minutes > 59)
            {
                result.degrees++;
                result.minutes -= 60;
            }

            result.degrees += angle2.degrees;


            return result;
        }


        public static Angle operator -(Angle angle1, Angle angle2)
        {
            Angle result = new Angle(angle1);

            result.seconds -= angle2.seconds;
            if (result.seconds < 0)
            {
                result.minutes--;
                result.seconds += 60;
            }

            result.minutes -= angle2.minutes;
            if (result.minutes < 0)
            {
                result.degrees--;
                result.minutes += 60;
            }

            result.degrees -= angle2.degrees;


            return result;
        }

        public static bool operator ==(Angle angle1, Angle angle2)
        {
            if (angle1.seconds == angle2.seconds &&
                angle1.minutes == angle2.minutes &&
                angle1.degrees == angle2.degrees)
                return true;
            else
                return false;
        }

        public static bool operator !=(Angle angle1, Angle angle2)
        {
            return !(angle1 == angle2);
        }

    }
}
