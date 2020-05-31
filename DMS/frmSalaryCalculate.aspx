<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmSalaryCalculate.aspx.cs" Inherits="DMS.frmSalaryCalculate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Salary Management 
        <small>Add</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Salary </a></li>
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
                <label>Select Employee Name</label>
               <asp:TextBox type="text" class="form-control" id="nameid" placeholder="Enter Employee Name" runat="server"></asp:TextBox>
                 

                <asp:DropDownList ID="dropService" runat="server" class="form-control select2" data-placeholder="Select Employee Name" AutoPostBack="True" OnSelectedIndexChanged="dropService_SelectedIndexChanged"></asp:DropDownList>
              </div>
              <!-- /.form-group -->
              <div class="form-group">
                <label>Employee Basic Salary</label>
                <asp:TextBox type="text" class="form-control" id="Basicsalid" placeholder="Enter Basic Salary" runat="server"></asp:TextBox>
              </div>
                  <div class="form-group">
                <label>Employee OT Hours</label>
                <asp:TextBox type="text" class="form-control" id="OTid" placeholder="Enter OT Hours" runat="server"></asp:TextBox>
              </div>
              <!-- /.form-group -->
              <div class="form-group">
                <label>Employee Bonous</label>
               <asp:TextBox type="text" class="form-control" id="Bonousid" placeholder="Enter Bonous" runat="server"></asp:TextBox>
              </div>
              
              <!-- /.form-group -->
                <!-- /.form-group -->
              <div class="form-group">
                <label>Employee Net Salary</label>
               <asp:TextBox type="text" class="form-control" id="netsalid" placeholder="Enter Net Salary" runat="server"></asp:TextBox>
              </div>
              
              <!-- /.form-group -->
              <div class="box-footer">
             <asp:Button type="submit" class="btn btn-primary" runat="server" ID="btnupdate" Text="Update" OnClick="btnupdate_Click"  />
              
              <asp:Button type="submit" class="btn btn-primary" runat="server" ID="Button1" Text="Submit" OnClick="btnsubmitEmployee_Click1"  />
              </div>
              <!-- /.form-group -->
            </div>
            <!-- /.col -->
            <div class="col-md-6">
             
              <div class="form-group">
                <label>Customer Satisfaction</label>
                <asp:CheckBox ID="CheckBox1" Class="flat-red" value="myvalue" runat="server" />
              </div>
                <div class="form-group">
                <img src="docs/checkbox.jpg" height="20%" width="20%" />
              </div>
                <div class="box-footer">
             
              <asp:Button type="submit" class="btn btn-primary" runat="server" ID="Button2" Text="Calculate Salary" OnClick="btnsubmitEmployee_Click2"  />
                    
              </div>
              </div>
            </div>
            <!-- /.col -->
          </div>
          <!-- /.row -->
        </div>
        <!-- /.box-body -->
       </section>
    </section>
        
    </div>
</asp:Content>