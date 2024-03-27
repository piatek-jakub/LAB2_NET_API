using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace LAB2_NET_Simple
{
    internal class Menu
    {
        public Client client;
        public List<Exercise> exerciseList = new List<Exercise>();
        public ExercisesDB exercisesDB;
        public Menu()
        {
            client = new Client();
            exercisesDB = new ExercisesDB();
        }
        public void UI()
        {
            while (true)
            {
                Console.WriteLine("1. Get new exercise");
                Console.WriteLine("2. Get all exercises so far");
                Console.WriteLine("3. Exit");
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("What type? [\"education\", \"recreational\", \"social\", \"diy\", \"charity\", \"cooking\", \"relaxation\", \"music\", \"busywork\"]");
                        Console.WriteLine("Leave Empty if nothing");
                        var typeInput = Console.ReadLine();
                        if(typeInput != "")
                        {
                            client.someExercise.type = typeInput;
                            var tupleElement = ("type", true);
                            client.parametersList[0] = tupleElement;
                        }
                        else
                        {
                            var tupleElement = ("type", false);
                            client.parametersList[0] = tupleElement;
                        }
                        Console.WriteLine("Enter number of participants, leave empty if not using");
                        typeInput = Console.ReadLine();
                        if (typeInput != "")
                        {
                            int.TryParse(typeInput, out int numberOfParticipants);
                            client.someExercise.participants = numberOfParticipants;
                            var tupleElement = ("participants", true);
                            client.parametersList[1] = tupleElement;

                        }
                        else
                        {
                            var tupleElement = ("participants", false);
                            client.parametersList[1] = tupleElement;
                        }

                        Console.WriteLine("Enter price, leave empty if not using");
                        typeInput = Console.ReadLine();
                        if (typeInput != "")
                        {
                            float.TryParse(typeInput, out float price);
                            client.someExercise.price = price;
                            var tupleElement = ("price", true);
                            client.parametersList[2] = tupleElement;

                        }
                        else
                        {
                            var tupleElement = ("price", false);
                            client.parametersList[2] = tupleElement;
                        }

                        Console.WriteLine("Enter number of participants, leave empty if not using");
                        typeInput = Console.ReadLine();
                        if (typeInput != "")
                        {
                            float.TryParse(typeInput, out float accessibility);
                            client.someExercise.accessibility = accessibility;
                            var tupleElement = ("accessibility", true);
                            client.parametersList[3] = tupleElement;

                        }
                        else
                        {
                            var tupleElement = ("accessibility", false);
                            client.parametersList[3] = tupleElement;
                        }
                        client.GetStringCall();
                        client.GetData().Wait();
                        if (client.exerciseDeserialized == null)
                        {
                            Console.WriteLine("FAIL DESERIALIZATION, NOT GOING INTO DB!");
                            return;
                        }
                        var found = exerciseList.FirstOrDefault(e => e.key == client.exerciseDeserialized.key);
                        if (found != null)
                        {
                            Console.WriteLine($"Duplicate found in List, key {found.key}");
                        }
                        else
                        {
                            Console.WriteLine($"Added {client.exerciseDeserialized.key} to List");
                            exerciseList.Add(client.exerciseDeserialized);
                        }

                        found = exercisesDB.exercises.FirstOrDefault(e => e.key == client.exerciseDeserialized.key);
                        if(found != null)
                        {
                            Console.WriteLine($"Duplicate found in DB, key {found.key}");
                        }
                        else
                        {
                            Console.WriteLine($"Added {client.exerciseDeserialized.key} to DB");
                            exercisesDB.exercises.Add(client.exerciseDeserialized);
                        }
                        exercisesDB.SaveChanges();
                        break;
                    case "2":
                        Console.WriteLine("From DB or List?");
                        typeInput = Console.ReadLine();
                        if (typeInput == "DB")
                        {
                            foreach (var exercise in exercisesDB.exercises)
                            {
                                Console.WriteLine(exercise);
                            }
                        }
                        else if(typeInput == "List")
                        {
                            foreach (var exercise in exerciseList)
                            {
                                Console.WriteLine(exercise);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong input!");
                        }
                        break;
                    case "3":
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
