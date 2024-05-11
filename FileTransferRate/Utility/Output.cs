using System;

namespace SkillUp.FileTransferRate.Utility
{
    /// <summary>
    /// for all methods which is used for print.
    /// </summary>
    public class Output
    {
        /// <summary>
        /// for print common lines.
        /// </summary>
        /// <param name="strMessage"></param>
        public static void WriteLine(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

        /// <summary>
        /// for print user input messages.
        /// </summary>
        /// <param name="strMessage"></param>
        public static void Write(string strMessage)
        {
            Console.Write(strMessage);
        }

        /// <summary>
        /// for print program execution first title.
        /// </summary>
        public static void PrintTitle()
        {
            WriteLine(Constant.DASH_LINE);
            WriteLine(Constant.PROGRAM_NAME);
            WriteLine(string.Format(Constant.MSG_TRANSMISSION_RATE, Constant.TRANSMISSION_RATE));
            WriteLine(Constant.DASH_LINE);
        }

        /// <summary>
        /// for print final output.
        /// </summary>
        /// <param name="nFileSize"></param>
        /// <param name="FileSizeUnitName"></param>
        /// <param name="objCalculateTime"></param>
        public static void PrintResult(long nFileSize,FileSizeUnit FileSizeUnitName,Calculation objCalculation)
        {
            WriteLine(Constant.DASH_LINE);
            WriteLine(Constant.RESULT);
            WriteLine(Constant.DASH_LINE);
            WriteLine(Constant.MSG_COMPLETED);
            WriteLine(string.Format(Constant.MSG_STATUS, nFileSize, FileSizeUnitName));
            WriteLine(string.Format(Constant.DAYS, objCalculation.Days));
            WriteLine(string.Format(Constant.HOURS, objCalculation.Hours));
            WriteLine(string.Format(Constant.MINUTES, objCalculation.Minutes));
            WriteLine(string.Format(Constant.SECONDS, objCalculation.Seconds));
            WriteLine(string.Format(Constant.MILLISECONDS, objCalculation.Milliseconds));
        }
    }
}
