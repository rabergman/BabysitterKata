using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabysitterKata
{
    public class BabysittingJob
    {
        int? _startTime = null;
        int? _endTime = null;

        public int? StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                if (value > 1699 && value < 2400)
                    _startTime = value;
                else if (value >= 0 && value < 400)
                    _startTime = value;
                else
                    _startTime = null;
            }
        }

        public int? EndTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                if (_startTime == null)
                    _endTime = null;
                else if (value > 1799 && value < 2400 && value > _startTime)
                    _endTime = value;
                else if (value >= 0 && value < 401 &&
                    (_startTime > 1700 || _startTime < value))
                    _endTime = value;
                else
                    _endTime = null;
            }
        }

        public int? BedTime { get; set; }

        public decimal CalculatePay()
        {
            int hoursWorked12 = HoursWorkedFor12Dollars();
            int hoursWorked8 = HoursWorkedFor8Dollars();
            int hoursWorked16 = HoursWorkedFor16Dollars();

            return (hoursWorked12 * 12) + (hoursWorked8 * 8) + (hoursWorked16 * 16);
        }

        private int HoursWorkedFor12Dollars()
        {
            //Start time was after midnight no $12 hours
            if (_startTime < 1700)
                return 0;

            if (BedTime != null)
            {
                //There was a bed time

                if (_endTime < 1700)
                {
                    //There was a bed time and the job ended after midnight

                    if (BedTime < 1700)
                    {
                        //There was a bed time and the job ended after
                        //  midnight and bedtime was after midnight

                        return (int)(2400 - _startTime) / 100;
                    }
                    else
                    {
                        //There was a bed time and the job ended after
                        //  midnight and bedtime was before midnight

                        return (int)(BedTime - _startTime) / 100;
                    }
                }
                else
                {
                    //There was a bed time and the job ended before midnight

                    if (BedTime < 1700)
                    {
                        //There was a bed time and the job ended before midnight
                        // and bed time was after midnight

                        return (int)(_endTime - _startTime) / 100;
                    }

                    if (BedTime < _endTime)
                    {
                        //There was a bed time and the job ended before midnight
                        // and bed time was before midnight

                        return (int)(BedTime - _startTime) / 100;
                    }
                }
            }
            else //There was no bed time
            {
                //There was no bed time and end time was after midnight
                if (_endTime < 1700)
                {

                }
                else
                {
                    return (int)(_endTime - _startTime) / 100;
                    //There was no bed time and end time was before midnight
                }
            }

            return (int)(_endTime - _startTime) / 100;
        }

        private int HoursWorkedFor8Dollars()
        {
            //Bed time is null
            if (BedTime == null)
                return 0;
            else
                return 1;
        }

        private int HoursWorkedFor16Dollars()
        {
            return 0;
        }
    }
}
