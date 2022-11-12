using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Collections.Generic;
using tp_final.Properties;
using tp_final;
using System.Runtime;

namespace csvfiles {
    public class _csv {
        public List<cPedido> read_csv() {
            using (var reader = new StreamReader(Resources.archivo))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)) {

                List<cPedido> records = new List<cPedido>();
                cGreedy greedyTemplate = new cGreedy();
                csv.Read();
                csv.ReadHeader();
                while(csv.Read()) {

                    cPedido record = new cPedido {
                        producto = csv.GetField<string>("producto"),
                        precio = csv.GetField<float>("precio"),
                        ancho = csv.GetField<float>("ancho"),
                        largo = csv.GetField<float>("largo"),
                        alto = csv.GetField<float>("alto"),
                        prioridad = csv.GetField<int>("prioridad"),
                        barrio = csv.GetField<string>("barrio"),
                        fecha = new DateTime(csv.GetField<int>("fecha")),
                    };
                    greedyTemplate.template.Add(csv.GetField<string>("template"));
                    record.volumen = Convert.ToInt32(record.ancho * record.alto * record.largo);
                    records.Add(record);
                }

                return records;
            }
        }
    }

};
