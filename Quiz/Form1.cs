using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadFile();
        }
        
        public  void    ReadFile    ()  {
            string path = @"C:\Users\Thenus\Documents\BC\PRG282\QuizPRG282\Quiz\Quiz\bin\Debug\New Text Document.txt";
            
            FileStream MyStream = new FileStream(path,FileMode.OpenOrCreate);
            StreamReader reader= new StreamReader(MyStrean);
            string  Line;
            while ((Line = reader.ReadLine())!=null){
                listBox1.Lines.Add(Line);
            }
            reader.Close();
            MyStream.Close();
        }
    }
}
