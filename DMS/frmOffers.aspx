<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmOffers.aspx.cs" Inherits="DMS.frmOffers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>DMS | Offers </title>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Offers Management 
        <small>Add</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Offers </a></li>
        <li class="active">Add>
      </ol>
        <section class="content">
                <!-- SELECT2 EXAMPLE -->
      <div class="box box-default">
        <div class="box-header with-border">
          <h3 class="box-title">Add New Offers</h3>

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
                <label>Offers Type </label>
                  <select runat="server" id="drpofferType" class="form-control select2" style="width: 100%;">
                  <option selected="selected"> Seletc Course</option>
                  <option value="course ">course</option>
                   <option value="Service ">Service</option>
                </select>
              </div>
              <div class="form-group">
                <label>Offers Name</label>
                  <asp:TextBox type="text" class="form-control" id="offersName" placeholder="Enter Offers Name" runat="server"></asp:TextBox>
                
              </div>
              <!-- /.form-group -->
              <div class="form-group">
                <label>Offer Description </label>
                <asp:TextBox type="text" class="form-control" id="offerDesc" placeholder="Enter Description" runat="server"></asp:TextBox>
               
              </div>
                  <div class="form-group">
                <label>Offers Start Date</label>
                     
                   <input type="text" class="form-control pull-right" name="start" id="datepickerstart">
              </div>
              <!-- /.form-group -->
                <div class="form-group">
                <label>Offers End Date</label>
                   <input type="text" class="form-control pull-right" name="end" id="datepickerend">
              </div>
              <!-- /.form-group -->
            </div>
            <!-- /.col -->
            <div class="col-md-6">
                <div class="form-group">
                <label>Offers ID</label>
                  <asp:TextBox type="text" class="form-control" id="offerID" placeholder="Enter Offers Name" runat="server"></asp:TextBox>
                
              </div>
                <div class="form-group">
                <label>Discount</label>
                    <asp:TextBox type="number" class="form-control" id="MimumPrice" placeholder="Enter Discount" runat="server"></asp:TextBox>
         
              </div>
              <!-- /.form-group -->
              <div class="form-group">
                <label>Price</label>
                  <asp:TextBox type="number" class="form-control" id="MaxmumPrice" placeholder="Enter  Price" runat="server"></asp:TextBox>
             
              </div>
            </div>
            <!-- /.col -->
          </div>
          <!-- /.row -->
        </div>
        <!-- /.box-body -->
          <div class="box-footer">
                    <asp:Button type="submit" class="btn btn-primary" runat="server" ID="btnsubmitoffers" Text="Submit" OnClick="Unnamed1_Click" />
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
                  <th>Offer Type</th>
                  <th>Offer Code</th>
                  <th>Offer Name</th>
                  <th>Start Date</th>
                  <th>End Date</th>
                  <th>Discount PRICE</th>
                  <th>Price </th>
                  <th>Description </th>
                    <th></th>
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
