using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace Agile.Domain
{
    public class Metrics {

        private string _id;
        private string _year;
        private string _metricsId;
        private string _category;
        private string _field;
        private string _jan;
        private string _feb;
        private string _mar;
        private string _apr;
        private string _may;
        private string _jun;
        private string _jul;
        private string _aug;
        private string _sep;
        private string _oct;
        private string _nov;
        private string _dec;
        private string _ytd;
        private string _ave;
        private string _calc;

        public Metrics() {

        }

        public string Id { get { return _id; } set { _id = value; } }
        public string Year { get { return _year; } set { _year = value; } }
        public string MetricsId { get { return _metricsId; } set { _metricsId = value; } }
        public string Category { get { return _category; } set { _category = value; } }
        public string Field { get { return _field; } set { _field = value; } }
        public string Jan { get { return _jan; } set { _jan = value; } }
        public string Feb { get { return _feb; } set { _feb = value; } }
        public string Mar { get { return _mar; } set { _mar = value; } }
        public string Apr { get { return _apr; } set { _apr = value; } }
        public string May { get { return _may; } set { _may = value; } }
        public string Jun { get { return _jun; } set { _jun = value; } }
        public string Jul { get { return _jul; } set { _jul = value; } }
        public string Aug { get { return _aug; } set { _aug = value; } }
        public string Sep { get { return _sep; } set { _sep = value; } }
        public string Oct { get { return _oct; } set { _oct = value; } }
        public string Nov { get { return _nov; } set { _nov = value; } }
        public string Dec { get { return _dec; } set { _dec = value; } }
        public string Ytd { get { return _ytd; } set { _ytd = value; } }
        public string Ave { get { return _ave; } set { _ave = value; } }
        public string Calc { get { return _calc; } set { _calc = value; } }

        #region SQL
        public const string SELECT_METRICS =
            "SELECT ID, YEAR, METRICS_ID, CATEGORY, FIELD, JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC, YTD, AVE, CALC FROM METRICS WHERE ID = :ID";
        public const string SELECT_METRICS_BY_YEAR =
          "SELECT ID, YEAR, METRICS_ID, CATEGORY, FIELD, JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC, YTD, AVE, CALC FROM METRICS WHERE YEAR = :YEAR";
        public const string INSERT_METRICS =
            "INSERT INTO METRICS(ID, YEAR, METRICS_ID, CATEGORY, FIELD, JAN, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC, YTD, AVE, CALC) VALUES (:ID, :YEAR, :METRICS_ID, :CATEGORY, :FIELD, :JAN, :FEB, :MAR, :APR, :MAY, :JUN, :JUL, :AUG, :SEP, :OCT, :NOV, :DEC, :YTD, :AVE, :CALC)";
        public const string UPDATE_METRICS =
            "UPDATE METRICS SET YEAR = :YEAR, METRICS_ID = :METRICS_ID, CATEGORY = :CATEGORY, FIELD = :FIELD, JAN = :JAN, FEB = :FEB, MAR = :MAR, APR = :APR, MAY = :MAY, JUN = :JUN, JUL = :JUL, AUG = :AUG, SEP = :SEP, OCT = :OCT, NOV = :NOV, DEC = :DEC, YTD = :YTD, AVE = :AVE, CALC = :CALC WHERE ID = :ID";
        public const string DELETE_METRICS = 
            "DELETE FROM METRICS WHERE ID = :ID";
        public const string GET_METRICS_ID =
           "SELECT METRICS_ID_SEQ.NEXTVAL FROM DUAL";
        #endregion
    }
}
