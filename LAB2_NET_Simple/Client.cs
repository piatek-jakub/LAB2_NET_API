using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ExercisesForms")]
namespace LAB2_NET_Simple
{
    internal class Client
    {
        public Exercise someExercise;
        public HttpClient httpClient;
        public Exercise exerciseDeserialized;

        public string call {  get; set; }

        public List<(string, bool)> parametersList { get; set; }
        public Client()
        {
            this.parametersList = new List<(string, bool)>
            {
                ("type",false),
                ("participants",false),
                ("price",false),
                ("accessibility",false)
            };
            someExercise = new Exercise();
            exerciseDeserialized = new Exercise();
            call = String.Empty;
            //httpClient = new HttpClient();
        }


        public void GetStringCall()
        {
            httpClient = new HttpClient();
            this.call = "http://www.boredapi.com/api/activity?";
            foreach(var parameter in parametersList)
            {
                if (parameter.Item2)
                {
                    var parameterValue = someExercise.GetType().GetProperty(parameter.Item1)?.GetValue(this.someExercise);
                    parameterValue = parameterValue.ToString().Replace(",",".");
                    Console.WriteLine($"Parameter {parameter.Item1} value is {parameterValue}");
                    this.call += parameter.Item1 + "=" + parameterValue + "&";
                }
            }
        }


        public async Task GetData()
        {
            Console.WriteLine(this.call);
            string response = await httpClient.GetStringAsync(this.call);
            this.exerciseDeserialized = JsonSerializer.Deserialize<Exercise>(response);
            if(exerciseDeserialized.activity == String.Empty)
            {
                exerciseDeserialized = null;
                Console.WriteLine("DESERIALIZATION FAILED");
            }
            //Console.WriteLine(response);
            //Console.WriteLine(exerciseDeserialized);
        }
    }
}
