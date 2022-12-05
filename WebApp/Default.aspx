<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>My App</title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            Nome:<asp:TextBox ID="nome" runat="server" Text=""></asp:TextBox><br />
            Cognome:<asp:TextBox ID="cognome" runat="server" Text=""></asp:TextBox><br />
            Le Sale:
            <asp:DropDownList ID="dropdownList" runat="server" Width="200px">
                <asp:ListItem Value="1" Text="SALA NORD"/>
                <asp:ListItem Value="2" Text="SALA SUD"/>
                 <asp:ListItem Value="3" Text="SALA EST"/>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="prenota" runat="server" Text="prenota" OnClick="PrenotazioneSala"></asp:Button>
            <br />
            <br />
            
             <div class="content">
                <h4>Resoconto bilietti:</h4>

                 <div class="content_salaNord">
                     <p>Biglietti Venduti in sala Nord:
                         <asp:Label ID="bigiettiVendutiSalaNord" runat="server" Text=""></asp:Label>
                     </p>
                 </div>

                  <div class="content_salaSud">
                       <p>Biglietti Venduti in sala Sud:
                            <asp:Label ID="bigiettiVendutiSalaSud" runat="server" Text=""></asp:Label>
                       </p>
                 </div>
                  <div class="content_salaEst">
                       <p>Biglietti Venduti in sala Est:
                           <asp:Label ID="bigiettiVendutiSalaEst" runat="server" Text=""></asp:Label> 
                       </p>
                 </div>









             </div>
            
            
        </div>
    </form>
</body>
</html>
