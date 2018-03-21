using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    class excelClass
    {
        Excel.Application oXL;
        Excel._Workbook wb;
        Excel._Worksheet ws;
        Excel.Range eRange;
        object misValue;
        char [] alf = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N' };
        public excelClass()
        {
             
        }
        public void Create()
        {
            oXL = new Excel.Application();
            misValue = System.Reflection.Missing.Value; 
            wb = oXL.Workbooks.Add(misValue);
            ws = (Excel.Worksheet)oXL.Worksheets.get_Item(1);
            eRange = ws.UsedRange;
            ws = (Excel.Worksheet)oXL.ActiveSheet;
        }
        public void basliklar(int count)
        {
            for (int j = 1; j <= count; j++)
            {
                ws.get_Range("A1", "N1").Font.Bold = true;
                ws.Cells[1, j] = "x" + j;
                if(j==count)
                {
                    ws.Cells[1, (j + 1)] = "Toplam fonk";
                    ws.Cells[1, (j + 2)] = "Akt. fonk";
                }
            }
        }
        public void print(int data,int count,double cell)
        {
                    ws.Cells[data,count] = cell;       
        }
        public void veriSeti(int data, int count)
        {
            int karma;
            Random rnd = new Random();
            for (int i = 2; i <= count + 1; i++)
            {
                for (int j = 1; j <= data; j++)
                {
                    karma = rnd.Next(5, 105);
                    ws.Cells[i, j] = karma;
                }
            }
        }

        //public List<double> veriOku(int data,int count) ---->Fetch();
        //{
        //    char start;
        //    List<double> veriler = new List<double>();
        //    for (int i = 1; i < data+1; i++)
        //    {
        //        start = alf[i-1];
        //        for (int j = 2; j <= count+1; j++)
        //        {
        //            veriler.Add(ws.get_Range(start+""+j,start+""+j).Value2);
        //        }
        //    }
        //    return veriler;
        //}
        public void show()
        {
            oXL.Visible = true;
        }
        public void kapatma()
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oXL);
                oXL = null;
            }
            catch (Exception e)
            {
                oXL = null;
            }
            finally
            { 
                GC.Collect();
            }
        }
        public List<double> fetch(int data, int count)
        {
            List<double> a = new List<double>();
            char start;
            for (int i = 2; i <= count+1; i++)
            {
                for (int j = 2; j <= data+1; j++)
                {
                    start = alf[j - 2];
                    a.Add(ws.get_Range(start+""+i).Value2);
                }

            }
            return a;
        }

    }
}
