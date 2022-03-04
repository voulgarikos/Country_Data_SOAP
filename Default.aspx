<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
  <h1> ΑΡΙΘΜΟΜΗΧΑΝΗ</h1>
       
        <br />
    
    </div>
       <h3>Αριθμός Α:<asp:TextBox ID="tbNumA" runat="server"></asp:TextBox>
        </h3>
        <br />
        <br />
        <asp:Button ID="BtnAdd" runat="server" Text="+" OnClick="BtnAdd_Click" />
        <asp:Button ID="BtnSubstr" runat="server" Text="-" OnClick="BtnSubstr_Click" />
        <asp:Button ID="BtnMulti" runat="server" Text="*" OnClick="BtnMulti_Click" style="width: 21px" />
        <asp:Button ID="BtnDiv" runat="server" Text="/" OnClick="BtnDiv_Click" />
        <asp:Button ID="Clear" runat="server" Text="CLR" OnClick="Clear_Click" />
        <br />
        <br />
        <br /><h3>Αριθμός Β:<asp:TextBox ID="tbNumB" runat="server"></asp:TextBox>
        </h3>
        <br />
        <br />
        <h3>Αποτέλεσμα:<asp:Label ID="Label" runat="server" Text=""></asp:Label>
        </h3>
    </form>
</body>
</html>
