using AITBirthday.Models;
using AITBirthday.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AITBirthday.DAO
{
   public class DAOASS
   {
        private IDbConnection mConnection;
        private readonly DbProviderFactory mProvider = DbProviderFactories.GetFactory("System.Data.SqlClient");

        private string Appli = "AITBIRTHDAY";

        //Random entre plusieurs nombre
       // int randomNumber1 = random.Next(0, 300);
       //On a 24 combinaisons avec les 4 images

        #region Poste

        public List<CPoste> getAllPoste(string Chaineconnex)
        {
            var listPays = new List<CPoste>();
            using (mConnection = mProvider.CreateConnection())
            {
                if (mConnection == null) return listPays;
                mConnection.ConnectionString = Chaineconnex;
                mConnection.Open();

                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"SELECT * from BIR_Poste WHERE IsDelete=0 ";

                        // command.CommandTimeout = 300;
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var pays = new CPoste
                                {
                                    mId = reader["Id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Id"]),
                                    mCodePoste = reader["CodePoste"] == DBNull.Value ? string.Empty : reader["CodePoste"] as string,
                                    mIntitulePoste = reader["IntitulePoste"] == DBNull.Value ? string.Empty : reader["IntitulePoste"] as string,
                                    mDescription = reader["Description"] == DBNull.Value ? string.Empty : reader["Description"] as string,

                                    mIsDelete = reader["IsDelete"] == DBNull.Value ? 0 : Convert.ToInt16(reader["IsDelete"]),
                                    mUserCreation = reader["UserCreation"] == DBNull.Value ? string.Empty : reader["UserCreation"] as string,
                                    mUserLastModification = reader["UserLastModification"] == DBNull.Value ? string.Empty : reader["UserLastModification"] as string,

                                    mDateCreation = reader["DateCreation"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateCreation"].ToString()),
                                    mDateLastModification = reader["DateLastModification"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateLastModification"].ToString()),

                                };

                                listPays.Add(pays);
                            }
                            return listPays;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> getAllPoste-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);

                        return listPays;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public bool addPoste(CPoste client, string ChaineConx)
        {
            bool res = false;

            using (mConnection = mProvider.CreateConnection())
            {
                mConnection.ConnectionString = ChaineConx;
                mConnection.Open();
                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"INSERT INTO BIR_Poste
                        (CodePoste,IntitulePoste,Description,IsDelete,UserCreation,UserLastModification,DateCreation,DateLastModification)
                        VALUES (@CodePoste,@IntitulePoste,@Description,@IsDelete,@UserCreation,@UserLastModification,@DateCreation,@DateLastModification)";

                        command.Parameters.Add(new SqlParameter("CodePoste", client.mCodePoste ?? ""));
                        command.Parameters.Add(new SqlParameter("IntitulePoste", client.mIntitulePoste ?? ""));
                        command.Parameters.Add(new SqlParameter("Description", client.mDescription ?? ""));
                        command.Parameters.Add(new SqlParameter("IsDelete", client.mIsDelete));
                        command.Parameters.Add(new SqlParameter("UserCreation", client.mUserCreation ?? ""));
                        command.Parameters.Add(new SqlParameter("UserLastModification", client.mUserLastModification ?? ""));
                        command.Parameters.Add(new SqlParameter("DateCreation", client.mDateCreation));
                        command.Parameters.Add(new SqlParameter("DateLastModification", client.mDateLastModification));

                        command.ExecuteNonQuery();
                        res = true;

                        return res;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> addPoste-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);
                        return res;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public bool updatePoste(CPoste client, string chaineconx)
        {
            bool res = false;

            using (mConnection = mProvider.CreateConnection())
            {
                mConnection.ConnectionString = chaineconx;
                mConnection.Open();
                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"UPDATE BIR_Poste SET 
                        CodePoste=@CodePoste,IntitulePoste=@IntitulePoste,Description=@Description,IsDelete=@IsDelete,UserLastModification=@UserLastModification,DateLastModification=@DateLastModification WHERE Id = @Id";

                        command.Parameters.Add(new SqlParameter("Id", client.mId));
                        command.Parameters.Add(new SqlParameter("CodePoste", client.mCodePoste ?? ""));
                        command.Parameters.Add(new SqlParameter("IntitulePoste", client.mIntitulePoste ?? ""));
                        command.Parameters.Add(new SqlParameter("Description", client.mDescription ?? ""));
                        command.Parameters.Add(new SqlParameter("IsDelete", client.mIsDelete));
                        //  command.Parameters.Add(new SqlParameter("UserCreation", client.mUserCreation ?? ""));
                        command.Parameters.Add(new SqlParameter("UserLastModification", client.mUserLastModification ?? ""));
                        //  command.Parameters.Add(new SqlParameter("DateCreation", client.mDateCreation));
                        command.Parameters.Add(new SqlParameter("DateLastModification", client.mDateLastModification));

                        command.ExecuteNonQuery();
                        res = true;

                        return res;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> updatePoste-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);
                        return res;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public bool deletePoste(int Id, string chaineconx)
        {
            bool res = false;
            using (mConnection = mProvider.CreateConnection())
            {
                if (mConnection == null) return res;
                mConnection.ConnectionString = chaineconx;
                mConnection.Open();
                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"UPDATE BIR_Poste SET IsDelete=1  WHERE Id = @Id";

                        var licenceId = command.CreateParameter();
                        licenceId.ParameterName = "@Id";
                        licenceId.Value = Id;
                        command.Parameters.Add(licenceId);

                        command.ExecuteNonQuery();
                        res = true;

                        return res;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> deletePoste-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);
                        return res;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public CPoste getPosteById(int Id, string Chaineconnex)
        {
            var listPays = new CPoste();
            using (mConnection = mProvider.CreateConnection())
            {
                if (mConnection == null) return listPays;
                mConnection.ConnectionString = Chaineconnex;
                mConnection.Open();

                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"SELECT * from BIR_Poste WHERE IsDelete=0 and Id = @Id ";

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                listPays.mId = reader["Id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Id"]);
                                listPays.mCodePoste = reader["CodePoste"] == DBNull.Value ? string.Empty : reader["CodePoste"] as string;
                                listPays.mIntitulePoste = reader["IntitulePoste"] == DBNull.Value ? string.Empty : reader["IntitulePoste"] as string;
                                listPays.mDescription = reader["Description"] == DBNull.Value ? string.Empty : reader["Description"] as string;

                                listPays.mIsDelete = reader["IsDelete"] == DBNull.Value ? 0 : Convert.ToInt16(reader["IsDelete"]);
                                listPays.mUserCreation = reader["UserCreation"] == DBNull.Value ? string.Empty : reader["UserCreation"] as string;
                                listPays.mUserLastModification = reader["UserLastModification"] == DBNull.Value ? string.Empty : reader["UserLastModification"] as string;

                                listPays.mDateCreation = reader["DateCreation"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateCreation"].ToString());
                                listPays.mDateLastModification = reader["DateLastModification"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateLastModification"].ToString());

                            }
                            return listPays;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        var msg = "DAOASS -> getPosteById-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);

                        return listPays;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        #endregion
        
        #region Pays 

        public List<CPays> getAllPays(string Chaineconnex)
        {
            var listPays = new List<CPays>();
            using (mConnection = mProvider.CreateConnection())
            {
                if (mConnection == null) return listPays;
                mConnection.ConnectionString = Chaineconnex;
                mConnection.Open();

                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"SELECT * from TAL_ASS_Pays  ";

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var pays = new CPays
                                {
                                    mId = reader["Id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Id"]),
                                    mCodePays = reader["Sigle"] == DBNull.Value ? string.Empty : reader["Sigle"] as string,
                                    mLibellePays = reader["Libelle"] == DBNull.Value ? string.Empty : reader["Libelle"] as string,

                                };

                                listPays.Add(pays);
                            }
                            return listPays;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> getAllPays-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);
                        return listPays;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        #endregion

        #region Direction/Service

        public List<CDirection> getAllDirection(string Chaineconnex)
        {
            var listPays = new List<CDirection>();
            using (mConnection = mProvider.CreateConnection())
            {
                if (mConnection == null) return listPays;
                mConnection.ConnectionString = Chaineconnex;
                mConnection.Open();

                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"SELECT * from BIR_Direction WHERE IsDelete=0 ";

                        // command.CommandTimeout = 300;
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var pays = new CDirection
                                {
                                    mId = reader["Id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Id"]),
                                    mCodeDirection = reader["CodeDirection"] == DBNull.Value ? string.Empty : reader["CodeDirection"] as string,
                                    mIntituleDirection = reader["IntituleDirection"] == DBNull.Value ? string.Empty : reader["IntituleDirection"] as string,
                                    mDescription = reader["Description"] == DBNull.Value ? string.Empty : reader["Description"] as string,

                                    mIsDelete = reader["IsDelete"] == DBNull.Value ? 0 : Convert.ToInt16(reader["IsDelete"]),
                                    mUserCreation = reader["UserCreation"] == DBNull.Value ? string.Empty : reader["UserCreation"] as string,
                                    mUserLastModification = reader["UserLastModification"] == DBNull.Value ? string.Empty : reader["UserLastModification"] as string,

                                    mDateCreation = reader["DateCreation"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateCreation"].ToString()),
                                    mDateLastModification = reader["DateLastModification"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateLastModification"].ToString()),

                                };

                                listPays.Add(pays);
                            }
                            return listPays;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> getAllPoste-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);

                        return listPays;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public bool addDirection(CDirection client, string ChaineConx)
        {
            bool res = false;

            using (mConnection = mProvider.CreateConnection())
            {
                mConnection.ConnectionString = ChaineConx;
                mConnection.Open();
                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"INSERT INTO BIR_Direction
                        (CodeDirection,IntituleDirection,Description,IsDelete,UserCreation,UserLastModification,DateCreation,DateLastModification)
                        VALUES (@CodeDirection,@IntituleDirection,@Description,@IsDelete,@UserCreation,@UserLastModification,@DateCreation,@DateLastModification)";

                        command.Parameters.Add(new SqlParameter("CodeDirection", client.mCodeDirection ?? ""));
                        command.Parameters.Add(new SqlParameter("IntituleDirection", client.mIntituleDirection ?? ""));
                        command.Parameters.Add(new SqlParameter("Description", client.mDescription ?? ""));
                        command.Parameters.Add(new SqlParameter("IsDelete", client.mIsDelete));
                        command.Parameters.Add(new SqlParameter("UserCreation", client.mUserCreation ?? ""));
                        command.Parameters.Add(new SqlParameter("UserLastModification", client.mUserLastModification ?? ""));
                        command.Parameters.Add(new SqlParameter("DateCreation", client.mDateCreation));
                        command.Parameters.Add(new SqlParameter("DateLastModification", client.mDateLastModification));

                        command.ExecuteNonQuery();
                        res = true;

                        return res;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> addPoste-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);
                        return res;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public bool updateDirection(CDirection client, string chaineconx)
        {
            bool res = false;

            using (mConnection = mProvider.CreateConnection())
            {
                mConnection.ConnectionString = chaineconx;
                mConnection.Open();
                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"UPDATE BIR_Direction SET 
                        CodeDirection=@CodeDirection,IntituleDirection=@IntituleDirection,Description=@Description,IsDelete=@IsDelete,UserLastModification=@UserLastModification,DateLastModification=@DateLastModification WHERE Id = @Id";

                        command.Parameters.Add(new SqlParameter("Id", client.mId));
                        command.Parameters.Add(new SqlParameter("CodeDirection", client.mCodeDirection ?? ""));
                        command.Parameters.Add(new SqlParameter("IntituleDirection", client.mIntituleDirection ?? ""));
                        command.Parameters.Add(new SqlParameter("Description", client.mDescription ?? ""));
                        command.Parameters.Add(new SqlParameter("IsDelete", client.mIsDelete));
                        //  command.Parameters.Add(new SqlParameter("UserCreation", client.mUserCreation ?? ""));
                        command.Parameters.Add(new SqlParameter("UserLastModification", client.mUserLastModification ?? ""));
                        //  command.Parameters.Add(new SqlParameter("DateCreation", client.mDateCreation));
                        command.Parameters.Add(new SqlParameter("DateLastModification", client.mDateLastModification));

                        command.ExecuteNonQuery();
                        res = true;

                        return res;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> updatePoste-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);
                        return res;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public bool deleteDirection(int Id, string chaineconx)
        {
            bool res = false;
            using (mConnection = mProvider.CreateConnection())
            {
                if (mConnection == null) return res;
                mConnection.ConnectionString = chaineconx;
                mConnection.Open();
                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"UPDATE BIR_Direction SET IsDelete=1  WHERE Id = @Id";

                        var licenceId = command.CreateParameter();
                        licenceId.ParameterName = "@Id";
                        licenceId.Value = Id;
                        command.Parameters.Add(licenceId);

                        command.ExecuteNonQuery();
                        res = true;

                        return res;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> deletePoste-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);
                        return res;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public CDirection getDirectionById(int Id, string Chaineconnex)
        {
            var listPays = new CDirection();
            using (mConnection = mProvider.CreateConnection())
            {
                if (mConnection == null) return listPays;
                mConnection.ConnectionString = Chaineconnex;
                mConnection.Open();

                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"SELECT * from BIR_Direction WHERE IsDelete=0 and Id = @Id ";

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                listPays.mId = reader["Id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Id"]);
                                listPays.mCodeDirection = reader["CodeDirection"] == DBNull.Value ? string.Empty : reader["CodeDirection"] as string;
                                listPays.mIntituleDirection = reader["IntituleDirection"] == DBNull.Value ? string.Empty : reader["IntituleDirection"] as string;
                                listPays.mDescription = reader["Description"] == DBNull.Value ? string.Empty : reader["Description"] as string;

                                listPays.mIsDelete = reader["IsDelete"] == DBNull.Value ? 0 : Convert.ToInt16(reader["IsDelete"]);
                                listPays.mUserCreation = reader["UserCreation"] == DBNull.Value ? string.Empty : reader["UserCreation"] as string;
                                listPays.mUserLastModification = reader["UserLastModification"] == DBNull.Value ? string.Empty : reader["UserLastModification"] as string;

                                listPays.mDateCreation = reader["DateCreation"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateCreation"].ToString());
                                listPays.mDateLastModification = reader["DateLastModification"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateLastModification"].ToString());

                            }
                            return listPays;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        var msg = "DAOASS -> getPosteById-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);

                        return listPays;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        #endregion

        #region EntiteAITEK

        public List<CEntiteAITEK> getAllEntiteAITEK(string Chaineconnex,List<CPays>ListePays)
        {
            var listPays = new List<CEntiteAITEK>();
            using (mConnection = mProvider.CreateConnection())
            {
                if (mConnection == null) return listPays;
                mConnection.ConnectionString = Chaineconnex;
                mConnection.Open();

                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"SELECT * from BIR_EntiteAITEK WHERE IsDelete=0 ";

                        // command.CommandTimeout = 300;
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var pays = new CEntiteAITEK
                                {
                                    mId = reader["Id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Id"]),
                                    mIdPays = reader["IdPays"] == DBNull.Value ? 0 : Convert.ToInt32(reader["IdPays"]),
                                    mLibelleEntiteAITEK = reader["LibelleEntiteAITEK"] == DBNull.Value ? string.Empty : reader["LibelleEntiteAITEK"] as string,
                                    mLibellePays = GetLibellePays(reader["IdPays"] == DBNull.Value ? 0 : Convert.ToInt32(reader["IdPays"]),ListePays),
                                   
                                    mIsDelete = reader["IsDelete"] == DBNull.Value ? 0 : Convert.ToInt16(reader["IsDelete"]),
                                    mUserCreation = reader["UserCreation"] == DBNull.Value ? string.Empty : reader["UserCreation"] as string,
                                    mUserLastModification = reader["UserLastModification"] == DBNull.Value ? string.Empty : reader["UserLastModification"] as string,

                                    mDateCreation = reader["DateCreation"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateCreation"].ToString()),
                                    mDateLastModification = reader["DateLastModification"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateLastModification"].ToString()),

                                };

                                listPays.Add(pays);
                            }
                            return listPays;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> getAllPoste-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);

                        return listPays;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }


        public string GetLibellePays(int idpays,List<CPays>LP)
        {
            string ret = string.Empty;
            try
            {
                var CRET = LP.FirstOrDefault(c => c.mId == idpays);

                ret = CRET.mLibellePays;

                return ret;
            }
            catch(Exception ex)
            {
                return ret;
            }
        }


        public bool addEntiteAITEK(CEntiteAITEK client, string ChaineConx)
        {
            bool res = false;

            using (mConnection = mProvider.CreateConnection())
            {
                mConnection.ConnectionString = ChaineConx;
                mConnection.Open();
                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"INSERT INTO BIR_EntiteAITEK
                        (IdPays,LibelleEntiteAITEK,IsDelete,UserCreation,UserLastModification,DateCreation,DateLastModification)
                        VALUES (@IdPays,@LibelleEntiteAITEK,@IsDelete,@UserCreation,@UserLastModification,@DateCreation,@DateLastModification)";

                        command.Parameters.Add(new SqlParameter("IdPays", client.mIdPays));
                        command.Parameters.Add(new SqlParameter("LibelleEntiteAITEK", client.mLibelleEntiteAITEK ?? ""));
                      
                        command.Parameters.Add(new SqlParameter("IsDelete", client.mIsDelete));
                        command.Parameters.Add(new SqlParameter("UserCreation", client.mUserCreation ?? ""));
                        command.Parameters.Add(new SqlParameter("UserLastModification", client.mUserLastModification ?? ""));
                        command.Parameters.Add(new SqlParameter("DateCreation", client.mDateCreation));
                        command.Parameters.Add(new SqlParameter("DateLastModification", client.mDateLastModification));

                        command.ExecuteNonQuery();
                        res = true;

                        return res;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> addPoste-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);
                        return res;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public bool updateEntiteAITEK(CEntiteAITEK client, string chaineconx)
        {
            bool res = false;

            using (mConnection = mProvider.CreateConnection())
            {
                mConnection.ConnectionString = chaineconx;
                mConnection.Open();
                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"UPDATE BIR_EntiteAITEK SET 
                        IdPays=@IdPays,LibelleEntiteAITEK=@LibelleEntiteAITEK,IsDelete=@IsDelete,UserLastModification=@UserLastModification,DateLastModification=@DateLastModification WHERE Id = @Id";

                        command.Parameters.Add(new SqlParameter("Id", client.mId));
                        command.Parameters.Add(new SqlParameter("IdPays", client.mIdPays));
                        command.Parameters.Add(new SqlParameter("LibelleEntiteAITEK", client.mLibelleEntiteAITEK ?? ""));
                    
                        command.Parameters.Add(new SqlParameter("IsDelete", client.mIsDelete));
                        //  command.Parameters.Add(new SqlParameter("UserCreation", client.mUserCreation ?? ""));
                        command.Parameters.Add(new SqlParameter("UserLastModification", client.mUserLastModification ?? ""));
                        //  command.Parameters.Add(new SqlParameter("DateCreation", client.mDateCreation));
                        command.Parameters.Add(new SqlParameter("DateLastModification", client.mDateLastModification));

                        command.ExecuteNonQuery();
                        res = true;

                        return res;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> updatePoste-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);
                        return res;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public bool deleteEntiteAITEK(int Id, string chaineconx)
        {
            bool res = false;
            using (mConnection = mProvider.CreateConnection())
            {
                if (mConnection == null) return res;
                mConnection.ConnectionString = chaineconx;
                mConnection.Open();
                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"UPDATE BIR_EntiteAITEK SET IsDelete=1  WHERE Id = @Id";

                        var licenceId = command.CreateParameter();
                        licenceId.ParameterName = "@Id";
                        licenceId.Value = Id;
                        command.Parameters.Add(licenceId);

                        command.ExecuteNonQuery();
                        res = true;

                        return res;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> deletePoste-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);
                        return res;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public CEntiteAITEK getEntiteAITEKById(int Id, string Chaineconnex)
        {
            var listPays = new CEntiteAITEK();
            using (mConnection = mProvider.CreateConnection())
            {
                if (mConnection == null) return listPays;
                mConnection.ConnectionString = Chaineconnex;
                mConnection.Open();

                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"SELECT * from BIR_EntiteAITEK WHERE IsDelete=0 and Id = @Id ";

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                listPays.mId = reader["Id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Id"]);
                                listPays.mIdPays = reader["IdPays"] == DBNull.Value ? 0 : Convert.ToInt32(reader["IdPays"]);
                                listPays.mLibelleEntiteAITEK = reader["LibelleEntiteAITEK"] == DBNull.Value ? string.Empty : reader["LibelleEntiteAITEK"] as string;
                                listPays.mLibellePays = reader["LibellePays"] == DBNull.Value ? string.Empty : reader["LibellePays"] as string;
                               
                                listPays.mIsDelete = reader["IsDelete"] == DBNull.Value ? 0 : Convert.ToInt16(reader["IsDelete"]);
                                listPays.mUserCreation = reader["UserCreation"] == DBNull.Value ? string.Empty : reader["UserCreation"] as string;
                                listPays.mUserLastModification = reader["UserLastModification"] == DBNull.Value ? string.Empty : reader["UserLastModification"] as string;

                                listPays.mDateCreation = reader["DateCreation"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateCreation"].ToString());
                                listPays.mDateLastModification = reader["DateLastModification"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateLastModification"].ToString());

                            }
                            return listPays;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        var msg = "DAOASS -> getPosteById-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);

                        return listPays;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        #endregion
        
        #region Employe

        public List<CEmploye> getAllEmploye(string Chaineconnex)
        {
            var listPays = new List<CEmploye>();
            using (mConnection = mProvider.CreateConnection())
            {
                if (mConnection == null) return listPays;
                mConnection.ConnectionString = Chaineconnex;
                mConnection.Open();

                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"SELECT * from BIR_Employe WHERE IsDelete=0 ";

                        // command.CommandTimeout = 300;
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var pays = new CEmploye
                                {
                                    mId = reader["Id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Id"]),
                                    mNom = reader["Nom"] == DBNull.Value ? string.Empty : reader["Nom"] as string,
                                    mPrenoms = reader["Prenoms"] == DBNull.Value ? string.Empty : reader["Prenoms"] as string,
                                    mIdPoste = reader["IdPoste"] == DBNull.Value ? 0 : Convert.ToInt16(reader["IdPoste"]),

                                    mLibellePoste = reader["LibellePoste"] == DBNull.Value ? string.Empty : reader["LibellePoste"] as string,

                                    mIdDirection = reader["IdDirection"] == DBNull.Value ? 0 : Convert.ToInt16(reader["IdDirection"]),
                                    mLibelleDirection = reader["LibelleDirection"] == DBNull.Value ? string.Empty : reader["LibelleDirection"] as string,

                                    mIdEntiteAITEK = reader["IdEntiteAITEK"] == DBNull.Value ? 0 : Convert.ToInt16(reader["IdEntiteAITEK"]),
                                    mLibelleEntiteAITEK = reader["LibelleEntiteAITEK"] == DBNull.Value ? string.Empty : reader["LibelleEntiteAITEK"] as string,

                                    mDateNaissance = reader["DateNaissance"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateNaissance"].ToString()),
                                    
                                    mIsDelete = reader["IsDelete"] == DBNull.Value ? 0 : Convert.ToInt16(reader["IsDelete"]),
                                    mUserCreation = reader["UserCreation"] == DBNull.Value ? string.Empty : reader["UserCreation"] as string,
                                    mUserLastModification = reader["UserLastModification"] == DBNull.Value ? string.Empty : reader["UserLastModification"] as string,

                                    mDateCreation = reader["DateCreation"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateCreation"].ToString()),
                                    mDateLastModification = reader["DateLastModification"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateLastModification"].ToString()),

                                };

                                listPays.Add(pays);
                            }
                            return listPays;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> getAllEmploye-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);

                        return listPays;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public bool addEmploye(CEmploye client, string ChaineConx)
        {
            bool res = false;

            using (mConnection = mProvider.CreateConnection())
            {
                mConnection.ConnectionString = ChaineConx;
                mConnection.Open();
                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"INSERT INTO BIR_Employe
                        (Nom,Prenoms,IdPoste,IdDirection,IdEntiteAITEK,DateNaissance,IsDelete,UserCreation,UserLastModification,DateCreation,DateLastModification)
                        VALUES (@Nom,@Prenoms,@IdPoste,@IdDirection,@IdEntiteAITEK,@DateNaissance,@IsDelete,@UserCreation,@UserLastModification,@DateCreation,@DateLastModification)";

                        command.Parameters.Add(new SqlParameter("Nom", client.mNom ?? ""));
                        command.Parameters.Add(new SqlParameter("Prenoms", client.mPrenoms ?? ""));
                        command.Parameters.Add(new SqlParameter("IdPoste", client.mIdPoste));
                        command.Parameters.Add(new SqlParameter("IdDirection", client.mIdDirection));
                        command.Parameters.Add(new SqlParameter("IdEntiteAITEK", client.mIdEntiteAITEK));
                        command.Parameters.Add(new SqlParameter("DateNaissance", client.mDateCreation));
                        command.Parameters.Add(new SqlParameter("IsDelete", client.mIsDelete));
                        command.Parameters.Add(new SqlParameter("UserCreation", client.mUserCreation ?? ""));
                        command.Parameters.Add(new SqlParameter("UserLastModification", client.mUserLastModification ?? ""));
                        command.Parameters.Add(new SqlParameter("DateCreation", client.mDateCreation));
                        command.Parameters.Add(new SqlParameter("DateLastModification", client.mDateLastModification));

                        command.ExecuteNonQuery();
                        res = true;

                        return res;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> addEmploye-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);
                        return res;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public bool updateEmploye(CEmploye client, string chaineconx)
        {
            bool res = false;

            using (mConnection = mProvider.CreateConnection())
            {
                mConnection.ConnectionString = chaineconx;
                mConnection.Open();
                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"UPDATE BIR_Employe SET 
                        Nom=@Nom,Prenoms=@Prenoms,IdPoste=@IdPoste,IdDirection=@IdDirection,IdEntiteAITEK=@IdEntiteAITEK,DateNaissance=@DateNaissance,IsDelete=@IsDelete,UserCreation=@UserCreation,UserLastModification=@UserLastModification,DateCreation=@DateCreation,DateLastModification=@DateLastModification WHERE Id = @Id";

                        command.Parameters.Add(new SqlParameter("Id", client.mId));
                        command.Parameters.Add(new SqlParameter("Nom", client.mNom ?? ""));
                        command.Parameters.Add(new SqlParameter("Prenoms", client.mPrenoms ?? ""));
                        command.Parameters.Add(new SqlParameter("IdPoste", client.mIdPoste));
                        command.Parameters.Add(new SqlParameter("IdDirection", client.mIdDirection));
                        command.Parameters.Add(new SqlParameter("IdEntiteAITEK", client.mIdEntiteAITEK));
                        command.Parameters.Add(new SqlParameter("DateNaissance", client.mDateNaissance));
                        command.Parameters.Add(new SqlParameter("IsDelete", client.mIsDelete));
                        //  command.Parameters.Add(new SqlParameter("UserCreation", client.mUserCreation ?? ""));
                        command.Parameters.Add(new SqlParameter("UserLastModification", client.mUserLastModification ?? ""));
                        //  command.Parameters.Add(new SqlParameter("DateCreation", client.mDateCreation));
                        command.Parameters.Add(new SqlParameter("DateLastModification", client.mDateLastModification));

                        command.ExecuteNonQuery();
                        res = true;

                        return res;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> updateEmploye-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);
                        return res;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public bool deleteEmploye(int Id, string chaineconx)
        {
            bool res = false;
            using (mConnection = mProvider.CreateConnection())
            {
                if (mConnection == null) return res;
                mConnection.ConnectionString = chaineconx;
                mConnection.Open();
                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"UPDATE BIR_Employe SET IsDelete=1  WHERE Id = @Id";

                        var licenceId = command.CreateParameter();
                        licenceId.ParameterName = "@Id";
                        licenceId.Value = Id;
                        command.Parameters.Add(licenceId);

                        command.ExecuteNonQuery();
                        res = true;

                        return res;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var msg = "DAOASS -> deleteEmploye-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);
                        return res;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        public CEmploye getEmployeById(int Id, string Chaineconnex)
        {
            var listPays = new CEmploye();
            using (mConnection = mProvider.CreateConnection())
            {
                if (mConnection == null) return listPays;
                mConnection.ConnectionString = Chaineconnex;
                mConnection.Open();

                using (var command = mConnection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = @"SELECT * from BIR_Employe WHERE IsDelete=0 and Id = @Id ";

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                listPays.mId = reader["Id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Id"]);

                                listPays.mNom = reader["Nom"] == DBNull.Value ? string.Empty : reader["Nom"] as string;
                                listPays.mPrenoms = reader["Prenoms"] == DBNull.Value ? string.Empty : reader["Prenoms"] as string;
                                listPays.mIdPoste = reader["IdPoste"] == DBNull.Value ? 0 : Convert.ToInt16(reader["IdPoste"]);

                                listPays.mLibellePoste = reader["LibellePoste"] == DBNull.Value ? string.Empty : reader["LibellePoste"] as string;

                                listPays.mIdDirection = reader["IdDirection"] == DBNull.Value ? 0 : Convert.ToInt16(reader["IdDirection"]);
                                listPays.mLibelleDirection = reader["LibelleDirection"] == DBNull.Value ? string.Empty : reader["LibelleDirection"] as string;

                                listPays.mIdEntiteAITEK = reader["IdEntiteAITEK"] == DBNull.Value ? 0 : Convert.ToInt16(reader["IdEntiteAITEK"]);
                                listPays.mLibelleEntiteAITEK = reader["LibelleEntiteAITEK"] == DBNull.Value ? string.Empty : reader["LibelleEntiteAITEK"] as string;

                                listPays.mDateNaissance = reader["DateNaissance"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateNaissance"].ToString());

                                listPays.mIsDelete = reader["IsDelete"] == DBNull.Value ? 0 : Convert.ToInt16(reader["IsDelete"]);
                                listPays.mUserCreation = reader["UserCreation"] == DBNull.Value ? string.Empty : reader["UserCreation"] as string;
                                listPays.mUserLastModification = reader["UserLastModification"] == DBNull.Value ? string.Empty : reader["UserLastModification"] as string;

                                listPays.mDateCreation = reader["DateCreation"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateCreation"].ToString());
                                listPays.mDateLastModification = reader["DateLastModification"] == DBNull.Value ? new DateTime() : DateTime.Parse(reader["DateLastModification"].ToString());

                            }
                            return listPays;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur est survenue! Veuillez contacter votre Administrateur!", Appli, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        var msg = "DAOASS -> getEmployeById-> TypeErreur: " + ex.Message;
                        CLog.Log(msg);

                        return listPays;
                    }
                    finally
                    {
                        mConnection.Close();
                    }
                }
            }
        }

        #endregion

    }
}
