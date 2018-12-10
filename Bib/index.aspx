<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Bib.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" type="text/css" href="style.css"/>
    <script src="jquery.min.js"></script>
    <script src="skripta.js"></script>
    <title></title>
</head>
<body>
    <div id="naslov">
    <asp:image ID="img1" src="nub2.jpg" runat="server"  />
    <h1>Bibliografija </h1>
    <h1>Nacionalne i Univerzitetske Biblioteke </h1>
        <h1>Bosne i Hercegovine</h1>
        </div>
    <br />
    
    <form id="form1" runat="server">
  
    
    <asp:TextBox ID ="name" runat="server" placeholder="Ime autora" Height="33px" Width="300px"></asp:TextBox>
        <br />
        <asp:TextBox ID ="lname" runat="server" placeholder="Prezime autora" Height="33px" Width="300px"></asp:TextBox>
        <br />
        <asp:TextBox ID ="title" runat="server" placeholder="Naslov" Height="33px" Width="300px"></asp:TextBox>
        <br />
        <asp:TextBox ID ="name1" runat="server" placeholder="Ime drugog autora" Height="33px" Width="300px"></asp:TextBox>
        <br />
        <asp:TextBox ID ="lname1" runat="server" placeholder="Prezime drugog autora" Height="33px" Width="300px"></asp:TextBox>
        <br />
        <asp:TextBox ID ="isbn" runat="server" placeholder="ISBN broj" Height="33px" Width="300px"></asp:TextBox>
        <br />
        <asp:TextBox ID ="date" runat="server" placeholder="Godina" Height="33px" Width="300px"></asp:TextBox>
        <br />
      
       <br/>

    <asp:Button ID="btn1" runat="server" Text="Pretraži" onserverclick="Reset()"  Height="30px" Width="85px"/>
        </form>
    <br />
    <br />
    <br />
    
    <hr />
    <asp:Label ID="test10" runat="server"></asp:Label> 
    <hr />
    <p>© Haris Cehic 2018.</p>
</body>
</html>
