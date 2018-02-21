<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="repaso1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<h2>Hola Ecuador</h2>
        </div>
    	<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
		<asp:Button ID="Btn_Guardar" runat="server" OnClick="Btn_Guardar_Click" Text="Guardar" />
		<asp:Label ID="lblMensaje" runat="server" Text="Label"></asp:Label>
		<p>
			<asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
		</p>
    </form>
</body>
</html>
