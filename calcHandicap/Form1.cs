using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace calcHandicap
{
    public partial class frmCalcHandicap : Form
    {
        Dictionary<string, double> courseRating = new Dictionary<string, double>();
        Dictionary<string, int> slopeRating = new Dictionary<string, int>();
        private void frmCalcHandicap_Load(object sender, EventArgs e)
        {
            comboCourse.Items.Insert(0, "Riviera Country Club");
            courseRating.Add("Riviera Country Club", 72.2);
            slopeRating.Add("Riviera Country Club", 130);
        }

        public frmCalcHandicap()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string filename = "difScores.csv";
            double[] DifScores = new double[20];
            double[] newDifScores = new double[19];
            double bestDifScoresAdded = new double();
            double newDifScore = new double();
            double newHandicap = new double();

            using (TextFieldParser parser = new TextFieldParser(filename))
            {
                parser.Delimiters = new string[] { ";" };

                // Iterate through lines in CSV
                while (true)
                {
                    // Read all fields and create an array from them
                    string[] parts = parser.ReadFields();
                    
                    // Get out of the loop if no more lines
                    if (parts == null)
                    {
                        break;
                    }
                    // If there is data
                    else
                    {
                        // If the first value of the line is the same as the one the user entered into the form
                        if (parts[0] == txtBoxName.Text)
                        {
                            for (int i = 1; i < parts.Length; i++)
                            {
                                // Store all old values for calculating
                                DifScores[i-1] = double.Parse(parts[i]);
                                if (i < parts.Length - 1)
                                {
                                    // Don't store the last value, as it will be exchanged by the newly calculated one
                                    newDifScores[i] = double.Parse(parts[i]);
                                }
                            }
                        }
                    }
                }
                // Calculate the differential
                newDifScore = (double.Parse(txtBoxScore.Text) - courseRating[comboCourse.SelectedItem.ToString()]) * 113 / slopeRating[comboCourse.SelectedItem.ToString()];
                // Truncate so only one digit after the decimal.
                DifScores[19] = Math.Truncate(newDifScore * 10) / 10;
                newDifScores[0] = Math.Truncate(newDifScore * 10) / 10;

                // Sort array as we only need the best 10 scores.
                Array.Sort(DifScores);

                // Iterate through array 10 times for adding the best 10 scores
                for (int i = 0; i < 10; i++)
                {
                    bestDifScoresAdded += DifScores[i];
                }
                // Calculate average and send the result it to the form
                newHandicap = bestDifScoresAdded / 10;
                txtBoxHandicap.Text = newHandicap.ToString("0.0");

                parser.Close();
            }

            // Create line for replacing in the CSV
            string newLine = txtBoxName.Text + ";";
            for (int i = 0; i < newDifScores.Length; i++)
            {
                newLine += newDifScores[i];
                if (i < newDifScores.Length - 1)
                {
                    newLine += ";";
                }

            }

            // Read all lines and replace the one with the competors name
            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i ++)
            {
                if (lines[i].Contains(txtBoxName.Text))
                {
                    lines[i] = newLine;
                }
            }

            // Write CSV
            File.WriteAllLines(filename, lines);
        }
    }
}
