<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmAddEmployee.aspx.cs" Inherits="DMS.frmAddEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Employee Management 
        <small>Add</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Employee </a></li>
        <li class="active">Add>
      </ol>
        <section class="content">
                <!-- SELECT2 EXAMPLE -->
      <div class="box box-default">
        <div class="box-header with-border">
          <h3 class="box-title"></h3>

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
                <label>Employee Name</label>
                <asp:TextBox type="text" class="form-control" id="nameid" placeholder="Enter Employee Name" runat="server"></asp:TextBox>
              </div>
              <!-- /.form-group -->
              <div class="form-group">
                <label>Employee Address</label>
                <asp:TextBox type="text" class="form-control" id="addressid" placeholder="Enter Address" runat="server"></asp:TextBox>
              </div>
                  <div class="form-group">
                <label>Employee Job Type</label>
                <asp:TextBox type="text" class="form-control" id="jobtyid" placeholder="Enter Job Type" runat="server"></asp:TextBox>
              </div>
              <!-- /.form-group -->
              <div class="form-group">
                <label>Employee Basic Salary</label>
               <asp:TextBox type="text" class="form-control" id="bsalid" placeholder="Enter Basic Salary" runat="server"></asp:TextBox>
              </div>
              
              <!-- /.form-group -->
              <div class="box-footer">
             
              <asp:Button type="submit" class="btn btn-primary" runat="server" ID="Button1" Text="Submit" OnClick="btnsubmitEmployee_Click"/>
              <asp:Button type="submit" class="btn btn-primary" runat="server" ID="btnupdate" Text="Update" OnClick="btnupdate_Click"/>
              <asp:Button type="submit" class="btn btn-danger" runat="server" ID="btndelete" Text="Delete" OnClick="btndelete_Click"/>
              </div>
              <!-- /.form-group -->
            </div>
            <!-- /.col -->
            <div class="col-md-6">
             
          
              </div>
              <!-- /.form-group -->
            </div>
            <!-- /.col -->
          </div>
          <!-- /.row -->
        </div>
        <!-- /.box-body -->
          
      </div>
       </section>
    </section>
        
    </div>
</asp:Content>
