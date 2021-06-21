using Pattern.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Data
{
    public class CarContext:DbContext
    {

        public CarContext():base("CarDB")
        {

        }
        public DbSet<Car> Cars { get; set; }
    }
}
