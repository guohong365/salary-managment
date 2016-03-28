using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GridControlTest
{
    public partial class Form1 : Form
    {
        private List<Item2> items=new List<Item2>();

        void init()
        {
            items.AddRange(new Item2[]
            {
                new Item2("1", "11", "111"), 
                new Item2("2", "22", "222"), 
                new Item2("3", "33", "333"), 
                new Item2("4", "44", "444"), 
                new Item2("5", "55", "555"), 
                new Item2("6", "66", "666"), 
                new Item2("7", "77", "777"), 
                new Item2("8", "88", "888") 
            });
        }

        public Form1()
        {
            init();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = items;
        }
    }
}
