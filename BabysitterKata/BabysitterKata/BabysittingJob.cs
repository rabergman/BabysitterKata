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

        public int BedTime { get; set; }
    }
}
