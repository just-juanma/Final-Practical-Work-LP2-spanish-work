using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Collections.Generic;
using tp_final.Properties;
using tp_final;

namespace csvfiles {
    public class _csv {
        public List<cPedido> read_csv() {
            using (var reader = new StreamReader(Resources.archivo))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)) {

                List<cPedido> records = new List<cPedido>();

                csv.Read();
                csv.ReadHeader();
                while(csv.Read()) {

                    cPedido record = new cPedido {
                        producto = csv.GetField<string>("producto"),
                        precio = csv.GetField<float>("precio"),
                        ancho = csv.GetField<float>("ancho"),
                        largo = csv.GetField<float>("largo"),
                        alto = csv.GetField<float>("alto"),
                        prioridad = csv.GetField<string>("prioridad"),
                        barrio = csv.GetField<string>("barrio"),
                        fecha = new DateTime(csv.GetField<int>("fecha")),
                    };
                    records.Add(record);
                }

                return records;
            }
        }
    }

};
