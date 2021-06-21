using Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Wiews
{
    public interface IMainWiew
    {
        EventHandler<EventArgs> AddBtnClicked { get; set; }
        EventHandler<EventArgs> LoadBtnClikced { get; set; }
        string modelText { get; set; }
        string VendorText { get; set; }
        string TransmissonText { get; set; }
        string YearText { get; set;}
        string ColorText { get; set; }
        List<Car> Cars {  set; }
        
    }
}
