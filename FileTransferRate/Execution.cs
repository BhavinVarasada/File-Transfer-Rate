using SkillUp.FileTransferRate.Utility;
using System;

namespace SkillUp.FileTransferRate
{
    /// <summary>
    /// used for program execution logic.
    /// </summary>
    public class Execution
    {
        /// <summary>
        /// call file size and file size unit method to get input from the user,
        /// and call calculate bytes and calculate time method for final calculation.
        /// </summary>
        public void Start()
        {
            try
            {
                Output.PrintTitle();
                string strDisplayFileSize = string.Format(Constant.MSG_FILE_SIZE_DISPLAY, Constant.MINIMUM_RANGE, Constant.MAXIMUM_RANGE);

                //used to get file size from the user.
                long nFileSize = UserInput.GetFileSize(strDisplayFileSize, Constant.ERROR_MSG_FILE_SIZE);

                //used to get file size unit from the user.
                FileSizeUnit FileSizeUnitName = UserInput.GetFileSizeUnit(Constant.MSG_FILE_SIZE_UNIT_DISPLAY, Constant.ERROR_MSG_FILE_SIZE_UNIT);

                //method call for calculating total bytes.
                Calculation objCalculation = new Calculation();
                long lTotalBytes = objCalculation.CalculateBytes(nFileSize, FileSizeUnitName);

                //method call for calculate the time.
                objCalculation.CalculateTime(lTotalBytes);

                //to print final result.
                Output.PrintResult(nFileSize, FileSizeUnitName, objCalculation);
            }
            catch (Exception ex)
            {
                Output.WriteLine(Constant.ERROR_MSG_UNEXPECTED);

                //Exception handling for unknown error.
                Output.WriteLine(string.Format(Constant.ERROR_MSG_DETAIL, ex.Message));
                Output.WriteLine(string.Format(Constant.ERROR_MSG_STACK_TRACE, ex.StackTrace));
            }
        }
    }
}
