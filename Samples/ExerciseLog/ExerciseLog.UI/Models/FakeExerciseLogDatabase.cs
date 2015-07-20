using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExerciseLog.UI.Models
{
    public class FakeExerciseLogDatabase
    {
         List<ExerciseLog> _exerciseLog = new List<ExerciseLog>();

        public List<ExerciseLog> GetAll()
        {
            return _exerciseLog;
        }
    }
}