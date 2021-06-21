using Pattern.Data;
using Pattern.Model;
using Pattern.Wiews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Presenters
{
    public class MainPresenter
    {
        private readonly CarContext _db;
        private IMainWiew _wiew;
        public MainPresenter(IMainWiew wiew)
        {
            _wiew = wiew;
            _wiew.AddBtnClicked += WiewAddButtonClick;
            _wiew.LoadBtnClikced += WiewLoadButtonClick;

            _db = new CarContext();
        }
        private void WiewAddButtonClick(object sender, EventArgs e)
        {
            Car car = new Car
            {
                Model = _wiew.modelText,
                Vendor = _wiew.VendorText,
                Year = int.Parse(_wiew.YearText),
                Color = _wiew.ColorText,
                Transmisson = _wiew.TransmissonText

            };
            _db.Cars.Add(car);
            _db.SaveChanges();
        }
        private void WiewLoadButtonClick(object sender,EventArgs e)
        {
            var list = _db.Cars.ToList();
            _wiew.Cars = list;
        }
    }
}
