<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <h3> Conversion to Upper Case </h3>
    
   
     <form id="form1" runat="server">
         <div>
         
            <asp:TextBox ID="TextBox1" runat="server" style="width:224px">
            </asp:TextBox>
            
            <br />
            <br />
            
            <asp:Button ID="Button1" runat="server" Text="Enter..." style="width:85px" onclick="Button1_Click" />
            <hr />
            
            <h3> Results: </h3>
            <span runat="server" id="changed_text" />
            
         </div>
            <div>
            <asp:Label ID="lblmessage" runat="server" >
            
            </asp:Label>
            
            <br />
            <br />
            <br />
            
            <asp:Button ID="btnclick" runat="server" Text="Click" onclick="btnclick_Click" />
         </div>
         <br />
         <div>
             Enter your name:
             <br />
             <asp:TextBox ID ="txtbox1" runat ="server"></asp:TextBox>
             <asp:Button ID ="btn1" runat ="server" onclick ="Button2_Click" Text ="Submit"/>
             <br />
             <asp:Label ID ="lbl1" runat ="server"></asp:Label>
         </div>
         <br />
         <br />
         <hr />
         <br />
         <br />
         <div class ="styling">
             <div class ="menu">
                 <ul>

                     <li><a href ="#">Home</a></li>
                     <li><a href ="#">Projects</a></li>
                     <li><a href ="#">Notifications</a></li>
                     <li style ="width:250px"><a href ="Registration.aspx">Create Account</a></li>

                 </ul>
             </div>
         </div>
      </form>
    
    
       
</body>
</html>
