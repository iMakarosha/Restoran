using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Collections;
using System.Data.SqlClient;


namespace Restoran
{
    public partial class Otchet_po_zakazam_p : Form
    {
        public int ID = 0;
        public int ID_postavshik = 0;
        public string date = "";
        public int Count = 0;
        public string Summ = "";

        public Otchet_po_zakazam_p()
        {
            InitializeComponent();
        }

        private void Otchet_po_zakazam_p_Load(object sender, EventArgs e)
        {
            min_zakazTableAdapter.Fill(dataSet1_for_otchet.Min_zakaz, ID);

            ReportParameter p1 = new ReportParameter("p1", "Заказ поставщику № " + ID.ToString() + " от " + date);
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p1 });

            ReportParameter p4 = new ReportParameter("p4", "Всего наименований " + Count.ToString() + ", на сумму " + Summ + " руб.");
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p4 });

            //Покупатель
            string Name1 = "select Naimenovanie_Polno from Dannie";
            object Namee1 = new Handlers.SqlConnectionHandler().GetQueryResult(Name1);
            string INN1 = "select INN from Dannie";
            object INNN1 = new Handlers.SqlConnectionHandler().GetQueryResult(INN1);
            string KPP1 = "select KPP from Dannie";
            object KPPP1 = new Handlers.SqlConnectionHandler().GetQueryResult(KPP1);

            if (INNN1.ToString() != "" && KPPP1.ToString() != "")
            {
                ReportParameter p2 = new ReportParameter("p2", Namee1.ToString() + ", ИНН " + INNN1.ToString() + ", КПП " + KPPP1.ToString());
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p2 });
            }

            if (INNN1.ToString() == "" && KPPP1.ToString() != "")
            {
                ReportParameter p2 = new ReportParameter("p2", Namee1.ToString() + ", КПП " + KPPP1.ToString());
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p2 });
            }
            if (INNN1.ToString() != "" && KPPP1.ToString() == "")
            {
                ReportParameter p2 = new ReportParameter("p2", Namee1.ToString() + ", ИНН " + INNN1.ToString());
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p2 });
            }

            if (INNN1.ToString() == "" && KPPP1.ToString() == "")
            {
                ReportParameter p2 = new ReportParameter("p2", Namee1.ToString());
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p2 });

            }

            //Поставщик
            string Name2 = "select Name_Polno from Kontragent where ID_Kontragent= " + ID_postavshik;
            object Namee2 = new Handlers.SqlConnectionHandler().GetQueryResult(Name2);
            string INN2 = "select INN from Kontragent where ID_Kontragent= " + ID_postavshik;
            object INNN2 = new Handlers.SqlConnectionHandler().GetQueryResult(INN2);
            string KPP2 = "select KPP from Kontragent where ID_Kontragent= " + ID_postavshik;
            object KPPP2 = new Handlers.SqlConnectionHandler().GetQueryResult(KPP2);

            if (INNN2.ToString() != "" && KPPP2.ToString() != "")
            {
                ReportParameter p3 = new ReportParameter("p3", Namee2.ToString() + ", ИНН " + INNN2.ToString() + ", КПП " + KPPP2.ToString());
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p3 });
            }
            if (INNN2.ToString() == "" && KPPP2.ToString() != "")
            {
                ReportParameter p3 = new ReportParameter("p3", Namee2.ToString() + ", КПП " + KPPP2.ToString());
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p3 });
            }
            if (INNN2.ToString() != "" && KPPP2.ToString() == "")
            {
                ReportParameter p3 = new ReportParameter("p3", Namee2.ToString() + ", ИНН " + INNN2.ToString());
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p3 });

            }
            if (INNN2.ToString() == "" && KPPP2.ToString() == "")
            {
                ReportParameter p3 = new ReportParameter("p3", Namee2.ToString());
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p3 });
            }

            this.reportViewer1.RefreshReport();
        }
    }
}