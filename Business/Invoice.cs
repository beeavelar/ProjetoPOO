using System;
using System.Collections.Generic;
using System.Data;

namespace Business
{
    public class Invoice
    {
        #region Propriedades
        public int Id { get; set; }

        public int ServiceOrder { get; set; }

        public string Vehicle { get; set; }

        public string Repair { get; set; }

        public string Mechanic { get; set; }

        public string Client { get; set; }

        public int Nif { get; set; }

        public string PaymentType { get; set; }

        public DateTime IssueDate { get; set; }

        public Decimal RepairPrice { get; set; }

        public Decimal LaborPrice { get; set; }

        public Decimal Total { get; set; }

        #endregion

        #region Métodos
        public void Save()
        {
            if (this.Id > 0)
            {
                new DataBase.Invoice().Update(this.Id, this.ServiceOrder, this.Vehicle, this.Repair, this.Mechanic, this.Client, this.Nif, this.PaymentType, this.IssueDate, this.RepairPrice, this.LaborPrice, this.Total);
                return;
            }

            this.Id = new DataBase.Invoice().Save(this.ServiceOrder, this.Vehicle, this.Repair, this.Mechanic, this.Client, this.Nif, this.PaymentType, this.IssueDate, this.RepairPrice, this.LaborPrice, this.Total);
        }

        public void Update()
        {
            if (this.Id > 0)
            {
                new DataBase.Invoice().Update(this.Id, this.ServiceOrder, this.Vehicle, this.Repair, this.Mechanic, this.Client, this.Nif, this.PaymentType, this.IssueDate, this.RepairPrice, this.LaborPrice, this.Total);
                return;
            }
        }

        public static List<Invoice> InvoiceList()
        {
            var _invoices = new List<Invoice>();
            DataTable _invoiceData = new DataBase.Invoice().InvoiceList();

            for (int i = 0; i < _invoiceData.Rows.Count; i++)
            {
                _invoices.Add(new Invoice()
                {
                    Id = Convert.ToInt32(_invoiceData.Rows[i]["Id"]),
                    ServiceOrder = Convert.ToInt32(_invoiceData.Rows[i]["Serviceorder"]),
                    Vehicle = _invoiceData.Rows[i]["Vehicle"].ToString(),
                    Repair = _invoiceData.Rows[i]["Repair"].ToString(),
                    Mechanic = _invoiceData.Rows[i]["Mechanic"].ToString(),
                    Client = _invoiceData.Rows[i]["Client"].ToString(),
                    Nif = Convert.ToInt32(_invoiceData.Rows[i]["Nif"]),
                    PaymentType = _invoiceData.Rows[i]["Paymenttype"].ToString(),
                    IssueDate = Convert.ToDateTime(_invoiceData.Rows[i]["Issuedate"]),
                    RepairPrice = Convert.ToDecimal(_invoiceData.Rows[i]["Repairprice"]),
                    LaborPrice = Convert.ToDecimal(_invoiceData.Rows[i]["Laborprice"]),
                    Total = Convert.ToDecimal(_invoiceData.Rows[i]["Total"])
                });
            }
            return _invoices;
        }

        public static List<Invoice> InvoiceListIssueDate(DateTime issuedate)
        {
            var _invoices = new List<Invoice>();
            DataTable _invoiceData = new DataBase.Invoice().InvoiceListIssueDate(issuedate);

            for (int i = 0; i < _invoiceData.Rows.Count; i++)
            {
                _invoices.Add(new Invoice()
                {
                    Id = Convert.ToInt32(_invoiceData.Rows[i]["Id"]),
                    ServiceOrder = Convert.ToInt32(_invoiceData.Rows[i]["Serviceorder"]),
                    Vehicle = _invoiceData.Rows[i]["Vehicle"].ToString(),
                    Repair = _invoiceData.Rows[i]["Repair"].ToString(),
                    Mechanic = _invoiceData.Rows[i]["Mechanic"].ToString(),
                    Client = _invoiceData.Rows[i]["Client"].ToString(),
                    Nif = Convert.ToInt32(_invoiceData.Rows[i]["Nif"]),
                    PaymentType = _invoiceData.Rows[i]["Paymenttype"].ToString(),
                    IssueDate = Convert.ToDateTime(_invoiceData.Rows[i]["Issuedate"]),
                    RepairPrice = Convert.ToDecimal(_invoiceData.Rows[i]["Repairprice"]),
                    LaborPrice = Convert.ToDecimal(_invoiceData.Rows[i]["Laborprice"]),
                    Total = Convert.ToDecimal(_invoiceData.Rows[i]["Total"])
                });
            }
            return _invoices;
        }

        public static void Delete(int id)
        {
            new DataBase.Invoice().Delete(id);
        }

        #endregion
    }
}
