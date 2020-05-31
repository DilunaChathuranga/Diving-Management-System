<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmReturn.aspx.cs" Inherits="DMS.frmReturn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Return Item Management 
        <small>Return Item</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Rent </a></li>
        <li class="active">Add>
      </ol>
        <section class="content">
                <!-- SELECT2 EXAMPLE -->
      <div class="box box-default">
        <div class="box-header with-border">
          <h3 class="box-title">Return Item </h3>

          <div class="box-tools pull-right">
            <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
            <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-remove"></i></button>
          </div>
        </div>
        <!-- /.box-header -->
        <div class="box-body">
          <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                <label>Select Rent Id</label>              
                    <asp:DropDownList ID="dropRent" runat="server" class="form-control select2" data-placeholder="Select a Rent ID " AutoPostBack="True" OnSelectedIndexChanged="dropRent_SelectedIndexChanged" >

                    </asp:DropDownList>
              </div>
              <div class="form-group">
                <label>Customer Name</label>
                <asp:TextBox type="text" class="form-control" id="CustomerName" placeholder="Enter Quentity" runat="server" disabled></asp:TextBox>             
              </div>
                <div class="form-group">
                <label>Item Name</label>
               <asp:TextBox type="text" class="form-control" id="ItemName" placeholder="Enter Quentity" runat="server" disabled></asp:TextBox>
              </div>
                <div class="form-group">
                <label>Quentity</label>
                 <asp:TextBox type="text" class="form-control" id="Quentity" placeholder="Enter Quentity" runat="server" disabled></asp:TextBox>
              </div>
               
                
            </div>
            <!-- /.col -->
            <div class="col-md-6">
                 <div class="form-group">
                <label>Deposit</label>
                    <asp:TextBox type="text" class="form-control" id="Deposit" placeholder="Enter Deposit" runat="server" disabled></asp:TextBox>
              </div>   
                <div class="form-group">
                <label>Additional amount</label>
                   <asp:TextBox type="text" class="form-control" id="AdditionAmount" placeholder="0.00" runat="server"  ></asp:TextBox>
                     <asp:Button type="submit" class="btn btn-primary" runat="server" ID="Cal" Text="Cal Refund" OnClick="Cal_Click" />
              </div>    
                 <div class="form-group">
                <label>Refund amount</label>
                   <asp:TextBox type="text" class="form-control" id="refundAmount" placeholder="0.00" runat="server"  ></asp:TextBox>
              </div>                             
            </div>
            <!-- /.col -->
          </div>
          <!-- /.row -->
        </div>
        <!-- /.box-body -->
          <div class="box-footer">
                    <asp:Button type="submit" class="btn btn-primary" runat="server" ID="btnsave" Text="Submit" OnClick="btnsave_Click"/>
                              
              </div>
      </div>
       </section>
        <section class="content">
        <div class="row">
        <div class="col-xs-12">
           <div class="box">
            <div class="box-header">
              <h3 class="box-title"></h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
              <table id="example1" class="table table-bordered table-striped">
                <thead>
                <tr>
                  <th>Item Name</th>
                  <th>Quentity</th>
                  
                </tr>
                </thead>
                <tbody>
                <span id="divInnerHtml" runat="server"></span>
                </tbody>
              </table>
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->
        </div>
        <!-- /.col -->
      </div>
      <!-- /.row -->
    </section>
    </section>
    
    </div>
</asp:Content>
