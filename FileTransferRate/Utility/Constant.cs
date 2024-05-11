namespace SkillUp.FileTransferRate.Utility
{
    /// <summary>
    /// for all constant values.
    /// </summary>
    public class Constant
    {
        public const string DASH_LINE                      = "|================================================================================|";
        public const string PROGRAM_NAME                   = "\t FILE TRANSFER TIME CALCULATION";

        public const string MSG_FILE_SIZE_DISPLAY          = "Enter the file size [Range: {0} to {1}] : ";
        public const string MSG_FILE_SIZE_UNIT_DISPLAY     = "Enter the file size unit [B or KB or MB] : ";
        public const string MSG_TRANSMISSION_RATE          = "\t Transmission Rate : {0} Bytes/sec";

        public const string ERROR_MSG_FILE_SIZE            = "Entered file size is invalid.";
        public const string ERROR_MSG_FILE_SIZE_RANGE      = "Entered file size is out of the predefined range.";
        public const string ERROR_MSG_FILE_SIZE_UNIT       = "Entered file size unit is invalid.";
        public const string ERROR_MSG_UNEXPECTED           = "File transfer time calculation operation failed.";
        public const string ERROR_MSG_DETAIL               = "Detail Error : {0}";
        public const string ERROR_MSG_STACK_TRACE          = "Stack Trace : {0}";

        public const string RESULT                         = "\t Calculation Result";
        public const string MSG_COMPLETED                  = "\t File Transfer time calculation operation completed successfully";

        public const string MSG_STATUS                     = "\t Total time required to transfer files of size : {0} {1}";
        public const string DAYS                           = "\t Days           : {0}";
        public const string HOURS                          = "\t Hours          : {0}";
        public const string MINUTES                        = "\t Minutes        : {0}";
        public const string SECONDS                        = "\t Seconds        : {0}";
        public const string MILLISECONDS                   = "\t Milliseconds   : {0}";
        public const string SYMBOL_BYTE                    = "B";
        public const string SYMBOL_KILOBYTE                = "KB";
        public const string SYMBOL_MEGABYTE                = "MB";

        public const int MINIMUM_RANGE                     = 0;
        public const int MAXIMUM_RANGE                     = 2147483647;
        public const int MINIMUM_UNIT_LENGTH               = 1;
        public const int MAXIMUM_UNIT_LENGTH               = 2;
        public const int TRANSMISSION_RATE                 = 960;
        public const int MILLISECONDS_IN_SECONDS           = 1000;
        public const int MINUTE_IN_HOUR                    = 60;
        public const int SECONDS_IN_MINUTE                 = 60;
        public const int HOURS_IN_DAY                      = 24;
        public const int KILOBYTE_SIZE                     = 1024;
    }
}
