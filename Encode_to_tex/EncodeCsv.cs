using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encode_to_tex
{
    public class EncodeCsv
    {

        /*csvの中身を受け取り，リストに1行ずつ代入.
         * 更にカンマと改行コードを変換し，変換後文字列が代入されたリストを返す
         */
        public List<string> Encode(string csv_data,ref int list_element,ref int posi_count)
        {
            int count = 0, count2 = 0;
            var csv_end_list=new List<string>();
            int n = csv_data.Length;

            for (int i = 0; csv_data[i] != '\n'; i++)
            {
                if (csv_data[i] == ',')
                {
                    posi_count++;
                }

            }

            for (int i = 0; i < n; i++)
            {
                /*改行ごとにリストに追加*/
                if (csv_data[i] == '\n')
                {
                    count2=i;
                    count2+=1;
                    csv_end_list.Add(csv_data.Substring(count,count2-count));
                    count = count2;
                    list_element++;
                }

            }

            /*カンマをアンドに、改行コードを￥に変換*/
            for (int i = 0; i < list_element; i++)
            {
                csv_end_list[i] = csv_end_list[i].Replace(",", " & ");
                csv_end_list[i] = csv_end_list[i].Replace("\r", " \\");
                csv_end_list[i] = csv_end_list[i].Replace("\n", "\\\n");
            }
            
            return csv_end_list;
        }
    }
}

