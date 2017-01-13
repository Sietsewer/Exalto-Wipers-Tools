using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JSONDatabaseBuilder
{
    public partial class Form1 : Form
    {
        public static string defaultFile;

        public DataSet dataSet;

        public Form1(string[] args)
        {
            InitializeComponent();

            foreach(string s in args)
            {
                if (File.Exists(s))
                {
                    defaultFile = s;
                    loadData(false, s);
                    break;
                }
            }

            /*dataSet = new DataSet();
            dataSet.arms = new List<WiperArm>();
            dataSet.blades = new List<WiperBlade>();
            dataSet.motors = new List<WiperMotor>();

            dataSet.arms.Add(new WiperArm());
            dataSet.blades.Add(new WiperBlade());
            dataSet.motors.Add(new WiperMotor());

            dataArms.DataSource = dataSet.arms;
            dataBlades.DataSource = dataSet.blades;
            dataMotors.DataSource = dataSet.motors;

            dataArms.AllowUserToAddRows = true;
            dataBlades.AllowUserToAddRows = true;
            dataMotors.AllowUserToAddRows = true;*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Data_Click(object sender, EventArgs e)
        {
            outputData.Text = serializeData();
        }

        private string serializeData() {
            DataSet ds = new DataSet();

            ds.arms = new List<WiperArm>();

            foreach (DataGridViewRow row in dataArms.Rows)
            {
                object item = row.DataBoundItem;
                if (item != null)
                {
                    ds.arms.Add(item as WiperArm);
                }
            }

            ds.blades = new List<WiperBlade>();

            foreach (DataGridViewRow row in dataBlades.Rows)
            {
                object item = row.DataBoundItem;
                if (item != null)
                {
                    ds.blades.Add(item as WiperBlade);
                }
            }

            ds.motors = new List<WiperMotor>();

            foreach (DataGridViewRow row in dataMotors.Rows)
            {
                object item = row.DataBoundItem;
                if (item != null)
                {
                    ds.motors.Add(item as WiperMotor);
                }
            }
            
            return ds.ToString();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream fileStream;

            saveFileDialog1.Filter = "Javascript Object Notation files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory = true;
            if ((defaultFile != null) || (defaultFile != ""))
            {
                saveFileDialog1.InitialDirectory = defaultFile;

               // string[] parts = defaultFile.Split('/');
                saveFileDialog1.FileName = defaultFile;
            }


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((fileStream = saveFileDialog1.OpenFile()) != null)
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(serializeData());
                    fileStream.Write(bytes, 0, bytes.Count());
                    fileStream.Close();
                }
            }
        }

        private void loadData (bool append = false, string dir = "")
        {
            Stream fileStream;

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Javascript Object Notation files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if(dir != "")
            {
                string s = File.ReadAllText(dir);
                dataSet = new DataSet(s);
                foreach (WiperArm arm in dataSet.arms)
                {
                    wiperArmBindingSource.Add(arm);
                }
                foreach (WiperBlade blade in dataSet.blades)
                {
                    wiperBladeBindingSource.Add(blade);
                }
                foreach (WiperMotor motor in dataSet.motors)
                {
                    wiperMotorBindingSource2.Add(motor);
                }
                return;
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((fileStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (fileStream)
                        {
                            if (!append)
                            {
                                wiperBladeBindingSource.Clear();
                                wiperMotorBindingSource2.Clear();
                                wiperArmBindingSource.Clear();
                            }

                            byte[] bytes = new byte[fileStream.Length];
                            fileStream.Read(bytes, 0, (int)fileStream.Length);
                            string s = Encoding.UTF8.GetString(bytes);
                            dataSet = new DataSet(s);
                            foreach (WiperArm arm in dataSet.arms) {
                                wiperArmBindingSource.Add(arm);
                            }
                            foreach (WiperBlade blade in dataSet.blades)
                            {
                                wiperBladeBindingSource.Add(blade);
                            }
                            foreach (WiperMotor motor in dataSet.motors)
                            {
                                wiperMotorBindingSource2.Add(motor);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void appendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData(true);
        }
    }
}
