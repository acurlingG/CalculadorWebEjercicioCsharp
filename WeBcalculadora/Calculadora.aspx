<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="WeBcalculadora.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Calculadora</title>
    <style>
        body {
            background-color: #f0f8ff;
            font-family: Arial, sans-serif;
        }

        h1 {
            color: mediumpurple;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Calculadora</h1>
            <br />
            <asp:Label ID="lresultado" runat="server" Font-Size="XX-Large" ForeColor="Red"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Numero 1:"></asp:Label>
            <asp:TextBox ID="tvalor1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Numero 2:"></asp:Label>
            <asp:TextBox ID="tvalor2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="bcalcular" runat="server" Text="Calcular" OnClick="bcalcular_Click" />

        </div>
        <div>&nbsp;</div>
        <div>
            <asp:RadioButton ID="rsuma" Text="Sumar" GroupName="op" runat="server"></asp:RadioButton>
        </div>
        <asp:RadioButton ID="rresta" Text="Resta" GroupName="op" runat="server"></asp:RadioButton></div>
       </div>
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
