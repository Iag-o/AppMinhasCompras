using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AppMinhasCompras.Model;
using SQLite;

namespace AppMinhasCompras.Helper
{
    public class SQLiteDatabaseHelper
    {

        readonly SQLiteAsyncConnection _connection;

        public SQLiteDatabaseHelper(string path)
        {
            _connection = new SQLiteAsyncConnection(path);
            _connection.CreateTableAsync<Produto>().Wait();
        }

        public Task<int> Insert(Produto p)
        {
            return _connection.InsertAsync(p);
        }

        public void Update(Produto p)
        {
            string sql = "UPDATE Produto SET Descricao=?, Quantidade=?, Preco=?, WHERE Id=? ";
        }

        public Task<Produto> GetById(int Id)
        {
            return new Produto();
        }

        public Task<List<Produto>> GetAll()
        {

        }

        public void Delete(int Id)
        {

        }
    }


}
