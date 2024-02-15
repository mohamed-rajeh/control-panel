//using MySql.Data.MySqlClient;
//using System.Data;

//namespace Dashboard.classes
//{


//    class connectione
//    {
//        MySqlDataAdapter da;
//        DataTable dt;
//        MySqlCommand cmd;

//        public MySqlConnection con = new MySqlConnection
//                                       (@"server=localhost;
//                                    database=db_serveric;
//                                      UID=root;password=; ");

//        public DataTable sho()
//        {
//            DataTable dt = new DataTable();
//            MySqlDataAdapter da = new MySqlDataAdapter("select * from login", con);
//            da.Fill(dt);
//            return dt;
//        }
//        public DataTable Query(string str, bool state)
//        {
//            //OpenCon();
//            //dt = new DataTable();
//            //da = new SqlDataAdapter(str, con);
//            //da.Fill(dt);
//            //CloseCon();
//            if (state == true)
//            {
//                dt = new DataTable();
//                da = new MySqlDataAdapter(str, con);
//                da.Fill(dt);
//                return dt;
//            }
//            else
//            {
//                cmd = new MySqlCommand(str, con);

//                con.Open();
//                cmd.ExecuteNonQuery();
//                con.Close();
//                return null;
//            }
//            //return null;
//        }


//    }
//}
