<%@ Page Language="C#" AutoEventWireup="true" CodeFile="page3.aspx.cs" Inherits="page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Πληροφορίες Χώρας</h1>
        <br/>
        <br />
<h3>Χώρα<asp:DropDownList ID="ddplstLand" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
        </h3>
        <h3>ISO Code <asp:Label ID="lblIso" runat="server" Text=""></asp:Label>
        </h3>
        <h3>Πρωτεύουσα 
            <asp:Label ID="lblCapital" runat="server" Text=""></asp:Label>
        </h3>
        <p>
            <asp:Image ID="Image1" runat="server" />
        </p>
      <p>  Κωδικός Διεθνούς κλήσης<asp:Label ID="lblPhone" runat="server" Text=""></asp:Label>
          </p>
        <p>  
            <asp:Button ID="Button1" runat="server" Text="Κλήση" OnClick="Button1_Click" />
          <br /></p>


    </div>
    </form>
</body>
</html>
