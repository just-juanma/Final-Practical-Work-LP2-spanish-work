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

        // C_FURGON
        cFurgon furgon = new cFurgon();
        progDin.cargarPedidos(pedidos, furgon);
        greedy.ordenarPedidos(furgon.pedidos);
        furgon.repartirPedidos();

        // C_FURGONETA
        cFurgoneta furgoneta = new cFurgoneta();
        progDin.cargarPedidos(pedidos, furgoneta);
        greedy.ordenarPedidos(furgoneta.pedidos);
        furgoneta.repartirPedidos();


        // C_CAMIONETA FIXEAR GREEDY
        cCamioneta camioneta = new cCamioneta();
        progDin.cargarPedidos(pedidos, camioneta);
        while (camioneta.pedidos.Count != 0 && i < 2)
        {
            greedy.ordenarPedidos(camioneta.pedidos);
            camioneta.repartirPedidos();
            progDin.cargarPedidos(pedidos, camioneta);
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
