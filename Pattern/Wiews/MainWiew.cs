using Pattern.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pattern.Wiews
{
    public partial class MainWiew : Form,IMainWiew
    {
        public MainWiew()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> AddBtnClicked { get; set ; }
        public EventHandler<EventArgs> LoadBtnClikced { get ; set ; }
        public string modelText { get => Modeltxtbox.Text; set =>Modeltxtbox.Text=value; }
        public string VendorText { get=>VendorTxtBox.Text; set => VendorTxtBox.Text=value; }
        public string TransmissonText { get => TransmissonTxtBox.Text; set => TransmissonTxtBox.Text=value; }
        public string YearText { get => YearTxtBox.Text; set =>YearTxtBox.Text=value; }
        public string ColorText { get => ColorTxtBox.Text; set => ColorTxtBox.Text=value; }
        public List<Car> Cars { set {
                Datalistbox.DataSource = null;
                Datalistbox.DataSource = value;
            } }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddBtnClicked.Invoke(sender, e);
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadBtnClikced.Invoke(sender, e);
        }
    }
}
