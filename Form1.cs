using csvfiles;
using System.DirectoryServices;

namespace tp_final;

public partial class Form1 : Form
{
    public cGreedy greedy;
    public cProgDinamica progDin;
    public List<cPedido> pedidos;
    public cFurgon furgon;
    public cFurgoneta furgoneta;
    public cCamioneta camioneta;
    public int contBoton = 0;
    public Form1()
    {
        // Inicializaciones

        InitializeComponent();
        var csv_ = new csvfiles._csv();
        int i = 0;
        greedy = new cGreedy();
        progDin = new cProgDinamica();
        pedidos = csv_.read_csv(greedy);
        progDin.ordenarPorVolumen(pedidos);
        furgon = new cFurgon();
        camioneta = new cCamioneta();
        furgoneta = new cFurgoneta();

        //// C_FURGON
        //progDin.cargarPedidos(pedidos, furgon);
        //greedy.ordenarPedidos(furgon.pedidos);
        //furgon.repartirPedidos(pedidos);

        //// C_FURGONETA
        //progDin.cargarPedidos(pedidos, furgoneta);
        //greedy.ordenarPedidos(furgoneta.pedidos);
        //furgoneta.repartirPedidos(pedidos);


        //// C_CAMIONETA FIXEAR GREEDY
        //while (pedidos.Count != 0 && i < 3)
        //{
        //    progDin.cargarPedidos(pedidos, camioneta);
        //    greedy.ordenarPedidos(camioneta.pedidos);
        //    camioneta.repartirPedidos(pedidos);
        //    i++;
        //}
        btnGreedy.Enabled = false;
        btnSiguiente.Enabled = false;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        txtBoxID.Clear();
        txtBoxVolumen.Clear();
        txtBoxPeso.Clear();
        txtBoxVolPedido.Clear();
        txtBoxPesoPedido.Clear();
        label1.Focus(); // para que no se seleccione ningun textbox por default
        
        switch(contBoton)
        {
            case 0:
                progDin.cargarPedidos(pedidos, furgon);
                txtBoxID.Text = Convert.ToString(furgon.ID);
                txtBoxVolumen.Text = Convert.ToString(furgon.volumenMax);
                txtBoxPeso.Text = Convert.ToString(furgon.pesoMax);
                txtBoxVolPedido.Text = Convert.ToString(furgon.volumenActual);
                txtBoxPesoPedido.Text = Convert.ToString(furgon.pesoActual);
                foreach(var pedido in furgon.pedidos)
                {
                    ListViewItem list = new ListViewItem(Convert.ToString(pedido.ID));
                    list.SubItems.Add(Convert.ToString(pedido.volumen));
                    list.SubItems.Add(Convert.ToString(pedido.peso));
                    list.SubItems.Add(Convert.ToString(pedido.prioridad));
                    listPedidos.Items.Add(list);
                }
                btnDinamica.Enabled = false;
                btnGreedy.Enabled = false;
                btnSiguiente.Enabled = true;
                break;
            case 1:
                progDin.cargarPedidos(pedidos, furgoneta);
                txtBoxID.Text = Convert.ToString(furgoneta.ID);
                txtBoxVolumen.Text = Convert.ToString(furgoneta.volumenMax);
                txtBoxPeso.Text = Convert.ToString(furgoneta.pesoMax);
                txtBoxVolPedido.Text = Convert.ToString(furgoneta.volumenActual);
                txtBoxPesoPedido.Text = Convert.ToString(furgoneta.pesoActual);
                foreach (var pedido in furgoneta.pedidos)
                {
                    ListViewItem list = new ListViewItem(Convert.ToString(pedido.ID));
                    list.SubItems.Add(Convert.ToString(pedido.volumen));
                    list.SubItems.Add(Convert.ToString(pedido.peso));
                    list.SubItems.Add(Convert.ToString(pedido.prioridad));
                    listPedidos.Items.Add(list);
                }
                btnDinamica.Enabled = false;
                btnGreedy.Enabled = false;
                btnSiguiente.Enabled = true;
                break;

        }
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnSiguiente_Click(object sender, EventArgs e)
    {
        contBoton++;
        button1_Click(sender, e);
    }

    private void d_Click(object sender, EventArgs e)
    {

    }
}
