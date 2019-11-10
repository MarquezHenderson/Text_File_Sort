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

namespace Text_File_Sort
{
    public partial class Text_File_Sort : Form
    {
        String[] lines;
        List<String> templist = new List<String>();
        bool isSortedaToz = false;
        bool linesAdded = false;
        public Text_File_Sort()
        {
            InitializeComponent();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var odf = new OpenFileDialog();
            odf.InitialDirectory = "C:\\";
            odf.Multiselect = false;
            odf.Title = "Please Select only Text and Word Files";
            odf.Filter = "txt files(*.txt)|*.txt";
            if(DialogResult.OK == odf.ShowDialog())
            {
                listBox.Items.Clear();
                var words = odf.FileName;
                lines = File.ReadAllLines(words);
                //foreach method(the long way)
                //lines.ToList(); 
                //foreach (var word in lines)
                //{
                //    listBox.Items.Add(word);
                //}

                lines.ToList().ForEach(word => listBox.Items.Add(word));
                lab_File_Count.Text = lines.Length.ToString();
                linesAdded = true;

            }
            
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if(linesAdded == true)
            {
                //listBox.Items.Clear();
                var bgw = new BackgroundWorker();
                bgw.DoWork += (myob, myev) =>
                {
                    //var tempList = new List<String>();
                    var lineSort = lines.ToList();
                    if (isSortedaToz == false)
                    {
                        //listBox.DataSource = null;
                        listBoxSorted.DataSource = null;
                        templist.Clear();
                        lineSort.Sort();
                        lineSort.ForEach(word => templist.Add(word));
                        isSortedaToz = true;
                    }
                    else
                    {

                        //listBox.DataSource = null;
                        listBoxSorted.DataSource = null;
                        templist.Clear();
                        lineSort.Sort();
                        lineSort.Reverse();
                        //lineSort.OrderByDescending(x => x.CompareTo(x)).ToList();
                        lineSort.ForEach(word => templist.Add(word));
                        isSortedaToz = false;
                    }


                };
                bgw.RunWorkerCompleted += (myob, myev) =>
                {
                    listBoxSorted.DataSource = templist;
                };
                bgw.RunWorkerAsync();


            }
            else
            {
                MessageBox.Show("Please load text file.");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox.DataSource = null;
            listBoxSorted.DataSource = null;
            templist.Clear();
            listBox.Items.Clear();
            listBoxSorted.Items.Clear();
            isSortedaToz = false;
            linesAdded = false;
            lab_File_Count.Text = "0";
        }


    }
}
