using BusinessObject;
using System;
using System.Collections.Generic;

using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    //Mai Quang Khai
    public class MemberDBContext : BaseDAL
    {
        private static MemberDBContext instance = null;
        private static readonly object instanceLock = new object();
        private MemberDBContext() { }
        public static MemberDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDBContext();
                    }
                    return instance;
                }
            }
        }

        //Mai Quang Khai
        public void AddMember(MemberObject member)
        {

            try
            {
                string SQLInsert = "INSERT into "
                                   + "Members values ("
                                   + "@MemberName, "
                                   + "@Email, "
                                   + "@Password, "
                                   + "@City, "
                                   + "@Country)";
                var parameters = new List<SqlParameter>();
                //parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@MemberName", 100, member.MemberName, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Password", 100, member.Password, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@City", 100, member.City, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Country", 100, member.Country, DbType.String));

                dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }
        ////Mai Quang Khai
        public void UpdateMember(MemberObject member)
        {
            try
            {
                MemberObject flag = GetMemberByID(member.MemberID);
                if (flag != null)
                {
                    if (member.Password == null)
                    {
                        string SqlUpdate = "UPDATE Members set "
                                       //+ "MemberID = @MemberID, "
                                       + "MemberName = @MemberName, "
                                       + "Email = @Email, "
                                       + "City = @City, "
                                       + "Country = @Country "
                                       + "WHERE "
                                       + "MemberID = @MemberID";
                        var parameters = new List<SqlParameter>();
                        parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                        parameters.Add(dataProvider.CreateParameter("@MemberName", 100, member.MemberName, DbType.String));
                        parameters.Add(dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                        parameters.Add(dataProvider.CreateParameter("@City", 100, member.City, DbType.String));
                        parameters.Add(dataProvider.CreateParameter("@Country", 100, member.Country, DbType.String));

                        dataProvider.Insert(SqlUpdate, CommandType.Text, parameters.ToArray());
                    }
                    else
                    {
                        string SqlUpdate = "UPDATE Members set "
                                       //+ "MemberID = @MemberID, "
                                       + "MemberName = @MemberName, "
                                       + "Email = @Email, "
                                       + "Password = @Password, "
                                       + "City = @City, "
                                       + "Country = @Country "
                                       + "WHERE "
                                       + "MemberID = @MemberID";
                        var parameters = new List<SqlParameter>();
                        parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                        parameters.Add(dataProvider.CreateParameter("@MemberName", 100, member.MemberName, DbType.String));
                        parameters.Add(dataProvider.CreateParameter("@Password", 100, member.Password, DbType.String));
                        parameters.Add(dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                        parameters.Add(dataProvider.CreateParameter("@City", 100, member.City, DbType.String));
                        parameters.Add(dataProvider.CreateParameter("@Country", 100, member.Country, DbType.String));

                        dataProvider.Insert(SqlUpdate, CommandType.Text, parameters.ToArray());
                    }

                }
                else
                {
                    throw new Exception("Update Failed: The Member is not exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        //Mai Quang Khai
        public void RemoveMember(int memberID)
        {
            try
            {
                MemberObject member = GetMemberByID(memberID);
                if (member != null)
                {
                    string SQLDelete = "DELETE FROM Members "
                                     + "WHERE "
                                     + "MemberID = @MemberID";
                    var param = dataProvider.CreateParameter("@MemberID", 4, memberID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);

                }
                else
                {
                    throw new Exception("Delete Failed: The Member is not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        //Truong Thanh Trung 
        public MemberObject GetMemberByID(int id)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string SQLSelect = "SELECT "
                                + "MemberID, MemberName, Email, Password, City, Country "
                                + "FROM "
                                + "Members "
                                + "WHERE "
                                + "MemberID = @MemberID";
            try
            {
                var param = dataProvider.CreateParameter("@MemberID", 4, id, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //dataReader.Close();
                CloseConnection();
            }

            return member;
        }
        //Truong Thanh Trung
        public IEnumerable<MemberObject> GetMemberLists()
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT "
                                + "MemberID, MemberName, Email, Password, City, Country "
                                + "FROM "
                                + "Members";
            var members = new List<MemberObject>();

            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    members.Add(new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //dataReader.Close();
                CloseConnection();
            }

            return members;
        }
        //Truong Thanh Trung
        public MemberObject GetMemberByEmail(string email)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string SQLSelect = "SELECT "
                                + "MemberID, MemberName, Email, Password, City, Country "
                                + "FROM "
                                + "Members "
                                + "WHERE "
                                + "Email = @Email";
            try
            {
                var param = dataProvider.CreateParameter("@Email", 100, email, DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //dataReader.Close();
                CloseConnection();
            }

            return member;
        }


        public List<MemberObject> GetMemberByName(string name)
        {
            MemberObject member = null;
            List<MemberObject> result = new List<MemberObject>();
            IDataReader dataReader = null;
            string SQLSelect = "SELECT "
                                + "MemberID, MemberName, Email, Password, City, Country "
                                + "FROM "
                                + "Members "
                                + "WHERE "
                                + "MemberName LIKE @MemberName";
            try
            {
                var param = dataProvider.CreateParameter("@MemberName", 100, "%" + name + "%", DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    };

                    result.Add(member);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //dataReader.Close();
                CloseConnection();
            }

            return result;
        }

        //Nguyen Tan Trung
        public List<MemberObject> GetMemberByCity(string city)
        {
            MemberObject member = null;
            List<MemberObject> result = new List<MemberObject>();
            IDataReader dataReader = null;
            string SQLSelect = "SELECT "
                                + "MemberID, MemberName, Email, Password, City, Country "
                                + "FROM "
                                + "Members "
                                + "WHERE "
                                + "City LIKE @City";
            try
            {
                var param = dataProvider.CreateParameter("@City", 100, "%" + city + "%", DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    };

                    result.Add(member);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //dataReader.Close();
                CloseConnection();
            }

            return result;
        }
        //Nguyen Tan Trung
        public List<MemberObject> GetMemberByCountry(string country)
        {
            MemberObject member = null;
            List<MemberObject> result = new List<MemberObject>();
            IDataReader dataReader = null;
            string SQLSelect = "SELECT "
                                + "MemberID, MemberName, Email, Password, City, Country "
                                + "FROM "
                                + "Members "
                                + "WHERE "
                                + "Country LIKE @Country";
            try
            {
                var param = dataProvider.CreateParameter("@Country", 100, "%" + country + "%", DbType.String);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5)
                    };

                    result.Add(member);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //dataReader.Close();
                CloseConnection();
            }

            return result;
        }


    }
}

