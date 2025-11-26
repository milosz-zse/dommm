using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace FirstOnitMauiApp
{
    public class dispalingEntrythisngs :BindableObject
    {
        private string enterdName;

        public string EnterdName
        {
            get { return enterdName; }
            set { enterdName = value; OnPropertyChanged(); }
        }


        private string displayEntryOnThisLabel;

        public string DisplayEntryOnThisLabel
        {
            get { return displayEntryOnThisLabel; }
            set { displayEntryOnThisLabel = value; OnPropertyChanged(); }
        }



        private Command clickForDisplayingEntryOnLabel;

        public Command ClickForDisplayingEntryOnLabel
        {
            get
            {
                return clickForDisplayingEntryOnLabel ??= new Command(
                    () =>
                    {

                        DisplayEntryOnThisLabel = EnterdName;
                        var dummy = DisplayEntryOnThisLabel;
                    });
            }
        }
    }
}

