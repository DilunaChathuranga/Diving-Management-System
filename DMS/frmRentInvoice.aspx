<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmRentInvoice.aspx.cs" Inherits="DMS.frmRentInvoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <!-- Main content -->
    <section class="invoice">
      <!-- title row -->
      <div class="row">
        <div class="col-xs-12">
          <h2 class="page-header">
            <i class="fa fa-globe"></i> AdminLTE, Inc.
            <small class="pull-right"><%= this.Date%></small>
          </h2>
        </div>
        <!-- /.col -->
      </div>
      <!-- info row -->
      <div class="row invoice-info">
        <div class="col-sm-4 invoice-col">
          Customer Name
          <address>
            <strong><%= this.Name%></strong><br>
          
          </address>
        </div>
        <!-- /.col -->
        
        <!-- /.col -->
        <div class="row invoice-info">
           <div class="col-sm-4 invoice-col"></div>
              
        <div class="col-sm-4 invoice-col">
          <b>Invoice: <%= this.RentINumber%></b><br>
        </div>
        <!-- /.col -->
      </div>
          </div>
      <!-- /.row -->

      <!-- Table row -->
      <div class="row">
        <div class="col-xs-12 table-responsive">
          <table class="table table-striped">
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
          </table>
        </div>
        <!-- /.col -->
      </div>
      <!-- /.row -->

      <div class="row">
        <!-- accepted payments column -->
        <div class="col-xs-6">
         
        </div>
        <!-- /.col -->
        <div class="col-xs-6">
          <p class="lead">Amount Due </p>

          <div class="table-responsive">
            <table class="table">
              <tr>
                <th style="width:50%">Deposti:</th>
                <td>Rs.<%= this.DepostiAmount%></td>
              </tr>
              <tr>
                <th>Daliy Rate</th>
                <td>Rs.<%= this.RateAmount%></td>
              </tr>
              
              <tr>
                <th>Total:</th>
                <td>Rs.<%= this.Total%></td>
              </tr>
            </table>
          </div>
        </div>
        <!-- /.col -->
      </div>
      <!-- /.row -->

      <!-- this row will not appear when printing -->
     
    </section>
    <!-- /.content -->
    <div class="clearfix"></div>
  </div>
  <!-- /.content-wrapper -->
</asp:Content>
