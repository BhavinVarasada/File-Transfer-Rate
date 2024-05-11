using SkillUp.FileTransferRate.Utility;

namespace SkillUp.FileTransferRate
{
    /// <summary>
    /// for all calculation related part.
    /// </summary>
    public class Calculation
    {
        /// <summary>
        /// used for days.
        /// </summary>
        public int Days { get; set; }

        /// <summary>
        /// used for hours.
        /// </summary>
        public int Hours { get; set; }

        /// <summary>
        /// used for minutes.
        /// </summary>
        public int Minutes { get; set; }

        /// <summary>
        /// used for seconds.
        /// </summary>
        public int Seconds { get; set; }

        /// <summary>
        /// used for milliseconds.
        /// </summary>
        public int Milliseconds { get; set; }

        /// <summary>
        /// to calculate total bytes.
        /// </summary>
        /// <param name="lFileSize"></param>
        /// <param name="FileSizeUnit"></param>
        /// <returns></returns>
        public long CalculateBytes(long lFileSize, FileSizeUnit FileSizeUnit)
        {
            long lTotalBytes = 0;

            //it will calculate total bytes according to user input.
            switch (FileSizeUnit)
            {
                case FileSizeUnit.B:
                    lTotalBytes = lFileSize;
                    break;
                case FileSizeUnit.KB:
                    //convert kilobytes into bytes.
                    lTotalBytes = lFileSize * Constant.KILOBYTE_SIZE;
                    break;
                case FileSizeUnit.MB:
                    //convert megabyte into bytes.
                    lTotalBytes = lFileSize * Constant.KILOBYTE_SIZE * Constant.KILOBYTE_SIZE;
                    break;
                default:
                    Output.WriteLine(Constant.ERROR_MSG_FILE_SIZE_UNIT);
                    break;
            }
            return lTotalBytes;
        }

        /// <summary>
        /// to calculate total time.
        /// </summary>
        /// <param name="lTotalBytes"></param>
        /// <returns></returns>
        public void CalculateTime(long lTotalBytes)
        {
            //calculates total milliseconds to transfer given bytes.          
            long lTotalMilliSeconds = (long)(lTotalBytes / ((double)Constant.TRANSMISSION_RATE / Constant.MILLISECONDS_IN_SECONDS));

            //convert milliseconds to seconds
            long lTotalSeconds = lTotalMilliSeconds / Constant.MILLISECONDS_IN_SECONDS;

            //remaining milliseconds will be count.
            lTotalMilliSeconds = lTotalMilliSeconds % Constant.MILLISECONDS_IN_SECONDS;

            //convert seconds to minute
            long lTotalMinutes = lTotalSeconds / Constant.SECONDS_IN_MINUTE;

            //remaining seconds will be count.
            lTotalSeconds = lTotalSeconds % Constant.SECONDS_IN_MINUTE;

            //convert minute to hour
            long lTotalHours = lTotalMinutes / Constant.MINUTE_IN_HOUR;

            //remaining minutes will be count.
            lTotalMinutes = lTotalMinutes % Constant.MINUTE_IN_HOUR;

            // convert hours to days
            long lTotalDays = lTotalHours / Constant.HOURS_IN_DAY;

            //remaining Hours will be count.
            lTotalHours = lTotalHours % Constant.HOURS_IN_DAY;

            // set all properties.
            Days = (int)lTotalDays;
            Hours = (int)lTotalHours;
            Minutes = (int)lTotalMinutes;
            Seconds = (int)lTotalSeconds;
            Milliseconds = (int)lTotalMilliSeconds;
        }
    }
}

