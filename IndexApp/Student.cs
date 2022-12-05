using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexApp
{
    class Student
    {
        string name;
        float height;
        float weight;
        public void setData(string name, float height, float weight)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
        }
        public string getName()
        {
            return this.name;
        }
        public float getHeigh()
        {
            return this.height;
        }
        public float getWeight()
        {
            return this.weight;
        }
        public float getBMI()
        {
            return weight / ((height / 100) * 2);
        }
    }
}
