using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ExercisesForms")]
namespace LAB2_NET_Simple
{
    internal class Exercise
    {
        public int Id { get; set; }
        public string activity { get; set; }
        public float accessibility { get; set; }
        public string type { get; set; }
        public int participants { get; set; }
        public float price { get; set; }
        public string link { get; set; }
        public string key { get; set; }

        public Exercise()
        {
            activity = String.Empty;
            key = String.Empty;
            link = String.Empty;
            type = String.Empty;
        }

        public override string ToString()
        {
            string s = string.Empty;
            s += $"activity: {activity}" + Environment.NewLine;
            s += $"accessibility: {accessibility}" + Environment.NewLine;
            s += $"type: {type}" + Environment.NewLine;
            s += $"participants: {participants}" + Environment.NewLine;
            s += $"price: {price}" + Environment.NewLine;
            s += $"link: {link}" + Environment.NewLine;
            s += $"key: {key}" + Environment.NewLine;

            return s;
        }
    }
}
