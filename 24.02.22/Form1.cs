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
using System.Drawing.Printing;

namespace _24._02._22
{
    public partial class Form1 : Form
    {
        public int fontSize = 0;
        public System.Drawing.FontStyle fs = FontStyle.Regular;
        public FontSettings fontSetts;
        private string result = "";
        public string filename;
        public bool isFileChanged;

        public Form1()
        {
            InitializeComponent();

            Init();
        }
    
        public void Init()
        {
            filename = "";
            isFileChanged = false;
            UpdateTextWithTitle();
            FontSettings fs = new FontSettings();
        }
    
        public void CreateNewDocument(object sender,EventArgs e)
        {
            SaveUnsavedFile();
            textBox1.Text = "";
            filename = "";
            UpdateTextWithTitle();
        }
    
        public void OpenFile(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    filename = openFileDialog1.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть файл!");
                }
                
            }
            UpdateTextWithTitle();
        }
   
        public void SaveFile(string _filename)
        {
            if(filename== "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _filename = saveFileDialog1.FileName;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(_filename+"txt");
                sw.Write(textBox1.Text);
                sw.Close();
                filename = _filename;
                isFileChanged = false;
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить файл!");
            }
            UpdateTextWithTitle();
        }
    
        public void Save(object sender, EventArgs e)
        {
            SaveFile(filename);
        }


        public void Exit(object sender, EventArgs e)
        {
            
            Application.Exit();
            
        }

        private void OnTextChange(object sender, EventArgs e)
        {
            if (!isFileChanged)
            {
                this.Text = this.Text.Replace("*","");
                isFileChanged = true;
                this.Text = "*" + this.Text;
            }
        }
  
        public void UpdateTextWithTitle()
        {
            if (filename!= "")
            {
                this.Text = filename + " - Блокнот";
            }
            else
            {
                this.Text = filename + "Безымянный - Блокнот";
            }
        
        }
    
        public void SaveUnsavedFile()
        {
            if(isFileChanged)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения в файле?","Сохранение файла",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                if(result==DialogResult.OK)
                {
                    SaveFile(filename);
                }                          
            }
        }
    
        public void CopyText()
        {
            Clipboard.SetText(textBox1.SelectedText);
        }
        public void CutText()
        {
            Clipboard.SetText(textBox1.SelectedText);
            textBox1.Text = textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
        }
        public void PasteText()
        {
            Clipboard.GetText();
        }
        private void OnCopyText(object sender, EventArgs e)
        {
            CopyText();
        }
        private void OnCutText(object sender, EventArgs e)
        {
            CutText();
        }
        private void OnPasteText(object sender, EventArgs e)
        {
            PasteText();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            SaveUnsavedFile();
        }

        private void OnFontClick(object sender, EventArgs e)
        {
            fontSetts = new FontSettings();
            fontSetts.Show();
        }

        private void OnFocus(object sender, EventArgs e)
        {
            if(fontSetts !=null)
            {
                fontSize = fontSetts.fontSize;
                fs = fontSetts.fs;
                textBox1.Font=new Font(textBox1.Font.FontFamily, fontSize,fs);
                fontSetts.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowHelp = true;

            colorDialog1.Color = textBox1.ForeColor;

            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result = textBox1.Text;
            // объект для печати
            PrintDocument printDocument = new PrintDocument();
            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;
            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();
            // установка объекта печати для его настройки
            printDialog.Document = printDocument;
            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void reference(object sender, EventArgs e)
        {
            MessageBox.Show("Блокнот создан UserRamis");
        }
    }
    
}
