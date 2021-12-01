using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScorekeeperLibrary.DataValidation
{
    public static class DataValidation
    {
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
            double inputNumber = 0;

            for (int i = 0; i < inputFromPlayers.Length; i++)
            {
                inputNumber = double.Parse(inputFromPlayers[i]);

                if (inputNumber < 0 || inputNumber > 130)
                {
                    return false;
                }
            }

            return true;
            
        }

    }
}
