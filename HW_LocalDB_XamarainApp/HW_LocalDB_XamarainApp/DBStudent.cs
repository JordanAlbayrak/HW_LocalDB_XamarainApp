using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace HW_LocalDB_XamarainApp
{
    public class DBStudent
    {
        readonly SQLiteAsyncConnection _database;
        public DBStudent(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Student>().Wait();
        }
        public Task<List<Student>> GetPeopleAsync()
        {
            return
            _database.Table<Student>().ToListAsync();
        }
        public Task<int> SavePersonAsync(Student
        student)
        {
            return _database.InsertAsync(student);
        }
    }
}
