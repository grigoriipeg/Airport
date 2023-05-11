using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using US_5A_Net.models;

namespace US_5A_Net
{
    public partial class AirportForm : Form
    {
        private readonly List<Flights> flights;

        private readonly BindingSource BinSource;
        decimal decout;
        public AirportForm()
        {
            InitializeComponent();
            FlightsDGV.AutoGenerateColumns = false;
            flights = new List<Flights>();
            BinSource = new BindingSource();
            //BinSource.DataSource = flights;
            FlightsDGV.DataSource = flights;       
        }


        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил: афтор", "Аэропорт",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void AddTool_Click(object sender, EventArgs e)
        {
            var infoForm = new FlightsForm();

            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                flights.Add(infoForm.Flights);
                BinSource.ResetBindings(false);
                InfoStatCal();
            }
        }


        private void DeleteTool_Click(object sender, EventArgs e)
        {
            var id = (Flights)FlightsDGV.Rows[FlightsDGV.SelectedRows[0].Index].DataBoundItem;
            if (MessageBox.Show($"Вы действительно хотите удалить рейс {id.numflight}, прилетающий {id.eta:G}?",
                "Удаление записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                flights.Remove(id);
                BinSource.ResetBindings(false);
                InfoStatCal();
            }
        }


        private void ChangeTool_Click(object sender, EventArgs e)
        {
            var id = (Flights)FlightsDGV.Rows[FlightsDGV.SelectedRows[0].Index].DataBoundItem;
            var infoForm = new FlightsForm(id);
            if (infoForm.ShowDialog(this) == DialogResult.OK)
            {
                id.numflight = infoForm.Flights.numflight;
                id.type = infoForm.Flights.type;
                id.eta = infoForm.Flights.eta;
                id.countPas = infoForm.Flights.countPas;
                id.pricePas = infoForm.Flights.pricePas;
                id.countCrew = infoForm.Flights.countCrew;
                id.priceCrew = infoForm.Flights.priceCrew;
                id.procDop = infoForm.Flights.procDop;
                BinSource.ResetBindings(false);
                InfoStatCal();
            }
        }


        private void FlightsDGV_SelectionChanged(object sender, EventArgs e)
        {
            DeliteMenu.Enabled =
            ChangeMenu.Enabled =
            DeliteTool.Enabled =
            ChangeTool.Enabled =
            FlightsDGV.SelectedRows.Count > 0;
        }


        private void InfoStatCal()
        {
            CountFlightsTSSL.Text = $"Кол-во рейсов: {flights.Count}";
            CountPasTSSL.Text = $"Всего пассажиров: {flights.Sum(x => x.countPas)}";
            CountCrewTSSL.Text = $"Всего экипажа: {flights.Sum(x => x.countCrew)}";
            SumTSSL.Text = $"Общая сумма: {flights.Sum(x => x.sum)}";
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void expBtn_Click(object sender, EventArgs e)
        {
            var ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelWorkSheet.Columns.ColumnWidth = 24;
            ExcelApp.Cells[1, 1] = "Номер рейса";
            ExcelApp.Cells[1, 2] = "Тип самолёта";
            ExcelApp.Cells[1, 3] = "Время прибытия";
            ExcelApp.Cells[1, 4] = "Кол-во пассажиров";
            ExcelApp.Cells[1, 5] = "Сбор за пассажира";
            ExcelApp.Cells[1, 6] = "Кол-во экипажа";
            ExcelApp.Cells[1, 7] = "Сбор за экипаж";
            ExcelApp.Cells[1, 8] = "Процент надбавки";
            ExcelApp.Cells[1, 9] = "Выручка";
            for (int i = 0; i < FlightsDGV.Rows.Count; i++)
            {
                for (int j = 0; j < FlightsDGV.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = FlightsDGV.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            expBtn_Click(sender, e);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = ""; //variable for the Excel File Location
            DataTable dt = new DataTable(); //container for our excel data
            DataRow row;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Check if Result == "OK".
            {
                file = openFileDialog1.FileName; //get the filename with the location of the file
                try
                {
                    //Create Object for Microsoft.Office.Interop.Excel that will be use to read excel file

                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

                    Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(file);

                    Microsoft.Office.Interop.Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];

                    Microsoft.Office.Interop.Excel.Range excelRange = excelWorksheet.UsedRange;

                    int rowCount = excelRange.Rows.Count; //get row count of excel data

                    int colCount = excelRange.Columns.Count; // get column count of excel data

                    //Get the first Column of excel file which is the Column Name

                    for (int i = 1; i <= rowCount; i++)
                    {
                        for (int j = 1; j <= colCount; j++)
                        {
                            dt.Columns.Add(excelRange.Cells[i, j].Value2.ToString());
                        }
                        break;
                    }

                    //Get Row Data of Excel

                    int rowCounter; //This variable is used for row index number
                    for (int i = 2; i <= rowCount; i++) //Loop for available row of excel data
                    {
                        row = dt.NewRow(); //assign new row to DataTable
                        rowCounter = 0;
                        for (int j = 1; j <= colCount; j++) //Loop for available column of excel data
                        {
                            //check if cell is empty
                            if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                            {
                                row[rowCounter] = excelRange.Cells[i, j].Value2.ToString();
                            }
                            else
                            {
                                row[i] = "";
                            }
                            rowCounter++;
                        }
                        dt.Rows.Add(row); //add row to DataTable
                    }

                    FlightsDGV.DataSource = dt; //assign DataTable as Datasource for DataGridview

                    //close and clean excel process
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Marshal.ReleaseComObject(excelRange);
                    Marshal.ReleaseComObject(excelWorksheet);
                    //quit apps
                    excelWorkbook.Close();
                    Marshal.ReleaseComObject(excelWorkbook);
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {   
                //flights.ToList().Sort(x => x.numflight);
                //FlightsDGV.Sort(FlightsDGV.Columns[0]);
            }
            else if (rb2.Checked)
            {
                FlightsDGV.Sort(FlightsDGV.Columns[1], ListSortDirection.Ascending);
            }
            else if (rb3.Checked)
            {
                FlightsDGV.Sort(FlightsDGV.Columns[2], ListSortDirection.Ascending);
            }
            else if (rb4.Checked)
            {
                FlightsDGV.Sort(FlightsDGV.Columns[3], ListSortDirection.Ascending);
            }
            else if (rb5.Checked)
            {
                FlightsDGV.Sort(FlightsDGV.Columns[4], ListSortDirection.Ascending);
            }
            else if (rb6.Checked)
            {
                FlightsDGV.Sort(FlightsDGV.Columns[5], ListSortDirection.Ascending);
            }
            else if (rb7.Checked)
            {
                FlightsDGV.Sort(FlightsDGV.Columns[6], ListSortDirection.Ascending);
            }
            else if (rb8.Checked)
            {
                FlightsDGV.Sort(FlightsDGV.Columns[7], ListSortDirection.Ascending);
            }
            else if (rb9.Checked)
            {
                //BinSource.Sort = "sumColumn";
                //flights = new BindingList<Flights>(sortedList);
            }
        }

        private void filter_txt_TextChanged(object sender, EventArgs e)
        {
            if (more_radio.Checked)
            {
                more_radio_CheckedChanged(sender, e);
            }
            else if (less_radio.Checked)
            {
                less_radio_CheckedChanged(sender, e);
            }
        }

        private void less_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(filter_txt.Text, out decout))
            {
                for (int i = 0; i < FlightsDGV.Rows.Count - 1; i++)
                {
                    if (decimal.Parse(FlightsDGV.Rows[i].Cells[8].Value.ToString())
                        > decimal.Parse(filter_txt.Text))
                    {
                        FlightsDGV.Rows[i].Visible = false;
                    }
                    else
                    {
                        FlightsDGV.Rows[i].Visible = true;
                    }
                }
            }
        }

        private void more_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(filter_txt.Text, out decout))
            {
                for (int i = 0; i < FlightsDGV.Rows.Count - 1; i++)
                {
                    if (decimal.Parse(FlightsDGV.Rows[i].Cells[8].Value.ToString())
                        < decimal.Parse(filter_txt.Text))
                    {
                        FlightsDGV.Rows[i].Visible = false;
                    }
                    else
                    {
                        FlightsDGV.Rows[i].Visible = true;
                    }
                }
            }
        }
    }
}
