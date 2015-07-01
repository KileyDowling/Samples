using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGCorpHR.Models;

namespace SGCorpHR.DATA
{
    public class SuggestionRepository
    {
        public string filePath = "Suggestions\\Suggestions.txt";
        public List<Suggestion> GetAllSuggestions()
        {
            List<Suggestion> suggestions = new List<Suggestion>();

            var reader = File.ReadAllLines(@filePath);

            for (int i = 1; i < reader.Length; i++)
            {
                var columns = reader[i].Split(',');

                var suggestion = new Suggestion();

                suggestion.SuggestionID = int.Parse(columns[0]);
                suggestion.EmployeeName = columns[1];
                suggestion.SuggestionText = columns[2];

                suggestions.Add(suggestion);
            }

            return suggestions;
        }

        public void RemoveFile(int suggestionID)
        {
            var suggestionsList = GetAllSuggestions();
            var suggestion = suggestionsList.First(s => s.SuggestionID == suggestionID);
            suggestionsList.Remove(suggestion);
            OverwriteFile(suggestionsList);

        }
        

        private void OverwriteFile(List<Suggestion> suggestionsList)
        {

            File.Delete(filePath);

            using (var writer = File.CreateText(filePath))
            {
                writer.WriteLine(
                    "SuggestionID,EmployeeName,SuggestionText");

                foreach (var suggestion in suggestionsList)
                {
                    writer.WriteLine("{0},{1},{2}",suggestion.SuggestionID,suggestion.EmployeeName,suggestion.SuggestionText);
                }
            }
        }
    }
}
