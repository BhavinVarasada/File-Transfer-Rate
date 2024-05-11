using System;

namespace SkillUp.FileTransferRate.Utility
{
    /// <summary>
    /// used to get the input from the user.
    /// </summary>
    public class UserInput
    {
        /// <summary>
        /// return the file size as an user input.
        /// </summary>
        /// <param name="strDisplayMsg"></param>
        /// <param name="strErrorMsg"></param>
        /// <returns></returns>
        public static long GetFileSize(string strDisplayMsg, string strErrorMsg)
        {
            long lFileSize = 0;
            bool bInputStatus = false;
            while (bInputStatus == false)
            {
                Output.Write(strDisplayMsg);
                string strGetFileSize = GetString();

                // it will convert string to long datatype and return true if conversation done.
                bInputStatus = long.TryParse(strGetFileSize, out lFileSize);
                if (bInputStatus == false)
                {
                    Output.WriteLine(strErrorMsg);
                }
                else if (lFileSize < Constant.MINIMUM_RANGE || lFileSize > Constant.MAXIMUM_RANGE)
                {
                    Output.WriteLine(Constant.ERROR_MSG_FILE_SIZE_RANGE);
                    bInputStatus = false;
                }
            }
            return lFileSize;
        }

        /// <summary>
        /// return file size unit as an user input. here FileSizeUnit is enum class name.
        /// </summary>
        /// <param name="strDisplayMsg"></param>
        /// <param name="strErrorMsg"></param>
        /// <returns></returns>
        public static FileSizeUnit GetFileSizeUnit(string strDisplayMsg, string strErrorMsg)
        {
            while (true)
            {
                Output.Write(strDisplayMsg);

                string strFileSizeUnit = GetString().ToUpper();
                Output.WriteLine("");

                //to compare file size unit with user input and return appropriate unit from enum class.
                switch (strFileSizeUnit)
                {
                    case Constant.SYMBOL_BYTE:
                        return FileSizeUnit.B;

                    case Constant.SYMBOL_KILOBYTE:
                        return FileSizeUnit.KB;

                    case Constant.SYMBOL_MEGABYTE:
                        return FileSizeUnit.MB;

                    default:
                        Output.WriteLine(strErrorMsg);
                        break;
                }
            }
        }

        /// <summary>
        /// to get string as an input from user.
        /// </summary>
        /// <returns></returns>
        private static string GetString()
        {
            return Console.ReadLine();
        }
    }
}
