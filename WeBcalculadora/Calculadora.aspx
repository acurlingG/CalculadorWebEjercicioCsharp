<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="WeBcalculadora.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Calculadora</title>
    <link href="css/Estilo1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="disenodemarco"> 
        <div>
            <h1>Calculadora</h1>
            <br />
           
            <br />
            <asp:Label ID="Label1" runat="server" Text="Numero 1:"></asp:Label>
            <asp:TextBox ID="tvalor1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Numero 2:"></asp:Label>
            <asp:TextBox ID="tvalor2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="bcalcular" runat="server" Text="Calcular" />

        </div>

        
        <div >
             <asp:Label ID="lresultado" runat="server" Font-Size="XX-Large" ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="b1" class="button button2" Text="1" runat="server" OnClick="b1_Click" />
            <asp:Button ID="b2" class="button button2" Text="2" runat="server" OnClick="b2_Click" />
            <asp:Button ID="b3" class="button button2" Text="3" runat="server" OnClick="b3_Click" />

        </div>
         
        <div >
            <asp:Button ID="Button4" class="button button2" Text="4" runat="server"  />
            <asp:Button ID="Button5" class="button button2" Text="5" runat="server"  />
            <asp:Button ID="Button6" class="button button2" Text="6" runat="server" />
        </div>
       
           
        <div>
            <asp:Button ID="bsuma" class="button button3" Text="+" runat="server" OnClick="bsuma_Click" />
            <asp:Button ID="bresta"  class="button button3" Text="-" runat="server" OnClick="bresta_Click" />
            <asp:Button ID="bresultado" class="button button4" Text="=" runat="server" OnClick="bresultado_Click" />
            <asp:Button ID="bclear" class="button button5" Text="C" runat="server" OnClick="bclear_Click" />

        </div>
            </div>
        <div>
            <asp:RadioButton ID="rsuma" Text="Sumar" GroupName="op" runat="server"></asp:RadioButton>
        </div>
        <asp:RadioButton ID="rresta" Text="Resta" GroupName="op" runat="server"></asp:RadioButton></div>
      
        <div>
            <asp:CheckBox ID="Csuma" Text="Sumar" runat="server" />
            <br />
            <asp:CheckBox ID="Cresta" Text="Restar" runat="server" />

        </div>

        <div>
            <asp:DropDownList ID="Dlista" runat="server">

                <asp:ListItem>Suma</asp:ListItem>
                <asp:ListItem>Resta</asp:ListItem>
                <asp:ListItem>Multiplicacion</asp:ListItem>
                <asp:ListItem>Division</asp:ListItem>
            </asp:DropDownList>


        </div>

        <div>
            <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple">

                <asp:ListItem>Suma</asp:ListItem>
                <asp:ListItem>Resta</asp:ListItem>
                <asp:ListItem>Multiplicacion</asp:ListItem>
                <asp:ListItem>Division</asp:ListItem>
            </asp:ListBox>
        </div>


    </form>
</body>
</html>
