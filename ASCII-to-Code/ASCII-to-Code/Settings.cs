using System;
using System.Threading;
using System.Linq;

namespace ASCII_to_Code
{
    public class Settings
    {
        // Member variables
        string mActiveLanguage;
        string mActiveBorders;
        string mActiveAlign;
        int mCharWidth;

        // Constructors (Assigns titles to the list items)
        public Settings(string _ActiveLanguage, string _ActiveBorders, string _ActiveAlign, int _CharWidth)
        {
            mActiveLanguage = _ActiveLanguage;
            mActiveBorders = _ActiveBorders;
            mActiveAlign = _ActiveAlign;
            mCharWidth = _CharWidth;
        }

        // Getters (Used to get the titles of the list items passed into the methods)
        public string GetLanguage()
        {
            return mActiveLanguage;
        }

        public string GetBorders()
        {
            return mActiveBorders;
        }

        public string GetAlign()
        {
            return mActiveAlign;
        }

        public int GetWidth()
        {
            return mCharWidth;
        }

        // Setters
        public void SetLanguage(int input)
        {
            switch (input)
            {
                case 1:
                    mActiveLanguage = "C#";
                    break;
                case 2:
                    mActiveLanguage = "C";
                    break;
                case 3:
                    mActiveLanguage = "C++";
                    break;
                case 4:
                    mActiveLanguage = "Java";
                    break;
                case 5:
                    mActiveLanguage = "Python";
                    break;
            }
        }

        public void SetBorders(int input)
        {
            switch (input)
            {
                case 1:
                    mActiveBorders = "None";
                    break;
                case 2:
                    mActiveBorders = "Top Only";
                    break;
                case 3:
                    mActiveBorders = "Bottom Only";
                    break;
                case 4:
                    mActiveBorders = "Left Only";
                    break;
                case 5:
                    mActiveBorders = "Right Only";
                    break;
                case 6:
                    mActiveBorders = "Top and Bottom";
                    break;
                case 7:
                    mActiveBorders = "Left and Right";
                    break;
                case 8:
                    mActiveBorders = "All";
                    break;
            }
        }

        public void SetAlign(int input)
        {
            switch (input)
            {
                case 1:
                    mActiveAlign = "Right";
                    break;
                case 2:
                    mActiveAlign = "Center";
                    break;
                case 3:
                    mActiveAlign = "Left";
                    break;
            }
        }

        public void SetWidth(int input)
        {
            mCharWidth = input;
        }
    }
}
