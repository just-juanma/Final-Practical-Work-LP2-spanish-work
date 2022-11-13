using csvfiles;
using System.DirectoryServices;

namespace tp_final;

public partial class Form1 : Form
{
    public Form1()
    {
        // Inicializaciones

        int i = 0;
        InitializeComponent();
        var csv_ = new csvfiles._csv();
        cGreedy greedy = new cGreedy();
        cProgDinamica progDin = new cProgDinamica();
        List<cPedido> pedidos = csv_.read_csv(greedy);
        progDin.ordenarPorVolumen(pedidos);

        // C_FURGON
        cFurgon furgon = new cFurgon();
        progDin.cargarPedidos(pedidos, furgon);
        greedy.ordenarPedidos(furgon.pedidos);
        furgon.repartirPedidos(pedidos);

        // C_FURGONETA
        cFurgoneta furgoneta = new cFurgoneta();
        progDin.cargarPedidos(pedidos, furgoneta);
        greedy.ordenarPedidos(furgoneta.pedidos);
        furgoneta.repartirPedidos(pedidos);


        // C_CAMIONETA FIXEAR GREEDY
        cCamioneta camioneta = new cCamioneta();
        while (pedidos.Count != 0 && i < 3)
        {
            progDin.cargarPedidos(pedidos, camioneta);
            greedy.ordenarPedidos(camioneta.pedidos);
            camioneta.repartirPedidos(pedidos);
            i++;
        }
    }

    // Windows Forms

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
