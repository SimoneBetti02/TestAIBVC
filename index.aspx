<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="testAIBVC.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>TEST</h1>
            <h3>dati</h3>
            <p runat="server" id="provaSQL"></p>
            <br />
            <hr />
            <br />
            <h3>Inserisci</h3>
            <input id="lblNome" type="text" placeholder="Inserisci nome" runat="server" />
            <input id="lblCognome" type="text" placeholder="Inserisci cognome" runat="server" />
            <asp:Button OnClick="BtnAdd_Click" Text="Inserisci" runat="server" />
            <br />
            <hr />
            <br />
            <h3>Test GitHub</h3>
        </div>
    </form>
</body>
</html>
