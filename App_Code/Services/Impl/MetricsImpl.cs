using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agile.Domain;
using Agile.DAO;
using Agile.Services.Interface;

namespace Agile.Services.Impl {
    public class MetricsImpl : MetricsService {
        public MetricsImpl() {

    }

        #region MetricsService Members

        public Metrics Select(string p) {
            MetricsDAO q = new MetricsDAO();
            return q.Select(p);
        }

        public Metrics SELECT_METRICS_BY_YEAR(string p)
        {
            MetricsDAO q = new MetricsDAO();
            return q.SELECT_METRICS_BY_YEAR(p);
        }

        public void Update(Metrics p) {
            MetricsDAO q = new MetricsDAO();
            q.Update(p);
        }

        public void Insert(Metrics p) {
            MetricsDAO q = new MetricsDAO();
            q.Insert(p);
        }

        public void Delete(string p) {
            MetricsDAO q = new MetricsDAO();
            q.Delete(p);
        }

        #endregion
    }
}
