using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorekeeperLibrary.DataValidation
{
    public static class DataValidation
    {
        // For empty data
        // For invalid numeric format
        // For range checking
        public static bool isEmpty(string userInput)
        {
            if (userInput == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool isValidNumericData(string userInputText)
        {
            int userInputInt = 0;

            bool isValid = int.TryParse(userInputText, out userInputInt);
            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isValidRange(string userInputText)
        {
            int userInputNumber = 0;

            if (isValidNumericData(userInputText) == true)
            {
                userInputNumber = int.Parse(userInputText);

                if (userInputNumber >= 0 && userInputNumber < 130)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
