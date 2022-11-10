using csvfiles;
using System.DirectoryServices;

namespace tp_final;

public partial class Form1 : Form
{
    public Form1()
    {
        // Inicializaciones

        InitializeComponent();
        var csv_ = new csvfiles._csv();
        List<cPedido> pedidos = csv_.read_csv();
        List<String> ordenPedidos = new List<String>();

        cFurgon furgon = new cFurgon();
        cFurgoneta furgoneta = new cFurgoneta();
        cCamioneta camioneta = new cCamioneta();

        // cargar en vehiculos

        // armar recorrido camioneta
        // camioneta.insertarRecorrido(armarRecorrido(camioneta.pedidos));
        // y asi con furgoneta y furgon (para camioneta tener en cuenta de hacerlo hasta 4 veces mas -> while(pedidos.Any() == true && i < 3)...

        //

        
        
    }
    static List<String> armarRecorrido(List<cPedido> pedidos)
    {
        List<string> foo = new List<string>();
        for(int i = 0; i < 53; i++)
        {
            switch (i)
            {
                // poner nombres de barrios correspondientes
                case 0:
                    foo.Add("liniers");
                    break;
                case 1:
                    foo.Add("liniers");
                    break;
                case 2:
                    foo.Add("liniers");
                    break;
                case 3:
                    foo.Add("liniers");
                    break;
                case 4:
                    foo.Add("liniers");
                    break;
                case 5:
                    foo.Add("liniers");
                    break;
                case 6:
                    foo.Add("liniers");
                    break;
                case 7:
                    foo.Add("liniers");
                    break;
                case 8:
                    foo.Add("liniers");
                    break;
                case 9:
                    foo.Add("liniers");
                    break;
                case 10:
                    foo.Add("liniers");
                    break;
                case 11:
                    foo.Add("liniers");
                    break;
                case 12:
                    foo.Add("liniers");
                    break;
                case 13:
                    foo.Add("liniers");
                    break;
                case 14:
                    foo.Add("liniers");
                    break;
                case 15:
                    foo.Add("liniers");
                    break;
                case 16:
                    foo.Add("liniers");
                    break;
                case 17:
                    foo.Add("liniers");
                    break;
                case 18:
                    foo.Add("liniers");
                    break;
                case 19:
                    foo.Add("liniers");
                    break;
                case 20:
                    foo.Add("liniers");
                    break;
                case 21:
                    foo.Add("liniers");
                    break;
                case 22:
                    foo.Add("liniers");
                    break;
                case 23:
                    foo.Add("liniers");
                    break;
                case 24:
                    foo.Add("liniers");
                    break;
                case 25:
                    foo.Add("liniers");
                    break;
                case 26:
                    foo.Add("liniers");
                    break;
                case 27:
                    foo.Add("liniers");
                    break;
                case 28:
                    foo.Add("liniers");
                    break;
                case 29:
                    foo.Add("liniers");
                    break;
                case 30:
                    foo.Add("liniers");
                    break;
                case 31:
                    foo.Add("liniers");
                    break;
                case 32:
                    foo.Add("liniers");
                    break;
                case 33:
                    foo.Add("liniers");
                    break;
                case 34:
                    foo.Add("liniers");
                    break;
                case 35:
                    foo.Add("liniers");
                    break;
                case 36:
                    foo.Add("liniers");
                    break;
                case 37:
                    foo.Add("liniers");
                    break;
                case 38:
                    foo.Add("liniers");
                    break;
                case 39:
                    foo.Add("liniers");
                    break;
                case 40:
                    foo.Add("liniers");
                    break;
                case 41:
                    foo.Add("liniers");
                    break;
                case 42:
                    foo.Add("liniers");
                    break;
                case 43:
                    foo.Add("liniers");
                    break;
            }

        }

        // realizar ordenamiento complejidad cuadratica para reordenar desde el barrio mas cercano al mas lejano

        return foo;
    }

}
