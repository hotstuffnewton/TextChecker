using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;                        // these import certain methods to be used in code program did it all for me
using System.Linq;
using System.Text;
using System.Windows.Forms;
///////////////////////////////////////////////THE IMPORTS//////////////////////////////////////////////////////////////////
namespace Text_Analyzer // title of application
{
    public partial class TextAnalysis : Form // called partial form becuase the rest of the code is hidden in designer.cs
    {
        public TextAnalysis() // title of form
        {
            InitializeComponent();
        }
//////////////////////////////////////////////THE FORMS////////////////////////////////////////////////////////////////////

        int charcatercount; // used to get the chacter count
        int wordcount = 0, index = 0; // used to get the word count
        int sentancecount = 0; // used to get the sentance count

////////////////////////////////////////////THE VARIABLES//////////////////////////////////////////////////////////////////      
        
        private void clearbutton_Click(object sender, EventArgs e)  // reset button, set everything to default.
        {
            inputbox.Text = "Type here"; // over writes anything in the box to type here
            wordcountbox.Text = "0";
            totalchactersbox.Text = "0";
            frequenciesOfIndividualLettersBox.Text = "0";  // clears all numbers and saves to 0
            Sentencecountbox.Text = "0";
            wordcount = 0;
            charcatercount = 0;
            
            sentancecount = 0;
        }

        private void Analysisbutton_Click(object sender, EventArgs e) // pressing this button analysis the letters in the top box
        {
            charcatercount = inputbox.Text.Length; // saves the length of text entered.
            String text = inputbox.Text.Trim(); // turns all text in the box into a string that can be read
            while (index < text.Length) 
            {
                
                while (index < text.Length && Char.IsWhiteSpace(text[index]) == false) // pass through each index checking to see is another char follows it. if it does its still in a word, if it doesnt it has passed a word and wordcount +1
                index++; // move to next index
                wordcount++; // adds +1 for every word
                

                while (index < text.Length && Char.IsWhiteSpace(text[index]) == true) // skips all space until a new char is found 
                index++;
                charcatercount--; // -1 for every space in the text
            }
            index = 0; // reset index
            charcatercount += 1; // the method above counts a word if nothing proceeds it so i need +1 to the char count because it thinks there is a space after the last word.
           
            totalchactersbox.Text = charcatercount.ToString(); // shows number length in main text box
            wordcountbox.Text = wordcount.ToString(); // shows number of words in main text box
            Sentencecountbox.Text = sentancecount.ToString(); // shows number of sentaces in main text box 
        }
    }
}
