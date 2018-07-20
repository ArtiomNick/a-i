using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    struct Angle
    {

        int degrees;
        int minutes;
        int seconds;

        public Angle(int degrees, int minutes, int seconds)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            if (this.minutes > 59)
            {
                this.degrees += this.minutes / 60;
                this.minutes = this.minutes % 60;
            }

            this.seconds = seconds;
            if (this.seconds > 59)
            {
                this.minutes += this.seconds / 60;
                this.seconds = this.minutes % 60;
            }
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

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Angle angle = (Angle)obj;
            return this == angle;
        }

        public int this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return degrees;
                    case 1:
                        return minutes;
                    case 2:
                        return seconds;
                    default:
                        throw new IndexOutOfRangeException("There is no value to check on such index: " + i);
                }
            }
            set
            {
                switch (i)
                {
                    case 0:
                        degrees = value;
                        break;
                    case 1:
                        minutes = value;
                        break;
                    case 2:
                        seconds = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException("There is no value to modify on such index: " + i);
                }
            }
        }

        #region enumerator

        public IEnumerator GetEnumerator()
        {
            return new AngleEnumerator(this);
        }

        private class AngleEnumerator : IEnumerator
        {
            Angle theAngle;
            int location;
            public AngleEnumerator(Angle theAngle)
            {
                this.theAngle = theAngle;
                location = -1;
            }
            public bool MoveNext()
            {
                ++location;
                return (location > 2) ? false : true;
            }
            public object Current
            {
                get
                {
                    if (location < 0 || location > 2)
                        throw new InvalidOperationException(
                            "The enumerator is either before the first element or after the last element of the Angle");
                    return theAngle[(int)location];
                }
            }
            public void Reset()
            {
                location = -1;
            }
        }
        #endregion


    }
}
