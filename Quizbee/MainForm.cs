using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizbee
{
    public partial class MainForm : Form
    {
        Question[] QuizQuestions = new Question[10];
        int index = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadQuestions();

            ShowQuestion();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Question selectedQuestion = QuizQuestions[index];
            int userSelectedOption = 0;

            if (rdbOption1.Checked)
            {
                userSelectedOption = 1;
            }
            else if (rdbOption2.Checked)
            {
                userSelectedOption = 2;
            }
            else if (rdbOption3.Checked)
            {
                userSelectedOption = 3;
            }
            else if (rdbOption4.Checked)
            {
                userSelectedOption = 4;
            }

            selectedQuestion.SelectedOption = userSelectedOption;

            if (index < QuizQuestions.Length-1)
            {
                index++;

                ShowQuestion();
            }
            else
            {
                btnSubmit.Show();
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            if (index < QuizQuestions.Length-1)
            {
                index++;

                ShowQuestion();
            }
            else
            {
                btnSubmit.Show();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int correctOptions = 0;

            for (int i = 0; i < QuizQuestions.Length; i++)
            {
                var question = QuizQuestions[i];

                if(question.SelectedOption == question.CorrectOption)
                {
                    correctOptions++;
                }
            }

            string message = string.Format("Your Result is {0}/{1}", correctOptions, QuizQuestions.Length);

            MessageBox.Show(message, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        
        private void ShowQuestion()
        {
            lblQuestion.Text = QuizQuestions[index].Title;
            rdbOption1.Text = QuizQuestions[index].Option1;
            rdbOption2.Text = QuizQuestions[index].Option2;
            rdbOption3.Text = QuizQuestions[index].Option3;
            rdbOption4.Text = QuizQuestions[index].Option4;

            rdbOption1.Checked = true;
        }

        private void LoadQuestions()
        {
            QuizQuestions[0] = new Question() { Title = "The output shown on the computer monitor is called", Option1 = "Hard Copy", Option2 = "Soft Copy", Option3 = "Screen Copy", Option4 = "op 4", CorrectOption = 2 };
            QuizQuestions[1] = new Question() { Title = "Eight Bits make up a", Option1 = "byte", Option2 = "megabyte", Option3 = "kilobyte", Option4 = "op 4", CorrectOption = 2 };
            QuizQuestions[2] = new Question() { Title = "Which one of these also known as read/write memory", Option1 = "ROM", Option2 = "RAM", Option3 = "Hard Disk", Option4 = "op 4", CorrectOption = 2 };
            QuizQuestions[3] = new Question() { Title = "The printed output from a computer is called", Option1 = "Soft Copy", Option2 = "Hard Copy", Option3 = "Paper", Option4 = "op 4", CorrectOption = 2 };
            QuizQuestions[4] = new Question() { Title = "WWW stands for?", Option1 = "World Whole Web", Option2 = "Wide World Web", Option3 = "World Wide Web", Option4 = "op 4", CorrectOption = 2 };
            QuizQuestions[5] = new Question() { Title = "If a computer has more than one processor then it is known as ?", Option1 = "Multiprocessor", Option2 = "Multithreaded", Option3 = "Multiprogramming", Option4 = "op 4", CorrectOption = 2 };
            QuizQuestions[6] = new Question() { Title = "Full form of URL is ?", Option1 = "Uniform Resource Locator", Option2 = "Uniform Resource Link", Option3 = "Uniform Registered Link", Option4 = "op 4", CorrectOption = 2 };
            QuizQuestions[7] = new Question() { Title = "In which of the following form, data is stored in computer ?", Option1 = "Decimal", Option2 = "Binary", Option3 = "HexaDecimal", Option4 = "op 4", CorrectOption = 2 };
            QuizQuestions[8] = new Question() { Title = "Which level language is Assembly Language ?", Option1 = "high-level programming language", Option2 = "medium-level programming language", Option3 = "low-level programming language", Option4 = "op 4", CorrectOption = 2 };
            QuizQuestions[9] = new Question() { Title = "Who is also known as Father of Computer ?", Option1 = "Vint Cerf", Option2 = "Tim Berner Lee", Option3 = "Charles Babbage", Option4 = "op 4", CorrectOption = 2 };
        }

    }
}
