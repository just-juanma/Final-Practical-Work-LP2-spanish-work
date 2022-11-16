using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Collections.Generic;
using tp_final.Properties;
using tp_final;
using System.Runtime;

namespace csvfiles {
    public class _csv {
        /// <summary>
        /// Permite leer los pedidos del archivo "data.csv"
        /// </summary>
        /// <param name="greedy">Mediante la template del algoritmo mismo, la voy completando desde el archivo</param>
        /// <returns></returns>
        public List<cPedido> read_csv(cGreedy greedy) {
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
                        peso = csv.GetField<int>("peso"),
                        prioridad = csv.GetField<int>("prioridad"),
                        barrio = csv.GetField<string>("barrio")
                    };
                    record.ID = cPedido.maxID++;
                    if(csv.GetField<string>("template") != "")
                    {
                        greedy.template.Add(csv.GetField<string>("template"));
                    }
                    record.volumen = record.ancho * record.alto * record.largo;
                    records.Add(record);
                }
                return records;
            }
        }
    }

};
