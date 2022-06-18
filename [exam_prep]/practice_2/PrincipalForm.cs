using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using practice_2.Entities;

namespace practice_2
{
    public partial class PrincipalForm : Form
    {
        #region Attributes
        public const string ConnectionString = "Data Source=..\\..\\Database\\Practice2.db";
        public List<Car> listCars;
        public List<Entities.Component> listComponents;
        #endregion
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            // initialize lists
            listCars = new List<Car>();
            listComponents = new List<Entities.Component>();

            // set list views
            lviewCars.FullRowSelect = true;
            lviewComponents.FullRowSelect = true;
            lviewCars.View = View.Details;
            lviewComponents.View = View.Details;

            lviewCars.Columns.Add("Code");
            lviewCars.Columns.Add("Name");
            lviewCars.Columns.Add("Engine Cap.");
            //lviewCars.Columns.Add("Code");

            lviewComponents.Columns.Add("Code");
            lviewComponents.Columns.Add("Car Code");
            lviewComponents.Columns.Add("Supplier");
            lviewComponents.Columns.Add("Weight");

            // load from db
            loadFromDatabase();

            // display both lists
            displayCars();
            //displayComponents();
        }
        private void loadFromDatabase()
        {
            var query = "select * from Components";

            using (SQLiteConnection dbConnect = new SQLiteConnection(ConnectionString))
            {
                dbConnect.Open();

                var command = new SQLiteCommand(query, dbConnect);

                // using reader
                using(SQLiteDataReader currentRow = command.ExecuteReader())
                {
                    while(currentRow.Read())
                    {
                        int code = int.Parse(currentRow["code"].ToString());
                        int carCode = int.Parse(currentRow["carCode"].ToString());
                        string supplier = currentRow["supplier"].ToString();
                        float weight = float.Parse(currentRow["weight"].ToString());

                        listComponents.Add(new Entities.Component(code, carCode, supplier, weight));
                    }
                }

                // reading the cars
                query = "select * from Cars";

                command = new SQLiteCommand(query, dbConnect);

                using(SQLiteDataReader currentRow = command.ExecuteReader())
                {
                    while(currentRow.Read())
                    {
                        int code = int.Parse(currentRow["code"].ToString());
                        string name = currentRow["name"].ToString();
                        float engingeCap = float.Parse(currentRow["engineCapacity"].ToString());

                        // computing the list of components
                        List<Entities.Component> listC = new List<Entities.Component>();

                        foreach(Entities.Component component in listComponents)
                        {
                            if (component.carCode == code)
                                listC.Add(component);
                        }

                        listCars.Add(new Car(code, name, engingeCap, listC));
                    }
                }
                dbConnect.Close();
            }
        }
        private void displayCars()
        {
            lviewCars.Items.Clear();

            foreach(Car currentCar in listCars)
            {
                ListViewItem toAdd = new ListViewItem(currentCar.code.ToString());
                toAdd.SubItems.Add(currentCar.name);
                toAdd.SubItems.Add(currentCar.engineCapacity.ToString());

                toAdd.Tag = currentCar;

                lviewCars.Items.Add(toAdd);
            }
            lviewCars.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lviewCars.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void displayComponents(Car toDisplay)
        {
            lviewComponents.Items.Clear();

            //foreach (Entities.Component currentComponent in listComponents)
            //{
            //    if (toDisplay.GetComponents().FindIndex(x => x == currentComponent) != -1)
            //    {
            //        ListViewItem toAdd = new ListViewItem(currentComponent.code.ToString());
            //        toAdd.SubItems.Add(currentComponent.carCode.ToString());
            //        toAdd.SubItems.Add(currentComponent.supplier);
            //        toAdd.SubItems.Add(currentComponent.weight.ToString());

            //        toAdd.Tag = currentComponent;

            //        lviewComponents.Items.Add(toAdd);
            //    }
            //}

            foreach (Entities.Component currentComponent in toDisplay.GetComponents())
            {
                
                ListViewItem toAdd = new ListViewItem(currentComponent.code.ToString());
                toAdd.SubItems.Add(currentComponent.carCode.ToString());
                toAdd.SubItems.Add(currentComponent.supplier);
                toAdd.SubItems.Add(currentComponent.weight.ToString());

                toAdd.Tag = currentComponent;

                lviewComponents.Items.Add(toAdd);
                
            }

            lviewComponents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lviewComponents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void displayComponentsSorted(Car toDisplay)
        {
            toDisplay.GetComponents().Sort();
            displayComponents(toDisplay);
        }

        private void lviewCars_Click(object sender, EventArgs e)
        {
            if (lviewCars.SelectedItems.Count == 1)
            {
                displayComponents(lviewCars.SelectedItems[0].Tag as Car);
            }
            else
            {
                lviewComponents.Items.Clear();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (lviewCars.SelectedItems.Count == 1)
            {
                displayComponentsSorted(lviewCars.SelectedItems[0].Tag as Car);
            }
            else
            {
                lviewComponents.Items.Clear();
            }
        }

        private void PrincipalForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // compute list of strings and list of ints
                List<string> labelList = new List<string>();
                List<int> valueList = new List<int>();
                foreach(Car currentCar in listCars)
                {
                    if (labelList.FindIndex(x => x == currentCar.engineCapacity.ToString()) == -1)
                    {
                        labelList.Add(currentCar.engineCapacity.ToString());
                        valueList.Add(listCars.Count(x => x.engineCapacity == currentCar.engineCapacity));
                    }
                }
                // display bar chart
                Form barChartForm = new BarChartForm(labelList, valueList);
                barChartForm.ShowDialog();
            }
        }
    }
}
