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
        cGreedy greedy = new cGreedy();

        cFurgon furgon = new cFurgon();
        cFurgoneta furgoneta = new cFurgoneta();
        cCamioneta camioneta = new cCamioneta();

        // cargar en vehiculos

        // GREEDY
        // armar recorrido camioneta con las listas de pedidos de la clase cVehiculo preparados
        // camioneta.insertarRecorrido(armarRecorrido(camioneta.pedidos));
        // y asi con furgoneta y furgon (para camioneta tener en cuenta de hacerlo hasta 4 veces mas -> while(pedidos.Any() == true && i < 3)...
        List<cPedido> ordenPedidos = new List<cPedido>();
        int i = 0;
        while(pedidos.Any() && i < 3)
        {
            ordenPedidos = greedy.ordenarPedidos(camioneta.pedidos);
        }
        ordenPedidos = greedy.ordenarPedidos(furgon.pedidos);
        ordenPedidos = greedy.ordenarPedidos(furgoneta.pedidos);
        



    }

}
