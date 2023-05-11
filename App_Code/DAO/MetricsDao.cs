using System;
using System.Web;
using System.Data;
using Oracle.DataAccess.Client;
using Agile.Domain;
using Agile.DAO;
using Agile.Helper;
using Agile.Services.Impl;
using Agile.Services.Interface;
using System.Collections;

namespace Agile.DAO {
    public class MetricsDAO {

        public MetricsDAO() {

        }

        public Metrics Select(string p) {
            Metrics q = new Metrics();
            DataTable dt = DBHelper.SelectDataTable(Metrics.SELECT_METRICS, DBHelper.mp("ID", p));
            for (int i = 0; i < dt.Rows.Count; i++) {
                q.Id = (((DataRow)(dt.Rows[i]))["ID"]).ToString();
                q.Year = (((DataRow)(dt.Rows[i]))["YEAR"]).ToString();
                q.MetricsId = (((DataRow)(dt.Rows[i]))["METRICS_ID"]).ToString();
                q.Category = (((DataRow)(dt.Rows[i]))["CATEGORY"]).ToString();
                q.Field = (((DataRow)(dt.Rows[i]))["FIELD"]).ToString();
                q.Jan = (((DataRow)(dt.Rows[i]))["JAN"]).ToString();
                q.Feb = (((DataRow)(dt.Rows[i]))["FEB"]).ToString();
                q.Mar = (((DataRow)(dt.Rows[i]))["MAR"]).ToString();
                q.Apr = (((DataRow)(dt.Rows[i]))["APR"]).ToString();
                q.May = (((DataRow)(dt.Rows[i]))["MAY"]).ToString();
                q.Jun = (((DataRow)(dt.Rows[i]))["JUN"]).ToString();
                q.Jul = (((DataRow)(dt.Rows[i]))["JUL"]).ToString();
                q.Aug = (((DataRow)(dt.Rows[i]))["AUG"]).ToString();
                q.Sep = (((DataRow)(dt.Rows[i]))["SEP"]).ToString();
                q.Oct = (((DataRow)(dt.Rows[i]))["OCT"]).ToString();
                q.Nov = (((DataRow)(dt.Rows[i]))["NOV"]).ToString();
                q.Dec = (((DataRow)(dt.Rows[i]))["DEC"]).ToString();
                q.Ytd = (((DataRow)(dt.Rows[i]))["YTD"]).ToString();
                q.Ave = (((DataRow)(dt.Rows[i]))["AVE"]).ToString();
                q.Calc = (((DataRow)(dt.Rows[i]))["CALC"]).ToString();
            }
            return q;
        }

        public Metrics SELECT_METRICS_BY_YEAR(string p) {
            Metrics q = new Metrics();
            DataTable dt = DBHelper.SelectDataTable(Metrics.SELECT_METRICS_BY_YEAR, DBHelper.mp("YEAR", p));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                q.Id = (((DataRow)(dt.Rows[i]))["ID"]).ToString();
                q.Year = (((DataRow)(dt.Rows[i]))["YEAR"]).ToString();
                q.MetricsId = (((DataRow)(dt.Rows[i]))["METRICS_ID"]).ToString();
                q.Category = (((DataRow)(dt.Rows[i]))["CATEGORY"]).ToString();
                q.Field = (((DataRow)(dt.Rows[i]))["FIELD"]).ToString();
                q.Jan = (((DataRow)(dt.Rows[i]))["JAN"]).ToString();
                q.Feb = (((DataRow)(dt.Rows[i]))["FEB"]).ToString();
                q.Mar = (((DataRow)(dt.Rows[i]))["MAR"]).ToString();
                q.Apr = (((DataRow)(dt.Rows[i]))["APR"]).ToString();
                q.May = (((DataRow)(dt.Rows[i]))["MAY"]).ToString();
                q.Jun = (((DataRow)(dt.Rows[i]))["JUN"]).ToString();
                q.Jul = (((DataRow)(dt.Rows[i]))["JUL"]).ToString();
                q.Aug = (((DataRow)(dt.Rows[i]))["AUG"]).ToString();
                q.Sep = (((DataRow)(dt.Rows[i]))["SEP"]).ToString();
                q.Oct = (((DataRow)(dt.Rows[i]))["OCT"]).ToString();
                q.Nov = (((DataRow)(dt.Rows[i]))["NOV"]).ToString();
                q.Dec = (((DataRow)(dt.Rows[i]))["DEC"]).ToString();
                q.Ytd = (((DataRow)(dt.Rows[i]))["YTD"]).ToString();
                q.Ave = (((DataRow)(dt.Rows[i]))["AVE"]).ToString();
                q.Calc = (((DataRow)(dt.Rows[i]))["CALC"]).ToString();
            }
            return q;
        }

        public void Insert(Metrics p) {
            OracleParameter[] paramsList = createParamList(p);
            DBHelper.Execute(Metrics.INSERT_METRICS, paramsList);
        }

        public void Update(Metrics p) {
            OracleParameter[] paramsList = createParamList(p);
            DBHelper.Execute(Metrics.UPDATE_METRICS, paramsList);
        }

        public void Delete(string p) {
            DBHelper.Execute(Metrics.DELETE_METRICS, DBHelper.mp("ID", p));
        }

        private OracleParameter[] createParamList(Metrics p) {
            int cntr = 0;

            OracleParameter[] paramsList = new OracleParameter[20];
            paramsList[cntr++] = DBHelper.mp("ID", p.Id);
            paramsList[cntr++] = DBHelper.mp("YEAR", p.Year);
            paramsList[cntr++] = DBHelper.mp("METRICS_ID", p.MetricsId);
            paramsList[cntr++] = DBHelper.mp("CATEGORY", p.Category);
            paramsList[cntr++] = DBHelper.mp("FIELD", p.Field);
            paramsList[cntr++] = DBHelper.mp("JAN", p.Jan);
            paramsList[cntr++] = DBHelper.mp("FEB", p.Feb);
            paramsList[cntr++] = DBHelper.mp("MAR", p.Mar);
            paramsList[cntr++] = DBHelper.mp("APR", p.Apr);
            paramsList[cntr++] = DBHelper.mp("MAY", p.May);
            paramsList[cntr++] = DBHelper.mp("JUN", p.Jun);
            paramsList[cntr++] = DBHelper.mp("JUL", p.Jul);
            paramsList[cntr++] = DBHelper.mp("AUG", p.Aug);
            paramsList[cntr++] = DBHelper.mp("SEP", p.Sep);
            paramsList[cntr++] = DBHelper.mp("OCT", p.Oct);
            paramsList[cntr++] = DBHelper.mp("NOV", p.Nov);
            paramsList[cntr++] = DBHelper.mp("DEC", p.Dec);
            paramsList[cntr++] = DBHelper.mp("YTD", p.Ytd);
            paramsList[cntr++] = DBHelper.mp("AVE", p.Ave);
            paramsList[cntr++] = DBHelper.mp("CALC", p.Calc);
            return paramsList;
        }
     }
}
