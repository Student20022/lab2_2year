using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternss
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            MessageBox.Show("Adapter.");
        }
    }

    public class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }

    public abstract class Target
    {
        public abstract void Request();
    }
}
