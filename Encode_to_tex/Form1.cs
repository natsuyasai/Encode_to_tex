using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Encode_to_tex
{
    public partial class Form1 : Form
    {

        public More more = new More();
        public EncodeCsv enccsv = new EncodeCsv();
        public string filename = "";

        public Form1()
        {
            InitializeComponent();
            centerButton2.Checked = true;
        }




        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*ファイルパスの設定*/
            filename = more.CsvOpen(filename);
            InCsv();
        }

        //D&Dで開く
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            String[] dd_file_path = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            filename = dd_file_path[0];
            InCsv();

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        public void InCsv()
        {
            int list_element = 0;
            int posi_count = 0;
            string csv_data = null;
            var csv_end_list = new List<string>();  

            /*ファイルがパスが設定されていれば以下の処理を実行*/
            if (filename != "notfile")
            {
                /*ファイルの中身を読み出し、csv_dataに代入*/
                csv_data = more.CsvRead(filename);
                /*カンマと改行コードの変換を行いcsv_end_listへ*/
                csv_end_list = enccsv.Encode(csv_data, ref list_element,ref posi_count);

                OutCsv(list_element,csv_end_list,posi_count);
            }
            /*ファイルパスが指定されなければなにも行わない*/
            else
            {
            }

        }

        /*テキストボックスへ出力*/
        public void OutCsv(int list_element, List<string> csv_end_list,int posi_count)
        {
            string[] table = { 
                                "\\begin{table}[]\n",
                                "\\caption{・}\n" ,
                                "\\begin{tabular}" ,
                                "\\end{tabular}\n" ,
                                "\\end{table}\n" 
                             };
            string hline = "\\hline\n";
            string[] center ={
                                "\\begin{center}\n" ,
                                "\\end{center}\n"
                            };
            string element_posi = "";

            element_posi = radio_button();
            
            richTextBox1.AppendText(table[0] + center[0] + table[1] + table[2]);
            richTextBox1.AppendText("{");


            for (int i = 0; i < posi_count+1; i++)
            {
                richTextBox1.AppendText(element_posi);
            }

            richTextBox1.AppendText("|}" + "\n");


            for (int i = 0; i < list_element; i++)
            {
                richTextBox1.AppendText(hline + csv_end_list[i]);
            }


            richTextBox1.AppendText(hline + table[3] + center[1] + table[4]);
        }

        //揃え位置の指定用radiobutton
        public string radio_button()
        {
            string temp="|c";

            if (reftButton1.Checked == true)
            {
                temp = "|l";
            }
            if (centerButton2.Checked == true)
            {
                temp = "|c";
            }
            if (rightButton3.Checked == true)
            {
                temp = "|r";
            }

            return temp;
        }

        /*リッチテキストボックス内を空にする*/
        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }


        //終了位置の記憶
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }





    }
}
