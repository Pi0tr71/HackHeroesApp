using System;
using System.Collections.Generic;
using System.Text;

namespace HackHeroesApp.Models
{
    public class QuestionModel
    {
        private int id;
        private int question_number;
        private string question;
        private string[] answers;
        private string correct_answer;
        private string media;
        private string type;
        private string block;

        public int ID { get { return id; } private set { this.id = value; } }
        public int QuestionNumber { get { return question_number; } private set { this.question_number = value; } }
        public string Question { get { return question; } private set { this.question = value; } }
        public string[] Answers { get { return answers; } private set { this.answers = value; } }
        public string CorrectAnswer { get { return correct_answer; } private set { this.correct_answer = value; } }
        public string Media { get { return media; } private set { this.media = value; } }
        public string Type { get { return type; } private set { this.type = value; } }
        public string Block { get { return block; } private set { this.block = value; } }
    }
}
