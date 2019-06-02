using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Environment.Data
{
    class TRACIResult
    {
       public void MakePet(ILivingThing organism)
        {
            var pet = (Pet)organism;
        }
    }
    interface ILivingThing
    {
        string Name { get; set; }
    }
    class Person : ILivingThing
    {
        public string Name { get; set; }
    }
    class Pet : ILivingThing
    {
        public string Name { get; set; }
    }
}
