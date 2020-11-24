using System;
using System.Collections.Generic;

namespace IoT.Entities.Matbag
{
    public class DashboardV1ViewModel
    {
        //readonly string _connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //public List<AirlineData> GetAirlines()
        //{
        //    List<AirlineData> lista = new List<AirlineData>();
        //    try
        //    {
        //        using (MLIDBEntities list = new MLIDBEntities())
        //        {
        //            lista = list.usp_GetListAirline().Select(slc => new AirlineData
        //            {
        //                Id = int.Parse(slc.id.ToString()),
        //                Airline_Name = slc.airline_name,
        //                Cod_Airline = slc.icao_designator
        //            }).ToList();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex.Message.ToString());
        //    }
        //    return lista;
        //}

        //public void SaveWakeUpModel(int carrusel, int idAir)
        //{
        //    try
        //    {
        //        using (MLIDBEntities list = new MLIDBEntities())
        //        {
        //            list.usp_SaveWakeUp(carrusel, idAir);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex.Message.ToString());
        //    }
        //}

        //public List<Carrusel> LoadWakeUp()
        //{
        //    List<Carrusel> dtwkp = new List<Carrusel>();
        //    try
        //    {
        //        using (MLIDBEntities list = new MLIDBEntities())
        //        {
        //            dtwkp = list.usp_LoadWakeUp().Select(slc => new Carrusel
        //            {
        //                Airline_Name = slc.airline_name,
        //                Cod_Airline = slc.icao_designator,
        //                carrusel = int.Parse(slc.carrusel.ToString()),
        //                IdAirline = int.Parse(slc.ID_AIRLINE_LIST.ToString())
        //            }).ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex.Message.ToString());
        //    }
        //    return dtwkp;
        //}

        //public void DeleteAirlineWakeup(int idAir)
        //{
        //    try
        //    {
        //        using (MLIDBEntities del = new MLIDBEntities())
        //        {
        //            del.usp_DeleteWakeUpCarr(idAir);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex.Message.ToString());
        //    }
        //}

/// <summary>
/// Servicio
/// </summary>
        //public List<Carrusel> LoadWakeUp()
        //{
        //    var ListWakeUp = new List<Carrusel>();

        //    try
        //    {
        //        using (var connection = new SqlConnection(_connString))
        //        {
        //            connection.Open();

        //            string command = "select airline_name, icao_designator, carrusel, ID_AIRLINE_LIST from [dbo].[carruseles] as crr inner join[dbo].[airline_list] as airl on crr.id_airline_list = airl.Id";

        //            SqlCommand dependencyCommand = new SqlCommand(command, connection);
        //            dependencyCommand.Notification = null;

        //            SqlDependency dependency = new SqlDependency();

        //            dependency.OnChange += new OnChangeEventHandler(Dependency_OnChange);

        //            if (connection.State == ConnectionState.Closed)
        //            {
        //                connection.Open();
        //            }

        //            var reader = dependencyCommand.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                ListWakeUp.Add(item: new Carrusel
        //                {
        //                    Airline_Name = (string)reader["airline_name"],
        //                    Cod_Airline = (string)reader["icao_designator"],
        //                    carrusel = (int)reader["carrusel"],
        //                    IdAirline = (int)reader["ID_AIRLINE_LIST"]
        //                });
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }

        //    return ListWakeUp;
        //}

        //private void Dependency_OnChange(object sender, SqlNotificationEventArgs e)
        //{
        //    if (e.Type == SqlNotificationType.Change)
        //    {
        //        LoadWakeUpViewHub.SendChanges();
        //    }
        //}

        public class AirlineData
        {
            public int Id { get; set; }
            public string Airline_Name { get; set; }
            public string Cod_Airline { get; set; }
        }

        public class Carrusel
        {
            public int IdAirline { get; set; }
            public string Airline_Name { get; set; }
            public string Cod_Airline { get; set; }
            public int carrusel { get; set; }
        }

    }
}
