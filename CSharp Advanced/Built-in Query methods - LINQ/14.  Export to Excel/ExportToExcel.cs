namespace _14.Export_to_Excel
{
    using System;
    using System.IO;
    using System.Linq;
    using OfficeOpenXml;
    using OfficeOpenXml.Style;

    public class ExportToExcel
    {
        public static void Main()
        {
            var xlsPackage = new ExcelPackage();
            var workSheet = CreateSheet(xlsPackage, "Student Results");
            workSheet.Cells[1, 1, 1, 11].Merge = true;
            workSheet.Cells[1, 1].Value = "SoftUni Exam Results";
            workSheet.Cells[1, 1].Style.Font.Size = 20;
            workSheet.Cells[1, 1].Style.Font.Color.Indexed = 17;
            workSheet.Cells[1, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            var row = 2;
            using (var reader = new StreamReader("../../StudentData.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var readCells = line.Split('\t');
                    for (int i = 1; i <= readCells.Length; i++)
                    {
                        workSheet.Cells[row, i].Value = readCells[i - 1];
                        workSheet.Cells[2, i].Style.Font.Size = 14;
                        workSheet.Cells[2, i].Style.Font.Color.Indexed = 20;
                    }
                    row++;
                    line = reader.ReadLine();
                }
                workSheet.Cells[103, 1, 103, 5].Merge = true;
                workSheet.Cells[103, 1].Value = "Average";
                workSheet.Cells[103, 1].Style.Font.Size = 15;
                workSheet.Cells[103, 1].Style.Font.Color.Indexed = 14;
                workSheet.Cells[103, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                GetAverage(workSheet, 3, 6, 102, 6, 103, 6);
                GetAverage(workSheet, 3, 7, 102, 7, 103, 7);
                GetAverage(workSheet, 3, 8, 102, 8, 103, 8);
                GetAverage(workSheet, 3, 9, 102, 9, 103, 9);
                GetAverage(workSheet, 3, 10, 102, 10, 103, 10);
                var averageGroup4 = workSheet.Cells[3, 10, 102, 10].ToList();
                workSheet.Cells[103, 10].Value = Math.Round(averageGroup4.Select(n => int.Parse(n.Value.ToString())).Average(), 2);
            }

            var output = new FileStream("../../sample.xlsx", FileMode.Create);
            xlsPackage.SaveAs(output);
        }
        private static ExcelWorksheet CreateSheet(ExcelPackage p, string sheetName)
        {
            p.Workbook.Worksheets.Add(sheetName);
            ExcelWorksheet sheet = p.Workbook.Worksheets[1];
            sheet.Name = sheetName;
            sheet.Cells.Style.Font.Size = 12;
            sheet.Cells.Style.Font.Name = "TimesNewRoman";

            return sheet;
        }

        private static void GetAverage(ExcelWorksheet workSheet, int fromRow, int fromCol, int toRow, int toCol, int writeInRow, int writeInCol)
        {
            var averageGroup = workSheet.Cells[fromRow, fromCol, toRow, toCol].ToList();
            workSheet.Cells[writeInRow, writeInCol].Value = Math.Round(averageGroup.Select(n => int.Parse(n.Value.ToString())).Average(), 2);
            workSheet.Cells[writeInRow, writeInCol].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Cells[writeInRow, writeInCol].Style.Font.Color.Indexed = 14;
        }
    }
}
