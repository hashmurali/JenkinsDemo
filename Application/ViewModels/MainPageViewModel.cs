using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using Library;

namespace AnagramCheckerApp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        //code checked in
        string _first;
        public string FirstString
        {
            get
            {
                return _first;
            }
            set
            {
                Set(ref _first, value);
            }
        }

        string _second;
        public string SecondString
        {
            get
            {
                return _second;
            }
            set
            {
                Set(ref _second, value);
            }
        }

        string _output;
        public string Output
        {
            get
            {
                return _output;
            }
            set
            {
                Set(ref _output, value);
            }
        }

        public void CheckAnagramHandler()
        {
            Output = (AnagramChecker.IsAnagram(FirstString, SecondString)) ? "Yes" : "Nope";
        }
    }
}

