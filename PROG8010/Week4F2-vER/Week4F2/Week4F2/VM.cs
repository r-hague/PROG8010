using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Week4F2
{
    class VM : INotifyPropertyChanged
    {
        private int currentIndex = -1;
        public int CurrentIndex
        {
            get { return currentIndex; }
            set { currentIndex = value; calcText(); NotifyChanged(); }
        }

        private bool english = false;
        public bool English
        {
            get { return english; }
            set { english = value; calcText(); NotifyChanged(); }
        }

        private string displayText = "";
        public string DisplayText
        {
            get { return displayText; }
            set { displayText = value; NotifyChanged(); }
        }

        private string inputText = "";
        public string InputText
        {
            get { return inputText; }
            set { inputText = value; calcText(); NotifyChanged(); }
        }

        private void calcText()
        {
            if (CurrentIndex >= 0)
            {
                string word = English == true ? "One" : "Un";

                switch (CurrentIndex)
                {
                    case 0:
                        DisplayText = $"{inputText} {word} Million Pounds";
                        break;
                    case 1:
                        DisplayText = $"{inputText} {word} Billion Pounds";
                        break;
                    case 2:
                        DisplayText = $"{inputText} {word} Trillion Pounds";
                        break;
                    default:
                        DisplayText = $"{inputText} {word} Pound";
                        break;
                }
            }
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
