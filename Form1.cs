using csvfiles;
using Microsoft.VisualBasic;
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
        greedy = new cGreedy();
        progDin = new cProgDinamica();
        pedidos = csv_.read_csv(greedy);
        progDin.ordenarPorVolumen(pedidos);
        furgon = new cFurgon();
        furgoneta = new cFurgoneta();
        camioneta = new cCamioneta();

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
        switch (contBoton)
        {
            case 0:
                progDin.cargarPedidos(pedidos, furgon);
                txtBoxID.Text = Convert.ToString(furgon.ID);
                txtBoxVolumen.Text = Convert.ToString(furgon.volumenMax);
                txtBoxPeso.Text = Convert.ToString(furgon.pesoMax);
                txtBoxVolPedido.Text = Convert.ToString(furgon.volumenActual);
                txtBoxPesoPedido.Text = Convert.ToString(furgon.pesoActual);
                foreach (var pedido in furgon.pedidos)
                {
                    ListViewItem list = new ListViewItem(Convert.ToString(pedido.ID));
                    list.SubItems.Add(Convert.ToString(pedido.volumen));
                    list.SubItems.Add(Convert.ToString(pedido.peso));
                    list.SubItems.Add(Convert.ToString(pedido.prioridad));
                    list.SubItems.Add(pedido.barrio);
                    listPedidos.Items.Add(list);
                }
                break;
            case 1:
                listPedidos.Items.Clear();
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
                    list.SubItems.Add(pedido.barrio);
                    listPedidos.Items.Add(list);
                }
                break;
            default:
                listPedidos.Items.Clear();
                progDin.cargarPedidos(pedidos, camioneta);
                txtBoxID.Text = Convert.ToString(camioneta.ID);
                txtBoxVolumen.Text = Convert.ToString(camioneta.volumenMax);
                txtBoxPeso.Text = Convert.ToString(camioneta.pesoMax);
                txtBoxVolPedido.Text = Convert.ToString(camioneta.volumenActual);
                txtBoxPesoPedido.Text = Convert.ToString(camioneta.pesoActual);
                foreach (var pedido in camioneta.pedidos)
                {
                    ListViewItem list = new ListViewItem(Convert.ToString(pedido.ID));
                    list.SubItems.Add(Convert.ToString(pedido.volumen));
                    list.SubItems.Add(Convert.ToString(pedido.peso));
                    list.SubItems.Add(Convert.ToString(pedido.prioridad));
                    list.SubItems.Add(pedido.barrio);
                    listPedidos.Items.Add(list);
                }
                break;
        }
        btnGreedy.Enabled = true;
        btnSiguiente.Enabled = false;
        btnDinamica.Enabled = false;
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnSiguiente_Click(object sender, EventArgs e)
    {
        label1.Focus(); // para que no se seleccione ningun textbox por default
        contBoton++;
        listPedidos.Items.Clear();
        listRecorrrido.Items.Clear();
        txtBoxID.Clear();
        txtBoxVolumen.Clear();
        txtBoxPeso.Clear();
        txtBoxVolPedido.Clear();
        txtBoxPesoPedido.Clear();
        btnDinamica.Enabled = true;
        btnSiguiente.Enabled = false;
    }

    private void d_Click(object sender, EventArgs e)
    {
        List<cPedido> listaOrdenada;
        switch (contBoton)
        {
            case 0:
                listaOrdenada = greedy.ordenarPedidos(furgon.pedidos);
                foreach (var pedido in listaOrdenada)
                {
                    ListViewItem list = new ListViewItem(pedido.barrio);
                    listRecorrrido.Items.Add(list);
                }
                btnSiguiente.Enabled = true;
                furgon.repartirPedidos(pedidos);
                break;
            case 1:
                listaOrdenada = greedy.ordenarPedidos(furgoneta.pedidos);
                foreach (var pedido in listaOrdenada)
                {
                    ListViewItem list = new ListViewItem(pedido.barrio);
                    listRecorrrido.Items.Add(list);
                }
                btnSiguiente.Enabled = true;
                furgoneta.repartirPedidos(pedidos);
                break;
            default:
                listaOrdenada = greedy.ordenarPedidos(camioneta.pedidos);
                foreach (var pedido in listaOrdenada)
                {
                    ListViewItem list = new ListViewItem(pedido.barrio);
                    listRecorrrido.Items.Add(list);
                }
                btnSiguiente.Enabled = true;
                if (contBoton == 4)
                    btnSiguiente.Enabled = false;
                camioneta.repartirPedidos(pedidos);
                break;
        }
        btnGreedy.Enabled = false;
        btnDinamica.Enabled = false;
    }
}

