using System;
using System.Collections.Generic;
using System.Data;

namespace Business
{
    public class Schedule
    {
        #region Propriedades
        public int Id { get; set; }

        public string Vehicle { get; set; }

        public string Repair { get; set; }

        public string Mechanic { get; set; }

        public string Client { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime Alertdate { get; set; }

        public string Time { get; set; }

        public string Email { get; set; }

        #endregion

        #region Métodos
        public void Save()
        {
            if (this.Id > 0)
            {
                new DataBase.Schedule().Update(this.Id, this.Vehicle, this.Repair, this.Mechanic, this.Client, this.StartDate, this.EndDate, this.Alertdate, this.Time, this.Email);
                return;
            }

            this.Id = new DataBase.Schedule().Save(this.Vehicle, this.Repair, this.Mechanic, this.Client, this.StartDate, this.EndDate, this.Alertdate, this.Time, this.Email);
        }

        public void Update()
        {
            if (this.Id > 0)
            {
                new DataBase.Schedule().Update(this.Id, this.Vehicle, this.Repair, this.Mechanic, this.Client, this.StartDate, this.EndDate, this.Alertdate, this.Time, this.Email);
                return;
            }
        }

        public static List<Schedule> ScheduleList()
        {
            var _schedules = new List<Schedule>();
            DataTable _scheduleData = new DataBase.Schedule().ScheduleList();

            for (int i = 0; i < _scheduleData.Rows.Count; i++)
            {
                _schedules.Add(new Schedule()
                {
                    Id = Convert.ToInt32(_scheduleData.Rows[i]["Id"]),
                    Vehicle = _scheduleData.Rows[i]["Vehicle"].ToString(),
                    Repair = _scheduleData.Rows[i]["Repair"].ToString(),
                    Mechanic = _scheduleData.Rows[i]["Mechanic"].ToString(),
                    Client = _scheduleData.Rows[i]["Client"].ToString(),
                    StartDate = Convert.ToDateTime(_scheduleData.Rows[i]["Startdate"]),
                    EndDate = Convert.ToDateTime(_scheduleData.Rows[i]["Enddate"]),
                    Alertdate = Convert.ToDateTime(_scheduleData.Rows[i]["Alertdate"]),
                    Time = _scheduleData.Rows[i]["Time"].ToString(),
                    Email = _scheduleData.Rows[i]["Email"].ToString()
                });
            }
            return _schedules;
        }

        public static List<Schedule> ScheduleListStartDate(DateTime startdate, DateTime enddate)
        {
            var _schedules = new List<Schedule>();
            DataTable _scheduleData = new DataBase.Schedule().ScheduleListStartDate(startdate, enddate);

            for (int i = 0; i < _scheduleData.Rows.Count; i++)
            {
                _schedules.Add(new Schedule()
                {
                    Id = Convert.ToInt32(_scheduleData.Rows[i]["Id"]),
                    Vehicle = _scheduleData.Rows[i]["Vehicle"].ToString(),
                    Repair = _scheduleData.Rows[i]["Repair"].ToString(),
                    Mechanic = _scheduleData.Rows[i]["Mechanic"].ToString(),
                    Client = _scheduleData.Rows[i]["Client"].ToString(),
                    StartDate = Convert.ToDateTime(_scheduleData.Rows[i]["Startdate"]),
                    EndDate = Convert.ToDateTime(_scheduleData.Rows[i]["Enddate"]),
                    Alertdate = Convert.ToDateTime(_scheduleData.Rows[i]["Alertdate"]),
                    Time = _scheduleData.Rows[i]["Time"].ToString(),
                    Email = _scheduleData.Rows[i]["Email"].ToString()
                });
            }
            return _schedules;
        }
        public static List<Schedule> ScheduleListAlertDate(DateTime alertdate)
        {
            var _schedules = new List<Schedule>();
            DataTable _scheduleData = new DataBase.Schedule().ScheduleListAlertDate(alertdate);

            for (int i = 0; i < _scheduleData.Rows.Count; i++)
            {
                _schedules.Add(new Schedule()
                {
                    Id = Convert.ToInt32(_scheduleData.Rows[i]["Id"]),
                    Vehicle = _scheduleData.Rows[i]["Vehicle"].ToString(),
                    Repair = _scheduleData.Rows[i]["Repair"].ToString(),
                    Mechanic = _scheduleData.Rows[i]["Mechanic"].ToString(),
                    Client = _scheduleData.Rows[i]["Client"].ToString(),
                    StartDate = Convert.ToDateTime(_scheduleData.Rows[i]["Startdate"]),
                    EndDate = Convert.ToDateTime(_scheduleData.Rows[i]["Enddate"]),
                    Alertdate = Convert.ToDateTime(_scheduleData.Rows[i]["Alertdate"]),
                    Time = _scheduleData.Rows[i]["Time"].ToString(),
                    Email = _scheduleData.Rows[i]["Email"].ToString()
                });
            }
            return _schedules;
        }

        public static void Delete(int id)
        {
            new DataBase.Schedule().Delete(id);
        }

        #endregion
    }
}
