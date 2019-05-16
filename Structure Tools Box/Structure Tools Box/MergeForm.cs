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
using Aspose.Cells;

namespace Structure_Tools_Box
{
    public partial class MergeForm : Form
    {
        public MergeForm()
        {
            InitializeComponent();
        }
        //桌面路径
        string strDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string margerTemplatePath = @"..\..\Template\MergeExcelTemplate.xlsx";
        int row = 1;
        
        private void btnImport_Click(object sender, EventArgs e)
        {
            init();
            FolderBrowserDialog dialog = new FolderBrowserDialog();           
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //获取表格路径
                string folderPath = dialog.SelectedPath;
                tbPath.Text = folderPath;
                
                Workbook templateWorkbook = new Workbook(margerTemplatePath);
                Worksheet templateWorksheet = templateWorkbook.Worksheets[0];
                Cells templateCells = templateWorksheet.Cells;

                DirectoryInfo root = new DirectoryInfo(folderPath);
                FileInfo[] files = root.GetFiles();//只能get一种文件格式
                foreach (FileInfo file in files)
                {
                    string fileFullName = file.FullName;//文件全路径
                    string fileName = file.Name;
                    //创建对应表    
                    try
                    {
                        Workbook Workbook = new Workbook(tbPath.Text + @"\" + fileName);
                    }
                    catch
                    {
                        MessageBox.Show("请关闭需要使用到的表格或路径错误", "错误警告", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    Workbook MergeWorkbook = new Workbook(tbPath.Text +@"\"+ fileName);
                    //Workbook MergeWorkbook = new Workbook(fileFullName);
                    Worksheet MergeWorksheet = MergeWorkbook.Worksheets[0];
                    Cells mergeCells = MergeWorksheet.Cells;
                    int maxRow = mergeCells.MaxDataRow;
                    int maxCol = mergeCells.MaxDataColumn;
                    
                    for ( int i = 1; i <= maxRow; i++)
                    {
                        try
                        {
                            for (int j = 0; j <= maxCol; j++)
                            {
                                templateCells[row, j].PutValue(mergeCells[i, j].Value);
                            }
                            row++;
                            pgbRun.Minimum = 0;//进度条
                            pgbRun.Maximum = row;//最大值
                            pgbRun.Step = 1;
                            pgbRun.PerformStep();// 使用performstep方法按Step值递增
                        }
                        catch
                        {
                            MessageBox.Show("遇到错误或空行，已跳过该行！！！", "错误警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            continue;
                        }                                             
                    }
                }
                //保存文件
                try
                {
                    templateWorkbook.Save(strDesktopPath + @"\合并后.xlsx");
                    lbFinish.Text = "已完成！";
                }
                catch
                {
                    MessageBox.Show("请关闭需要使用到的表格", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void init()
        {
            row = 1;
            tbPath.Text = string.Empty;
            pgbRun.Value= 0;
            lbFinish.Text = "等待...";
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(strDesktopPath + @"\合并后.xlsx");//打开桌面路径下的合并后.xlsx
        }
    }
}
