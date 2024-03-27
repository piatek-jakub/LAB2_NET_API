using LAB2_NET_Simple;
using System.Reflection.Metadata;
using System.Linq;

namespace ExercisesForms
{
    public partial class Form1 : Form
    {
        ExercisesDB exercisesDB { get; set; }
        Client client { get; set; }
        public Form1()
        {
            exercisesDB = new ExercisesDB();
            InitializeComponent();
            client = new Client();
            LoadData();
        }

        private void LoadData()
        {
            dataGridViewExercises.DataSource = exercisesDB.exercises.ToList();
            dataGridViewExercises.AutoResizeColumns();
        }
        private void updateParametersList()
        {
            List<(string, bool)> tupleElementList = new List<(string, bool)>();
            foreach (var parameter in client.parametersList)
            {
                CheckBox checkBox = this.Controls.Find(parameter.Item1, true).FirstOrDefault() as CheckBox;
                (string, bool) tupleElement;
                if (checkBox.Checked)
                {
                    tupleElement = (parameter.Item1, true);
                }
                else
                {
                    tupleElement = (parameter.Item1, false);
                }
                //responseJson.Text += parameter.Item1; 
                tupleElementList.Add(tupleElement);
            }
            client.parametersList = tupleElementList;
        }

        private void updateExerciseData()
        {
            client.someExercise.type = typeBox.Text;
            int.TryParse(participantsBox.Text, out int participantsNumber);
            client.someExercise.participants = participantsNumber;
            float.TryParse(priceBox.Text, out float priceNumber);
            client.someExercise.price = priceNumber;
            float.TryParse(accessibilityBox.Text, out float accessibilityNumber);
            client.someExercise.accessibility = accessibilityNumber;
        }

        private async void requestButton_Click(object sender, EventArgs e)
        {
            updateParametersList();
            updateExerciseData();
            /*response.Text = "";
            foreach (var parameter in client.parametersList)
            {
                response.Text += parameter.Item1 + parameter.Item2;
            }*/
            client.GetStringCall();
            await client.GetData();
            if (client.exerciseDeserialized == null)
            {
                MessageBox.Show("Deserialization failed! No such activity found", "No activities", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //response.Text = client.call;
            response.Text = client.exerciseDeserialized.ToString();

            var found = exercisesDB.exercises.FirstOrDefault(e => e.key == client.exerciseDeserialized.key);
            if (found != null)
            {
                status.Text = $"Duplicate found in DB, key {found.key}";
            }
            else
            {
                status.Text = $"Added {client.exerciseDeserialized.key} to DB";
                exercisesDB.exercises.Add(client.exerciseDeserialized);
            }
            exercisesDB.SaveChanges();
            LoadData();

            /*}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            string fieldName = checkBox.Name + "Box";
            NumericUpDown numericUpDown = this.Controls.Find(fieldName, true).FirstOrDefault() as NumericUpDown;
            if (numericUpDown != null)
            {
                if (checkBox.Checked)
                {
                    numericUpDown.Enabled = true;
                }
                else
                {
                    numericUpDown.Enabled = false;
                }
            }
            else
            {
                ComboBox comboBox = this.Controls.Find(fieldName, true).FirstOrDefault() as ComboBox;
                if (checkBox.Checked)
                {
                    comboBox.Enabled = true;
                }
                else
                {
                    comboBox.Enabled = false;
                }
            }
        }

        private void clearSelected_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow element in dataGridViewExercises.SelectedRows)
            {
                if (element.DataBoundItem is Exercise exercise)
                {
                    exercisesDB.exercises.Remove(exercise);

                }
            }
            exercisesDB.SaveChanges();
            LoadData();
            dataGridViewExercises.AutoResizeColumns();
        }

        /*private void sortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string chosen = comboBox.Text;
            if(chosen != "")
            {
                var property = typeof(Exercise).GetProperty(chosen);
                dataGridViewExercises.DataSource = exercisesDB.exercises.OrderBy(s => property.GetValue(s)).Reverse().ToList();
                status.Text += "Successed";
            }
            else
            {
                status.Text += "Failed";
            }
        }*/
        private void sortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string chosen = comboBox.Text;
            switch (chosen)
            {
                case "Id":
                    dataGridViewExercises.DataSource = exercisesDB.exercises.OrderBy(s => s.Id).Reverse().ToList();
                    break;
                case "price":
                    dataGridViewExercises.DataSource = exercisesDB.exercises.OrderBy(s => s.price).Reverse().ToList();
                    break;
                case "accessibility":
                    dataGridViewExercises.DataSource = exercisesDB.exercises.OrderBy(s => s.accessibility).Reverse().ToList();
                    break;
                case "key":
                    dataGridViewExercises.DataSource = exercisesDB.exercises.OrderBy(s => s.key).Reverse().ToList();
                    break;
                case "participants":
                    dataGridViewExercises.DataSource = exercisesDB.exercises.OrderBy(s => s.participants).Reverse().ToList();
                    break;
            }
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            string chosen = comboBox.Text;
            dataGridViewExercises.DataSource = exercisesDB.exercises.Where(e => e.type == chosen).ToList();
        }
    }
}
