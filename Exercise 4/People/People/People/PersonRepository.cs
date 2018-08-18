// PersonRepository.cs

namespace People
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using People.Models;
    using SQLite;

    public class PersonRepository
    {
        #region Fields

        private readonly SQLiteAsyncConnection _conn;

        #endregion

        #region Properties

        public string StatusMessage { get; set; }

        #endregion

        #region Constructor

        public PersonRepository(string dbPath)
        {
            // Initialize a new SQLiteConnection
            _conn = new SQLiteAsyncConnection(dbPath);

            InitializeDatabaseAsync();
        }

        #endregion

        #region Methods

        private Task InitializeDatabaseAsync()
        {
            // Create the Person table
            return _conn.CreateTableAsync<Person>();
        }

        public async Task AddNewPersonAsync(string name)
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

                result = await _conn.InsertAsync(person).ConfigureAwait(false);

                StatusMessage = $"{result} record(s) added [Name: {name})";
            }
            catch (Exception ex)
            {
                StatusMessage = $"Failed to add {name}. Error: {ex.Message}";
            }
        }

        public Task<List<Person>> GetAllPeopleAsync()
        {
            // Return a list of people saved to the Person table in the database
            try
            {
                return _conn.Table<Person>().ToListAsync();
            }
            catch (SQLiteException sqlEx)
            {
                StatusMessage = $"Error retrieving people: {sqlEx.Message}";

                return Task.FromResult(new List<Person>());
            }
        }

        #endregion
    }
}
