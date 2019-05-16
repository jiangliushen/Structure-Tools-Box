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
    public partial class ParentCountForm : Form
    {
        public ParentCountForm()
        {
            InitializeComponent();
        }
        string strDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);//桌面路径
        int m;
        int sum;
        int drawingcount=0;
        int fileNo = 0;      
        
        private void button1_Click(object sender, EventArgs e)
        {
            init();
            //模板相对路径
            string Template_Path = @"Template\Template.xlsx";

            //重新定义一个工作簿用于存放数据
            Workbook outworkbook = File.Exists(Template_Path) ? new Workbook(Template_Path) : new Workbook();
            Worksheet outworksheet = outworkbook.Worksheets[0];
            Cells outcells = outworksheet.Cells;
            
            FolderBrowserDialog dialog = new FolderBrowserDialog();//打开文件夹对话框
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //获取文件夹路径
                string folderPath = dialog.SelectedPath;
                //设置tbfile内容
                tbFile.Text = folderPath;
                //实力文件夹里文件
                DirectoryInfo root = new DirectoryInfo(folderPath);
                FileInfo[] files = root.GetFiles();
                //遍历单个文件
                foreach (FileInfo file in files)
                {
                    //获取单个文件路径名
                    string fileFullName = file.FullName;
                    string fileName = file.Name;
                    string[] drawingNo = fileName.Split(' ');
                    string drawingNos = drawingNo[0];
                    //string moduleNo = drawingNo[1];
                    //drawingcount = 0;                    

                    checkFile(fileFullName, outcells,drawingNos);
                    //进度条
                    pgb.Minimum = 0;
                    pgb.Maximum = files.Length - 1;//最大值
                    pgb.Step = 1;
                    pgb.PerformStep();// 使用performstep方法按Step值递增
                }

            }
            //保存文件
            
            try
            {
                outworkbook.Save(strDesktopPath + @"\型材数量统计.xlsx");
                tbCount.Text = m.ToString();
                tbFinish.Text = "已完成";
            }
            catch
            {
                MessageBox.Show("请关闭相应表格", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void init()
        {
            m = 0;
            sum = 0;
            tbCount.Text = string.Empty;
            rtbCount.Text = string.Empty;
            tbFinish.Text = string.Empty;
            pgb.Minimum = 0;
            pgb.Maximum = 0;
        }

        private void checkFile(string fileFullName, Cells outcells,string drawingNos)
        {
            Workbook workbook = new Workbook(fileFullName);
            Worksheet worksheet = workbook.Worksheets[0];
            Cells cells=worksheet.Cells;
            Style style = outcells[0, 0].GetStyle();
            style.ForegroundColor = Color.Yellow;
            
            ////获取工作簿数据中心对象
            //DataSorter sorter = workbook.DataSorter;
            ////设置datasorter对象的顺序
            //sorter.Order1 = Aspose.Cells.SortOrder.Descending;
            ////定义键第三列的键
            //sorter.Key1 = 2;
            ////创建一个单元格区域（范围）。
            //CellArea ca = new CellArea();
            ////指定起始行索引。
            //ca.StartRow = 1;
            ////指定起始列索引。
            //ca.StartColumn = 2;
            ////指定最后一行索引。
            //ca.EndRow = cells.MaxDataRow;
            ////指定最后一列索引。
            //ca.EndColumn = 5;
            //sorter.Sort(cells,ca);
            //TBJN0126-D-MTO-ST-0036料单04在料单里的序号-HM244X175X7X11X12000规格-Q345B材质-051第几根

            //求杆件净总长
            sum = 0;
            drawingcount = 0;
            for (int j = 1; j <= cells.MaxDataRow; j++)
            {
                
                try
                {                    
                    string strlength = cells[j, 8].Value.ToString();
                    sum += int.Parse(strlength);
                }
                catch
                {
                    continue;
                }
            }
           

            string cell2 = string.Empty;
            string str = string.Empty;

            int i;
            for (i=1;i<=cells.MaxDataRow;i++)
            {
                try
                {
                    cell2 = cells[i, 2].Value.ToString();
                    if (cell2 == "缺料")
                    {

                        //有表头+1
                        outcells[m + 1, 0].PutValue(drawingNos);
                        outcells[m + 1, 1].PutValue(cells[i, 1].Value);
                        outcells[m + 1, 3].PutValue(cells[i, 5].Value.ToString());//规格                        
                        outcells[m + 1, 2].PutValue("缺料");//物料编码
                        outcells[m + 1, 5].PutValue("缺料");//料单                                           
                        //outcells[m + 1, 6].PutValue(number);//在料单里的序号
                        //outcells[m + 1, 7].PutValue(dijigen);//第几根
                        outcells[m + 1, 8].PutValue(cells[i, 8].Value.ToString());//母材长度

                        m++;
                        drawingcount++;
                        //一张图纸的根数
                        outcells[m, 4].PutValue(drawingcount);

                    }
                    else {
                        string[] cell2s = cell2.Split('-');
                        string liaodan = cell2s[0] + cell2s[1] + cell2s[2] + cell2s[3] + cell2s[4];//料单
                        string number = cell2s[5];//在料单里的序号
                        string dijigen = cell2s[8];//第几根
                        str = cell2.Substring(cell2.Length - 2);
                        if (cell2 != null && str != "-1")
                        {
                            //有表头+1
                            outcells[m + 1, 0].PutValue(drawingNos);
                            outcells[m + 1, 1].PutValue(cells[i, 1].Value);
                            outcells[m + 1, 3].PutValue(cells[i, 5].Value.ToString());//规格                                           
                            outcells[m + 1, 2].PutValue(drawingNos + "-" + cell2);//物料编码                            
                            outcells[m + 1, 5].PutValue(liaodan);//料单                                                  
                            outcells[m + 1, 6].PutValue(number);//在料单里的序号
                            outcells[m + 1, 7].PutValue(dijigen);//第几根
                            outcells[m + 1, 8].PutValue(cells[i, 4].Value.ToString());//母材长度

                            m++;
                            drawingcount++;
                            //一张图纸的根数
                            outcells[m, 4].PutValue(drawingcount);

                        }
                        else
                        {
                            continue;
                        }                      
                    }
                    
                }
                catch
                {                    
                    continue;
                }
                
            }            
            rtbCount.AppendText(drawingNos + "一张图纸有：" + drawingcount+"\n");
             


            //净长度总和
            outcells[m, 9].PutValue(sum);
            //循环设置一行颜色
            for(int k=0; k < 10; k++)
            {
                outcells[m, k].SetStyle(style);
            }            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(strDesktopPath + @"\型材数量统计.xlsx");//打开桌面路径下的Weldinging List
        }
    }
}
