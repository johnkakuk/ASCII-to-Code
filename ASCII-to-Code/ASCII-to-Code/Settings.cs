﻿using System;
using System.Threading;
using System.Linq;

namespace ASCII_to_Code
{
    public class Settings
    {
        // Member variables
        int mActiveLanguage;
        int mActiveBorders;
        int mActiveAlign;
        int mCharWidth;

        // Display variables
        string mActiveLanguageDisplay;
        string mActiveBordersDisplay;
        string mActiveAlignDisplay;

        // Constructors (Assigns titles to the list items)
        public Settings(int _ActiveLanguage, int _ActiveBorders, int _ActiveAlign, int _CharWidth)
        {
            mActiveLanguage = _ActiveLanguage;
            mActiveBorders = _ActiveBorders;
            mActiveAlign = _ActiveAlign;
            mCharWidth = _CharWidth;
        }

        // Getters (Used to get the titles of the list items passed into the methods)
        public int GetLanguage()
        {
            return mActiveLanguage;
        }

        public int GetBorders()
        {
            return mActiveBorders;
        }

        public int GetAlign()
        {
            return mActiveAlign;
        }

        public int GetWidth()
        {
            return mCharWidth;
        }


        // Display Getters
        public string DisplayLanguage()
        {
            return mActiveLanguageDisplay;
        }

        public string DisplayBorders()
        {
            return mActiveBordersDisplay;
        }

        public string DisplayAlign()
        {
            return mActiveAlignDisplay;
        }



        // Setters
        public void SetLanguage(int input)
        {
            mActiveLanguage = input;
           
            switch (input)
            {
                case 1:
                    mActiveLanguageDisplay = "C#";
                    break;
                case 2:
                    mActiveLanguageDisplay = "C";
                    break;
                case 3:
                    mActiveLanguageDisplay = "C++";
                    break;
                case 4:
                    mActiveLanguageDisplay = "Java";
                    break;
                case 5:
                    mActiveLanguageDisplay = "Python";
                    break;
            }
        }

        public void SetBorders(int input)
        {
            mActiveBorders = input;

            switch (input)
            {
                case 1:
                    mActiveBordersDisplay = "None";
                    break;
                case 2:
                    mActiveBordersDisplay = "Top Only";
                    break;
                case 3:
                    mActiveBordersDisplay = "Bottom Only";
                    break;
                case 4:
                    mActiveBordersDisplay = "Left Only";
                    break;
                case 5:
                    mActiveBordersDisplay = "Right Only";
                    break;
                case 6:
                    mActiveBordersDisplay = "Top and Bottom";
                    break;
                case 7:
                    mActiveBordersDisplay = "Left and Right";
                    break;
                case 8:
                    mActiveBordersDisplay = "All";
                    break;
            }
        }

        public void SetAlign(int input)
        {
            mActiveAlign = input;

            switch (input)
            {
                case 1:
                    mActiveAlignDisplay = "Left";
                    break;
                case 2:
                    mActiveAlignDisplay = "Center";
                    break;
                case 3:
                    mActiveAlignDisplay = "Right";
                    break;
            }
        }

        public void SetWidth(int input)
        {
            mCharWidth = input;
        }
    }
}
