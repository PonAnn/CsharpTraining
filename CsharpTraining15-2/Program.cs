using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining15_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //AttributeUsage 參數(目標/是否可以放置多個/是否被繼承)
    [AttributeUsage(AttributeTargets.Class, AllowMultiple=false, Inherited=false)]
    public class HelpAttribute : Attribute
    {
        protected string description; 
        public HelpAttribute(string description_in)
        {
            this.description = description_in;
        }
        public string Description
        {
            get
            {
                return this.description;
            }
        }

        public string Name
        {
            get;
            set;
        }
    }

    // value type, System, Type, object, enum 都可以
    [Help("this is a do-nothing class", Name="Jikexueyuan")]
    public class AnyClass
    { }
}
