<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmBookService.aspx.cs" Inherits="DMS.frmBookService" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Add Customer To Service 
        <small>Add Customer To Service</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Offers </a></li>
        <li class="active">request>
      </ol>
        <section class="content">
                <!-- SELECT2 EXAMPLE -->
      <div class="box box-default">
        <div class="box-header with-border">
          <h3 class="box-title">Requesting  new service</h3>

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
                <label>Select Customer</label>
                <select runat="server" id="dropCusotmer" name="dropCustomer" class="form-control select2" data-placeholder="Select a State">
                       
                </select>
                
              </div>
            </div>
            <!-- /.col -->
            <div class="col-md-6">
              <div class="form-group">
                <label>Select Service</label>
                <select runat="server" id="dropService" name="dropService" class="form-control select2" data-placeholder="Select a State">
                       
                </select>
              </div>
              <!-- /.form-group -->
              
                <div class="form-group">
                <label>Select Offers</label>
                <select runat="server" id="dropoffers" name="dropoffers" class="form-control select2" data-placeholder="Select a State">
                       
                </select>
              </div>
             <div class="form-group">
                  <asp:Button type="submit" class="btn btn-primary" runat="server" ID="Button1" Text="Calculate Cost" OnClick="Button1_Click"  />
                <label  runat="server" id="lbltotal" >Total Cost Rs 1000.00</label>
              </div>
            </div>
            <!-- /.col -->
          <!-- /.row -->
        </div>
        <!-- /.box-body -->
          <div class="box-footer">
                    <asp:Button type="submit" class="btn btn-primary" runat="server" ID="btnsubmitoffers" Text="Submit" OnClick="btnsubmitoffers_Click"  />
               
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
                  <th>Customer Name</th>
                  <th>Service Name</th>
                  <th>Service Price</th>
                  <th>Offer Name</th> 
                 <th>Offer Price</th>
                 <th>Total</th>
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
