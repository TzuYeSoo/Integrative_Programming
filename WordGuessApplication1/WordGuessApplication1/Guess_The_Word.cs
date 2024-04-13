using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication1
{
    public partial class Guess_The_Word : Form
    {
        public Guess_The_Word()
        {
            InitializeComponent();
        }
            static ArrayList WordList = new ArrayList();
            static StringBuilder sb1 = new StringBuilder();
            static StringBuilder sb2 = new StringBuilder();
        private void Form1_Load(object sender, EventArgs e)
        {
            Restart();
        }
            private void Restart() { 
            WordList.Add("C o m p u t e r");
            WordList.Add("P r o g r a m");
            WordList.Add("C o d e");
            WordList.Add("N y e s s i e");
            WordList.Add("H a n d S o m e");

            Random rand = new Random();
            int ranNum = rand.Next(1,5);
            

           

            string[] word = WordList[ranNum].ToString().Split(' ');
            
            for(int i = 0; i < word.Length; i++)
            {
                sb1.Append(word[i]);
            }
            sb2.Append(word[0]);
            for (int i = 1; i < word.Length - 1; i++)
            {
                word[i] = "?";
                sb2.Append(word[i]);
            }
            sb2.Append(word[word.Length - 1]);
            Words.Text = sb2.ToString();
            

        }

        private void GuessBut_Click(object sender, EventArgs e)
        {
            
            string ans = Answer.Text.ToString();
            if(ans.Equals(sb1.ToString()))
            {
                Words.Text = ans;
                MessageBox.Show("Correct!!");
                
                IncoAns.Items.Clear();
                sb1.Clear();
                sb2.Clear();
                Restart();
                
               
                
              
            }else if(ans == "") {
                MessageBox.Show("No Input");
            }else if (!ans.Equals(sb1.ToString()))
            {
                MessageBox.Show("Incorrect Answer " +
                    "\nTry Again");
                IncoAns.Items.Add(ans);

            }
        }
    }
}
