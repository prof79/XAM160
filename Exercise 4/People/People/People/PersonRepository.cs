// PersonRepository.cs

namespace People
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using People.Models;
    using SQLite;

    public class PersonRepository
    {
        #region Fields

        private readonly SQLiteConnection _conn;

        #endregion

        #region Properties

        public string StatusMessage { get; set; }

        #endregion

        #region Constructor

        public PersonRepository(string dbPath)
        {
            // Initialize a new SQLiteConnection
            _conn = new SQLiteConnection(dbPath);

            // Create the Person table
            _conn.CreateTable<Person>();
        }

        #endregion

        #region Methods

        public void AddNewPerson(string name)
        {
            int result = 0;

            try
            {
                // Basic validation to ensure a name was entered
                if (String.IsNullOrEmpty(name))
                {
                    throw new Exception("Valid name required");
                }

                // Insert a new person into the Person table

                var person = new Person
                {
                    Name = name
                };

                result = _conn.Insert(person);

                StatusMessage = $"{result} record(s) added [Name: {name})";
            }
            catch (Exception ex)
            {
                StatusMessage = $"Failed to add {name}. Error: {ex.Message}";
            }
        }

        public IList<Person> GetAllPeople()
        {
            // Return a list of people saved to the Person table in the database
            try
            {
                return _conn.Table<Person>().ToList();
            }
            catch (SQLiteException sqlEx)
            {
                StatusMessage = $"Error retrieving people: {sqlEx.Message}";

                return new List<Person>();
            }
        }

        #endregion
    }
}
