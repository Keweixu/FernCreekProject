using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

using Control = System.Windows.Forms.Control;

namespace FernCreekProject
{
    public partial class Form1 : Form
    {
        //private List<ColData> AllData;
        private DataTable AllData = null;
        public Form1()
        {
            //Required by ExcelDataReader to parse strings in binary BIFF@-5 Excel docs encoded with DOS-era code page. Not in .Net core by default
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            InitializeComponent();
            CheckExportRules();
        }

        #region Import Code
        private void ImportData()
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.AddExtension = true;
            openDialog.CheckFileExists = true;
            openDialog.CheckPathExists = true;
            openDialog.FileName = string.Empty;
            openDialog.InitialDirectory = "C://";

            openDialog.Filter = "Excel files|*.xlsx";
            openDialog.Title = "Select an Excel file to import.";
            openDialog.ShowDialog();
            var importPath = openDialog.FileName;
            txtImport.Text = importPath;

            AllData = LoadDocExcelDataReader(importPath);
            CheckExportRules();
            dgrdData.DataSource = AllData;

        }

        //Grabs data using ExcelDataReader
        //MIT license
        //https://github.com/ExcelDataReader/ExcelDataReader
        private DataTable LoadDocExcelDataReader(string path)
        {
            DataTable allData = null;
            if (File.Exists(path))
            {
                try
                {
                    using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                        {
                            var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });

                            allData = result?.Tables[0];
                        }
                    }
                }
                catch (IOException e)
                { 
                    MessageBox.Show("File may be in use.");
                }
            }

            return allData;
        }


        #endregion

        #region Export Code
        private void Export()
        {
            //Assuming user only inporting employees for now, can give users ability to name these 
            AllData.TableName = "Employee";

            string filter = string.Empty;
            string title = string.Empty;

            if (rdoXML.Checked)
            {
                filter = "XML|*.xml";
                title = "Save as XML";
            }
            else if (rdoJSON.Checked)
            {
                filter = "JSON|*.json";
                title = "Save as JSON";
            }
            else if (rdoDelimited.Checked)
            {
                filter = "Text file|*.txt";
                title = "Save as delimited";
            }


            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = filter;
            saveDialog.Title = title;
            saveDialog.ShowDialog();

            var exportFile = saveDialog.FileName;

            if (string.IsNullOrWhiteSpace(exportFile))
                return;

            if (rdoXML.Checked)
            {
                ExportXML(exportFile);
            }
            else if (rdoJSON.Checked)
            {
                ExportJSON(exportFile);
            }
            else if (rdoDelimited.Checked)
            {
                ExportDelimited(exportFile);
            }

        }

        private void ExportXML(string file)
        {
            if (!string.IsNullOrWhiteSpace(file))
                AllData.WriteXml(file);
        }

        private void ExportJSON(string file)
        {
            var jsonString = JsonConvert.SerializeObject(AllData);
            File.WriteAllText(file, jsonString);
        }

        private void ExportDelimited(string file)
        {
            var sb = new StringBuilder();
            var colHeaders = AllData.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
            sb.AppendLine(string.Join(txtDelimiter.Text, colHeaders));

            foreach (DataRow row in AllData.Rows)
            {
                var fields = row.ItemArray.Select(x => x.ToString().Replace(txtDelimiter.Text, string.Empty)).ToArray();
                sb.AppendLine(string.Join(txtDelimiter.Text, fields));
            }

            File.WriteAllText(file, sb.ToString());
        }

        #endregion

        #region internal methods
        //Quick validation for export button enable
        private void CheckExportRules()
        {
            bool isValid =
                CheckError(txtDelimiter, "A value must be entered here for delimited format export.", () =>
                {
                    return rdoDelimited.Checked ? !string.IsNullOrWhiteSpace(txtDelimiter.Text) : true;
                }) &&
                CheckError(txtImport, "No import file selected.", () =>
                {
                    return AllData != null;
                });

            btnExport.Enabled = isValid;

        }

        //Could be a control extension, but I dont want to create a static class just for one thing
        private bool CheckError(Control control, string errorText, Func<bool> ruleToFollow)
        {
            if (ruleToFollow.Invoke())
            {
                errorProvider1.SetError(control, string.Empty);
                return true;
            }
            else
            {
                errorProvider1.SetError(control, errorText);
                return false;
            }
        }


        #endregion

        #region Events
        private void BrowseClick(object sender, EventArgs e)
        {
            ImportData();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void rdoDelimited_CheckedChanged(object sender, EventArgs e)
        {
            txtDelimiter.Enabled = rdoDelimited.Checked;
            txtDelimiter.Text = string.Empty;
            CheckExportRules();
        }

        private void txtDelimiter_TextChanged(object sender, EventArgs e)
        {
            CheckExportRules();
        }


        //Handles sorting the datatable when user sorts by column
        private void dgrdData_Sorted(object sender, EventArgs e)
        {
            var colsort = dgrdData.SortedColumn;
            var view = AllData.DefaultView;

            string sortOrder = dgrdData.SortOrder == SortOrder.Descending ? "desc" : "asc";
            view.Sort = $"{dgrdData.SortedColumn.Name} {sortOrder}";
            AllData = view.ToTable();
        }
        #endregion

    }
}
