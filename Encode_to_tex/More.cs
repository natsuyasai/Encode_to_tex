using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Collections;

namespace Encode_to_tex
{
    public class More
    {


        //csvファイルを開き、ファイルパスを返す
        public string CsvOpen(string filename)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Excel ファイル (*.csv)|*.csv";

            if(dialog.ShowDialog()==DialogResult.OK)
            {
                filename = dialog.FileName;
            }
            else
            {
                filename = "notfile";
            }
            return filename;
        }

        /*csvファイルを文字列型のcsv_dataに代入*/
        public string CsvRead(string filename)
        {
            string csv_data=null;
            StreamReader sr = new StreamReader(filename, Encoding.GetEncoding("Shift_JIS"));

            if(filename == "" || filename == null)
            {
            }

            else
            {
                while(sr.Peek()>0)
                {
                    csv_data += sr.ReadLine() + System.Environment.NewLine;
                }
            }
            sr.Close();
            return csv_data;
        }

    }
}
