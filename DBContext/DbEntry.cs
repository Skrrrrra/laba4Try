using laba4Try.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4Try.DBContext
{
    public static class DbEntry
    {
        public static void EntryFromTo(firstTable first)
        {
            string[] table = new string[20000];
            string inputpath = "E:\\Solutions\\laba4Try\\File\\lab1csv.csv";
            string all = "";
            using (var reader = new StreamReader(inputpath))
            {

                all = reader.ReadToEnd();
            }
            table = all.Split('\n');
            Array.Resize(ref table, table.Length - 1);
            for (int i = 0; i < table.Length; i++)
            {

                table[i] = table[i].Replace('"', ' ');
                table[i] = table[i].Replace('\n', ' ');
            }
            string[] line = new string[16];
            string[,] tableToConsole = new  string[table.Length, 16];

            for (int i = 0; i < table.Length; i++)
            {
                line = table[i].Split(',');

                for (int j = 0; j < 16; j++)
                {
                    tableToConsole[i, j] = line[j];
                    
                }
            }
            for (int i = 0; i < tableToConsole.Length-1; i++)
            {
                if (i + 1 == 16720)
                {
                    

                    for (int j = 0; j < 15; j++)
                    {

                        if (tableToConsole[i, j] != null)
                        {
                            continue;
                        }
                        else
                            tableToConsole[i, j] = " ";
                    }
                    break;
                }

            }
            for (int i = 0; i < tableToConsole.Length - 1; i++)
            {
                

                first.name = tableToConsole[i, 0];
                first.platform = tableToConsole[i, 1];
                first.yearOfRelease = (tableToConsole[i, 2]);
                first.genre = tableToConsole[i, 3];
                first.publisher = tableToConsole[i, 4];
                first.criticScore = (tableToConsole[i, 10]);
                first.criticCount = (tableToConsole[i, 11]);
                first.userScore = (tableToConsole[i, 12]);
                first.userCount = (tableToConsole[i, 13]);
                first.developer = tableToConsole[i, 14];
                first.rating = tableToConsole[i, 15];
                DbSave.SaveFirstTable(first);
            }




        }
    }
}