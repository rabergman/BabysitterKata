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
                else
                    _endTime = value;
            }
        }
    }
}
