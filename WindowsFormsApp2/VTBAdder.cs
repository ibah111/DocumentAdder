﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel.Application;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.DirectoryServices.AccountManagement;

namespace WindowsFormsApp2
{
    public class PersonInfo
    {
        public string fio;
        public string birth_date;
        public string birth_place;
        public string exec_number;
        public string court_doc_num;
        public string state;
        public string inn;
        public string typ;
        public string number;
        public string series;
        public string court_date;
        public string sum;
        public string name;
        public string exec_date;
    }
    class VTBAdder
    {
        private static string path = Environment.CurrentDirectory + $"\\{DateTime.Now.Date.ToString().Split(' ')[0]} Result {UserPrincipal.Current.DisplayName}.xlsx";
        public static void Add(PersonInfo personInfo)
        {
            Excel excel = new Excel();
            var workbook = excel.Workbooks.Open(path,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing);
            excel.Visible = false;
            excel.DisplayAlerts = false;
            Worksheet sheet = (Worksheet)excel.Worksheets.get_Item(1);
            int countRow = sheet.UsedRange.Rows.Count;
            int targetRow = countRow + 1;
            sheet.Cells[targetRow, 1] = countRow - 4;
            sheet.Cells[targetRow, 3] = personInfo.court_doc_num.Replace("№", "").Replace(" ", "").ToUpper();
            sheet.Cells[targetRow, 4] = personInfo.court_date;
            sheet.Cells[targetRow, 5] = personInfo.name;
            sheet.Cells[targetRow, 6] = personInfo.sum;
            sheet.Cells[targetRow, 7] = personInfo.fio;
            sheet.Cells[targetRow, 8] = "2";
            sheet.Cells[targetRow, 9] = personInfo.birth_date;
            sheet.Cells[targetRow, 10] = personInfo.series;
            sheet.Cells[targetRow, 11] = personInfo.number;
            sheet.Cells[targetRow, 12] = personInfo.inn;
            sheet.Cells[targetRow, 15] = personInfo.exec_number;
            sheet.Cells[targetRow, 16] = personInfo.exec_date;
            sheet.Cells[targetRow, 17] = personInfo.birth_place;
            Range range = sheet.Range[sheet.Cells[targetRow, 1], sheet.Cells[targetRow, 16]];
            range.Font.Name = "Arial";
            range.Font.Size = 8;
            range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            range.VerticalAlignment = XlVAlign.xlVAlignCenter;
            range.Borders.Item[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            range.Borders.Item[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            range.Borders.Item[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            range.Borders.Item[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            range.Borders.Item[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            range.Borders.Item[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            //range.EntireColumn.AutoFit();
            Range range2 = sheet.Range[sheet.Cells[targetRow, 1], sheet.Cells[targetRow, 2]];
            range2.Borders.Item[XlBordersIndex.xlEdgeRight].Weight = 3;
            range2.Borders.Item[XlBordersIndex.xlEdgeBottom].Weight = 3;
            range2.Borders.Item[XlBordersIndex.xlInsideVertical].Weight = 3;
            excel.Application.ActiveWorkbook.SaveAs(path, XlFileFormat.xlWorkbookDefault,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            excel.Quit();
        }

        public static (bool error, string message) CreateExcel()
        {
            string patternPath = Environment.CurrentDirectory + "\\Data\\Шаблон.xlsx";
            if (File.Exists(path))
                return (error: false, message: "");
            else
            {
                if (File.Exists(patternPath))
                {
                    Excel excel = new Excel();
                    excel.Workbooks.Open(patternPath,
                              Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                              Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                              Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                              Type.Missing, Type.Missing);
                    excel.Application.ActiveWorkbook.SaveAs(path, XlFileFormat.xlWorkbookDefault,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    excel.Quit();
                    return (error: false, message: path);
                }
                else
                    return (error: true, message: $"Произошла ошибка, шаблон отсутсвует по данному пути: {patternPath}");
            }
        }
    }
}
