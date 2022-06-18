using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practice_1.Entities;
using System.Windows.Forms;

namespace practice_1
{
    public partial class BarChart : Form
    {
        private List<Specialty> specialtyList;
        private List<int> specialtyCount;
        public BarChart()
        {
            InitializeComponent();
        }
        public BarChart(List<Specialty> sL, List<int> iL) : this()
        {
            specialtyList = sL;
            specialtyCount = iL;
        }

        private void BarChart_Load(object sender, EventArgs e)
        {
            List<string> stringList = new List<string>();
            for(var i = 0; i < specialtyList.Count; i++)
            {
                stringList.Add(specialtyList[i].Name);
            }
            // updating data in the chart
            barChartDisplay.ChangeData(stringList, specialtyCount);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
