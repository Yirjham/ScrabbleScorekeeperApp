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
        public static bool IsUserEntryEmpty(params string[] inputFromPlayers)
        {

            for (int i = 0; i < inputFromPlayers.Length; i++)
            {
                if (inputFromPlayers[i] == "")
                {
                    return true;
                }
            }

            return false;
        }
        public static bool isValidNumber(params string[] inputFromPlayers)
        {
            bool isValidNumber = false;

            for (int i = 0; i < inputFromPlayers.Length; i++)
            {
                isValidNumber = int.TryParse(inputFromPlayers[i], out _);

                if (isValidNumber != true)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isValidRange(params string[] inputFromPlayers)
        {
            bool isValidNumber = false;

            for (int i = 0; i < inputFromPlayers.Length; i++)
            {
                isValidNumber = int.TryParse(inputFromPlayers[i], out _);

                if (isValidNumber != true)
                {
                    return false;
                }
            }

            return true;

            //bool isValidRangeScoreP1 = DataValidation.isValidRange(txtScorePlayer1.Text);
            //bool isValidRangeScoreP2 = DataValidation.isValidRange(txtScorePlayer2.Text);

            //if (isValidRangeScoreP1 == true && isValidRangeScoreP2 == true)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

    }
}
