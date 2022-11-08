using csvfiles;
using System.DirectoryServices;

namespace tp_final;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        var csv_ = new csvfiles._csv();
        List<cPedido> Pedidos = csv_.read_csv();
        cCombustible hola = new cCombustible();
        
        
        
    }
}
