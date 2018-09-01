using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPDesign
{
    class Fullname
    {
    }
    // same access level with above
    internal class Address
    {
        public string Country;
    }

    namespace Common
    {
        class RoomCode
        {
            // Shared base constanst
            public const int LOCAL_ROOM = 10;
            public const int REMOTE_ROOM = 100;

            // Instance base method
            public void demo01(int code)
            {
                switch (code)
                {
                    case LOCAL_ROOM:
                        break;
                    case REMOTE_ROOM:
                        break;
                    case 1:
                        break;
                    default:
                        break;
                }
            }

            public static void demo02(int code)
            {
                switch (code)
                {
                    case LOCAL_ROOM:
                        break;
                    case REMOTE_ROOM:
                        break;
                    case 1:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

namespace BasicOOPDesign.Common
{
    class ReferenceCode
    {
        Day theDay;

        void demo01()
        {
            theDay = Day.Thursday;
        }

        processStatus demo02(Day day)
        {
            switch (day)
            {
                case Day.Sunday:
                    break;
                case Day.Monday:
                    break;
                case Day.Tuesday:
                    break;
                case Day.Wednesday:
                    break;
                case Day.Thursday:
                    break;
                case Day.Friday:
                    break;
                case Day.Saturday:
                    break;
                default:
                    return processStatus.Error;
            }
            return processStatus.Ready;
        }
    }

    enum Day
    {
        Sunday = 100, // Default value is 0, change to 100
        Monday = 10, // Default value is 1, change to 10
        Tuesday, // Default value is 2, change to 11
        Wednesday, // Default value is 3, change to 12
        Thursday, // Default value is 4, change to 13
        Friday, // Default value is 5, change to 14
        Saturday = 50 // Default value is 6, change to 50
    }

    enum processStatus : byte
    {
        Ready,
        KIV,
        Done,
        Error
    }

    class LocationCodeSet
    {
        public string Country;
        public string State;

        // Constructor : Default Constructor
        //public LocationCodeSet()
        //{
        //}

        // Constructor : Overload Contructors
        public LocationCodeSet(string country)
        {
            this.Country = country;
        }

        // reuse Constructor LocationCodeSet(string country) logic
        public LocationCodeSet(string country, string state) : this(country)
        {
            //this.Country = country;
            this.State = state;
        }
    }

    struct LocationCodeSetType
    {
        public string Country;
        public string State;

        public LocationCodeSetType(string country)
        {
            this.Country = country;
            this.State = "";
        }
    }
}
