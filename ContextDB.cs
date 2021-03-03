using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADO_Basics
{
    //Набор функций по работе с БД
    public class ContextDB
    { 
        public SqlConnection Connection { get; set; }
        public void AddUser(User u)
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"INSERT INTO Users(Name) VALUES(N'{u.Name}')";
            cmd.ExecuteNonQuery();
        }

        public void AddProduct(Product p)
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"INSERT INTO Products(Name, price) VALUES(N'{p.Name}', N'{p.Price}')";
            cmd.ExecuteNonQuery();
        }

        public List<User> GetUsers()
        {
            List<User> res;
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM Users";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                res = new List<User>();
                while (reader.Read())
                {
                    res.Add(
                        new User()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        }
                    );
                }
            }

            return res;
        }

        public void DeleteUser(User u)
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"DELETE FROM Users WHERE id = {u.Id}";
            cmd.ExecuteNonQuery();
        }

        public void UpdateUser(User u)
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"UPDATE Users SET Name=N'{u.Name}' WHERE id = {u.Id}";
            cmd.ExecuteNonQuery();
        }

        public List<Product> GetProducts()
        {
            List<Product> res;
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"SELECT * FROM Products";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                res = new List<Product>();
                while (reader.Read())
                {
                    res.Add(
                        new Product()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Price = reader.GetDecimal(2)
                        }
                    );
                }
            }

            return res;
        }

        public void UpdateProduct(Product p)
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"UPDATE Products SET Name=N'{p.Name}', price={p.Price} WHERE Id = {p.Id}";
            cmd.ExecuteNonQuery();
        }

        public void DeleteProduct(Product p)
        {
            var cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = $"DELETE FROM Products WHERE id = {p.Id}";
            cmd.ExecuteNonQuery();
        }
    }
}
