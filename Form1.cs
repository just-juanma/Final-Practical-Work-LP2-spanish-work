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
        cProgDinamica progDin = new cProgDinamica();

        cFurgon furgon = new cFurgon();
        cFurgoneta furgoneta = new cFurgoneta();
        cCamioneta camioneta = new cCamioneta();


        //// PROGRAMACION DINAMICA
        int i = 0;
        progDin.cargarPedidos(pedidos, furgon);
        progDin.cargarPedidos(pedidos, furgoneta);
        progDin.cargarPedidos(pedidos, camioneta);

        //// GREEDY
        List<cPedido> ordenPedidos = new List<cPedido>();
        ordenPedidos = greedy.ordenarPedidos(camioneta.pedidos);


        //ordenPedidos = greedy.ordenarPedidos(furgon.pedidos);
        //ordenPedidos = greedy.ordenarPedidos(furgoneta.pedidos);




    }

    

    private void button1_Click(object sender, EventArgs e)
    {
    }

    private void btnPrograma_Click(object sender, EventArgs e)
    {
        
    }

    private void btnProgDin_Click(object sender, EventArgs e)
    {

    }
}
