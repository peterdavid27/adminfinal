<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <!-- Standard Meta -->
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0">

    <!-- Site Properties -->
    <title>Inicio de sesion</title>

    <!-- Stylesheets -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">


<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script></head>
<body>
    <form id="form1" runat="server">
          <div class="container">
            <div class="row">
                <div class="col-12 col-md-6 col-lg-6">
                    
                     <asp:Image ID="Image2" runat="server" Height="196px" ImageUrl="~/IMG/user_icon-icons.com_66546.png" Width="205px" />
                    
                     &nbsp;<div class="form-row">
                        <div class="form-group col-md-6">
                            <label for="inputCity">Usuario</label>
                        <asp:TextBox ID="TextBox1" placeholder="usuario" CssClass="form-control" runat="server"></asp:TextBox>
                    <br />
                     <label for="inputCity">Contraseña</label>

                    <asp:TextBox ID="TextBox2" type="password" placeholder="Contraseña" CssClass="form-control" runat="server"></asp:TextBox><br />
                    <asp:Label ID="Label1" runat="server" ForeColor="#CC0000"></asp:Label>
                    <br />
                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Ingresar" OnClick="Button1_Click" />
              
                        </div>
                      
                       
                    </div>
                </div>
            </div>
        </div>
        </form>
</body>

</html>
