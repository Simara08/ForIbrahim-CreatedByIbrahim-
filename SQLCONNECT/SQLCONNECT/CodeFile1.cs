//static void Insert(string name, string surname)
//{
//    SqlConnection connection = new SqlConnection(connectionStr);
//    string query = $"INSERT INTO Students VALUES('{name}', '{surname}')";
//    SqlCommand command = new SqlCommand(query, connection);

//    connection.Open();
//    command.ExecuteNonQuery();
//    connection.Close();
//}
//static void Delete(int id)
//{
//    SqlConnection connection = new SqlConnection(connectionStr);
//    string query = $"DELETE FROM Students WHERE ID={id}";
//    SqlCommand command = new SqlCommand(query, connection);

//    connection.Open();
//    command.ExecuteNonQuery();
//    connection.Close();
//}
//static void Update(int id, string name)
//{
//    SqlConnection connection = new SqlConnection(connectionStr);
//    string query = $"Update Students set Name='{name}' WHERE ID={id}";
//    SqlCommand command = new SqlCommand(query, connection);

//    connection.Open();
//    command.ExecuteNonQuery();
//connection.Close();


//static void Insert(string name, string surname)
//{
//    SqlConnection connection = new SqlConnection(connectionStr);
//    string query = $"INSERT INTO Students VALUES('{name}', '{surname}')";
//    SqlCommand command = new SqlCommand(query, connection);

//    connection.Open();
//    command.ExecuteNonQuery();
//    connection.Close();
//}
//static void Delete(int id)
//{
//    SqlConnection connection = new SqlConnection(connectionStr);
//    string query = $"DELETE FROM Students WHERE ID={id}";
//    SqlCommand command = new SqlCommand(query, connection);

//    connection.Open();
//    command.ExecuteNonQuery();
//    connection.Close();
//}
//static void Update(int id, string name)
//{
//    SqlConnection connection = new SqlConnection(connectionStr);
//    string query = $"Update Students set Name='{name}' WHERE ID={id}";
//    SqlCommand command = new SqlCommand(query, connection);

//    connection.Open();
//    command.ExecuteNonQuery();
//    connection.Close();



//--------------------------------------------------------------------------------------------------
//static void SelectAll()
//{
//    SqlConnection connection = new SqlConnection(connectionStr);
//    string query = $"SELECT * FROM STUDENTS";
//    SqlCommand command = new SqlCommand(query, connection); 

//    connection.Open();
//    using (command)
//    {
//        SqlDataReader result = command.ExecuteReader();
//        while (result.Read())
//        {
//            Console.WriteLine(result["Name"]);
//        }
//    }
//    connection.Close();