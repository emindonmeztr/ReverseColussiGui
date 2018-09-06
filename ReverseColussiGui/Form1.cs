using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseColussiGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_findAll_Click(object sender, EventArgs e)
        {
            bool filled = false;
            String pattern = "";
            String source = "";



            if (string.IsNullOrEmpty(tbox_Pattern.Text) || string.IsNullOrEmpty(rtbox_Source.Text))
            {
                MessageBox.Show("Onları bir doldur.");
            }
            else
            {
                filled = true;
                pattern = tbox_Pattern.Text;
                source = rtbox_Source.Text;
                lview_Index.Items.Clear();
            }




            if (filled == true) {

                try
                {
                    IList<int> indexList = RC.findAll(pattern, source);
                    
                    for (int i = 0; i < indexList.Count; i++)
                    {
                        lview_Index.Items.Add(indexList[i].ToString());
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }

                
            }




            
        }
    }
}
