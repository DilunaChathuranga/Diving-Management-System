<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmService.aspx.cs" Inherits="DMS.frmService" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Service Management 
        <small>Add</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Service </a></li>
        <li class="active">Add>
      </ol>
        <section class="content">
                <!-- SELECT2 EXAMPLE -->
      <div class="box box-default">
        <div class="box-header with-border">
          <h3 class="box-title">Add New Servie</h3>

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
                <label>Service Code</label>
                  <asp:TextBox type="text" class="form-control" id="serviceCode" placeholder="Enter Service Name" runat="server"></asp:TextBox>
                
              </div>
              <div class="form-group">
                <label>Service Name</label>
                  <asp:TextBox type="text" class="form-control" id="ServiceName" placeholder="Enter Service Name" runat="server"></asp:TextBox>
                
              </div>
              <!-- /.form-group -->
              <div class="form-group">
                <label>Service Duration</label>
                <asp:TextBox type="text" class="form-control" id="ServiceDuration" placeholder="Enter Service Duration" runat="server"></asp:TextBox>
               
              </div>
                  
              <!-- /.form-group -->
            
            </div>
            <!-- /.col -->
            <div class="col-md-6">
              
              
                <div class="form-group">
                <label>Description</label>
                    <asp:TextBox type="text" class="form-control" id="Description" placeholder="Enter Description" runat="server"></asp:TextBox>
         
              </div>
              <!-- /.form-group -->
              <div class="form-group">
                <label>Price Per Hour</label>
                     
                   <asp:TextBox type="text" class="form-control" id="PricePerHour" placeholder="Enter Price Per Hour" runat="server"></asp:TextBox>
              </div>
            </div>
            <!-- /.col -->
          </div>
          <!-- /.row -->
        </div>
        <!-- /.box-body -->
          <div class="box-footer">
                    <asp:Button type="submit" class="btn btn-primary" runat="server" ID="btnsubmitService" Text="Submit" OnClick="btnsubmitService_Click"   />
                    <asp:Button type="submit" class="btn btn-primary" runat="server" ID="btnupdate" Text="Update" OnClick="btnupdate_Click"  />
                    <asp:Button type="submit" class="btn btn-danger" runat="server" ID="btndelete" Text="Delete" OnClick="btndelete_Click"  />
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
                  <th>Service Code</th>
                  <th>Service Name</th>
                  <th>Service Duration</th>
                  <th>Price Per Hour</th>
                  <th>Description</th>  
                  <th>View</th>
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
