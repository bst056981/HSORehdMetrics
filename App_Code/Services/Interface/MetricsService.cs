using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agile.Domain;

namespace Agile.Services.Interface {
    public interface MetricsService {
        Metrics Select(string p);
        Metrics SELECT_METRICS_BY_YEAR(string p);
        void Update(Metrics p);
        void Insert(Metrics p);
        void Delete(string p);
    }
}
