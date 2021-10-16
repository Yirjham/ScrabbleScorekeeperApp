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
            bool isValid = int.TryParse(userInputText, out _);
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

                if (userInputNumber >= 0 && userInputNumber <= 130)
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
        public static bool IsUserEntryEmpty(params string[] inputPlayers)
        {

            for (int i = 0; i < inputPlayers.Length; i++)
            {
                if (inputPlayers[i] == "")
                {
                    return true;
                }
            }

            return false;
        }
        //private static bool isValidNumber()
        //{
        //    bool isValidEntryScoreP1 = DataValidation.isValidNumericData(txtScorePlayer1.Text);
        //    bool isValidEntryScoreP2 = DataValidation.isValidNumericData(txtScorePlayer2.Text);

        //    if (isValidEntryScoreP1 == true && isValidEntryScoreP2 == true)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //private bool isValidRange()
        //{
        //    bool isValidRangeScoreP1 = DataValidation.isValidRange(txtScorePlayer1.Text);
        //    bool isValidRangeScoreP2 = DataValidation.isValidRange(txtScorePlayer2.Text);

        //    if (isValidRangeScoreP1 == true && isValidRangeScoreP2 == true)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
