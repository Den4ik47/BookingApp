using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Web.Personalization;
using MySql.Data.MySqlClient;
using MySql.Data.EntityFramework;
using MySql.Data.Types;
using MySql.Web.Common;
using MySql.Data.Common;
using System.Data.Entity;

namespace BookingApp.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class BookContext:DbContext
    {
        //string Myconnect = @"Server=217.173.195.9;Database=119844;Uid=119844;Password=119844;SslMode=none";
       
            public BookContext() : base("conn")
            { }

            public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Authorizates> Authorizates { get; set; }
    }
        //public List<Purchase> Read_Purchase()
        //{

        //List<Purchase> Purchases = new List<Purchase>();
        //MySqlConnection connection = new MySqlConnection(Myconnect);
        //        MySqlCommand myCommand = connection.CreateCommand();
        //        connection.Open();
        //        string mySelectQuery = "SELECT * FROM Purchase ";
        //        myCommand = new MySqlCommand(mySelectQuery, connection);
        //        MySqlDataReader myReader;
        //        myReader = myCommand.ExecuteReader();
        //        while (myReader.Read())
        //        {
        //            Purchase purchase = new Purchase();
        //            purchase.Per_id = myReader.GetInt32(0);
        //            purchase.Person = myReader.GetString(1);
        //            purchase.Adress = myReader.GetString(2);
        //            purchase.Book_id = myReader.GetInt32(3);
        //       // purchase.dateTime = myReader.GetDateTime(4);
        //            Purchases.Add(purchase);

        //    }                    // always call Close when done reading.
        //    myReader.Close();
        //    // Close the connection when done with it.
        //    connection.Close();
        //    return Purchases;
        //}
        //public List<Book> Read_Books() {
        //    List<Book> Books = new List<Book>();
        //MySqlConnection connection = new MySqlConnection(Myconnect);
        //    MySqlCommand myCommand = connection.CreateCommand();
        //    connection.Open();
        //   string mySelectQuery = "SELECT * FROM Book ";
        //    myCommand = new MySqlCommand(mySelectQuery, connection);
        //    MySqlDataReader myReader = myCommand.ExecuteReader();
        //    while (myReader.Read())
        //    {
        //        Book book = new Book();
        //        book.id = myReader.GetInt32(0);
        //        book.Name = myReader.GetString(1);
        //        book.Author = myReader.GetString(2);
        //        book.Price = myReader.GetInt32(3);
        //        Books.Add(book);

        //    }
        //                    // always call Close when done reading.
        //        myReader.Close();
        //        // Close the connection when done with it.
        //        connection.Close();
        //    return Books;
        //}

        //public void SaveChanges_Purchase(Purchase purchase) {
        //    try
        //    {
        //        //This is my connection string i have assigned the database file address path  
        //        //This is my insert query in which i am taking input from the user through windows forms  
        //        string Query = "insert into Purchase(Person,Adress,Book_id,dateTime) values('" + purchase.Person + "','" + purchase.Adress + "','" + purchase.Book_id + "','" + purchase.dateTime + "');";
        //        //This is  MySqlConnection here i have created the object and pass my connection string.  
        //        MySqlConnection MyConn2 = new MySqlConnection(Myconnect);
        //        //This is command class which will handle the query and connection object.  
        //        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        //        MySqlDataReader MyReader2;
        //        MyConn2.Open();
        //        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
        //        while (MyReader2.Read())
        //        {
        //        }
        //        MyConn2.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
        //public void SaveChanges_Book(Book book)
        //{
        //    try
        //    {
        //        //This is my connection string i have assigned the database file address path  
        //        //This is my insert query in which i am taking input from the user through windows forms  
        //        string Query = "insert into Book(Name,Author,Price) values('" +book.Name  + "','" +book.Author + "','" + book.Price + "');";
        //        //This is  MySqlConnection here i have created the object and pass my connection string.  
        //        MySqlConnection MyConn2 = new MySqlConnection(Myconnect);
        //        //This is command class which will handle the query and connection object.  
        //        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
        //        MySqlDataReader MyReader2;
        //        MyConn2.Open();
        //        MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
        //        while (MyReader2.Read())
        //        {
        //        }
        //        MyConn2.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

    }
