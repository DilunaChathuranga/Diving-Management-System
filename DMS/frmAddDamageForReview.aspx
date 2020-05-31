<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmAddDamageForReview.aspx.cs" Inherits="DMS.frmAddDamageForReview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
       Add Damages
        <small>Add</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Damage </a></li>
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
                <label>Item Name</label>
                 <asp:DropDownList ID="dropService" runat="server" class="form-control select2" data-placeholder="Select An Item" AutoPostBack="True" OnSelectedIndexChanged="dropService_SelectedIndexChanged"></asp:DropDownList>
               <%-- <asp:TextBox type="text" class="form-control" id="nameid" placeholder="Enter Employee Name" runat="server"></asp:TextBox>--%>
              </div>
              <!-- /.form-group -->
              <div class="form-group">
                <label>Discription</label>
                <asp:TextBox type="text" class="form-control" id="Discriptionid" placeholder="Enter Discription" runat="server"></asp:TextBox>
              </div>
                  <div class="form-group">
                <label id="Approvedidd" runat="server">Finance Approved</label>
                <asp:TextBox type="text" class="form-control" id="Approvedid" placeholder="Give Approve" runat="server"></asp:TextBox>
              </div>
              <!-- /.form-group -->
              <div class="form-group">
                <label id="Repairedidd" runat="server">Workshop Repaired</label>
               <asp:TextBox type="text" class="form-control" id="Repairedid" placeholder="Enter Status" runat="server"></asp:TextBox>
              </div>
              
              <!-- /.form-group -->
              <div class="box-footer">
             
              <asp:Button type="submit" class="btn btn-primary" runat="server" ID="Button1" Text="Submit" OnClick="btnsubmitDamage_Click"/>
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
                  <th>Dmaged Item Name</th>
                  <th>Discription</th>
                 
                    <th>Approed Or Not</th>
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
