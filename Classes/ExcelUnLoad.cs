using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Diagnostics.Metrics;
using System.IO;
using System.Windows.Forms;

namespace kulinaria_Efimov.Classes
{
    internal class ExcelUnLoad
    {
        public void ExportProductsToExcel(List<ProductsClass> products)
        {
            Excel.Application oXL = null;
            Excel._Workbook oWB = null;
            Excel._Worksheet oSheet = null;
            Excel.Range oRng = null;

            try
            {
                oXL = new Excel.Application();
                oWB = (Excel._Workbook)(oXL.Workbooks.Add(System.Reflection.Missing.Value));
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                string[] headers = { "ID", "Название", "Белки (г)", "Жиры (г)", "Углеводы (г)" };
                for (int i = 0; i < headers.Length; i++)
                {
                    oSheet.Cells[1, i + 1] = headers[i];
                }

                for (int i = 0; i < products.Count; i++)
                {
                    oSheet.Cells[i + 2, 1] = products[i].ProductId;
                    oSheet.Cells[i + 2, 2] = products[i].ProductName;
                    oSheet.Cells[i + 2, 3] = products[i].Protein;
                    oSheet.Cells[i + 2, 4] = products[i].Fat;
                    oSheet.Cells[i + 2, 5] = products[i].Carbs;
                }

                oSheet.get_Range("A1", "E1").Font.Bold = true;
                oSheet.get_Range("A1", "E1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                oSheet.get_Range("A1", "E1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                oSheet.get_Range("C2", "E" + (products.Count + 1)).NumberFormat = "0.00";

                oRng = oSheet.get_Range("A1", "E1");
                oRng.EntireColumn.AutoFit();

                var cells = oSheet.get_Range("A1", "E" + (products.Count + 1));
                cells.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    $"ExportProducts_{DateTime.Now:dd.MM.yyyy}.xlsx");
                oWB.SaveAs(filePath);
                MessageBox.Show($"Файл сохранен: {filePath}");

                // Закрытие
                oWB.Close();
                oXL.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                ReleaseObject(oSheet);
                ReleaseObject(oWB);
                ReleaseObject(oXL);
            }
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        public void Soglasie(string surname, string name, string patronymic,
                                     string passportSeries, string passportNumber,
                                     string issueDate, string issuingAuthority,
                                     string address, string username)
        {
            string templatePath = Path.Combine("../../docs", "Форма_согласия.docx");
            string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"Согласие_{surname}.docx");

            try
            {
                if (File.Exists(savePath))
                {
                    DialogResult result = MessageBox.Show(
                        "Файл уже существует. Хотите заменить его?",
                        "Подтверждение замены",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                    {
                        MessageBox.Show("Операция отменена.");
                        return;
                    }
                }

                File.Copy(templatePath, savePath, true);

                Word.Application app = new Word.Application();
                object filename = savePath;
                object missing = Type.Missing;
                Word.Document doc;

                string passportInfo = $"Паспорт {passportSeries} {passportNumber}, выдан {issueDate}, {issuingAuthority}";
                string currentDate = DateTime.Now.Day.ToString();
                string currentMonth = DateTime.Now.ToString("MMMM");

                string[] finds = { "{ФИО}", "{ДОКУМЕНТ}", "{АДРЕС}", "{ДАТА}", "{МЕСЯЦ}" };
                string[] data = { $"{surname} {name} {patronymic}".Trim(), passportInfo, address, currentDate, currentMonth, username, $"{surname} {name} {patronymic}".Trim() };

                for (int i = 0; i < finds.Length; ++i)
                {
                    doc = app.Documents.Open(filename, missing, missing);
                    app.Selection.Find.Execute(finds[i], missing, missing, missing, missing, missing, missing, missing, missing, data[i]);
                    doc.Save();
                    doc.Close();
                }

                app.Quit();
                MessageBox.Show($"Договор сохранен по пути {savePath}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }


}
