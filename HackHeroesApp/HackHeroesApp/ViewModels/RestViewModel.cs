using HackHeroesApp.Models;
using HackHeroesApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace HackHeroesApp.ViewModels
{
    public class RestViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<QuestionModel> questions;

        public RestViewModel()
        {
            GetQuestions();
        }

        public ObservableCollection<QuestionModel> Questions
        {
            get { return questions; }
            set
            {
                questions = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
            }
        }

        public async void GetQuestions()
        {
            var result = await RestService.GetQuestions();

            if(result != null)
            {
                questions = result;
            }
        }
    }
}
