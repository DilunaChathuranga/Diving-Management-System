<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmFinanceReport.aspx.cs" Inherits="DMS.frmFinanceReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Finance Report
        <small>Preview sample</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Charts</a></li>
        <li class="active">Morris</li>
      </ol>
    </section>

    <!-- Main content -->
    <section class="content">
            <div class="row">
        
        <!-- /.col (LEFT) -->
        <div class="col-md-6">
          <!-- LINE CHART -->
          
          <!-- /.box -->

          <!-- BAR CHART -->
          <div class="box box-success">
            <div class="box-header with-border">
              <h3 class="box-title">Service Profit</h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body chart-responsive">
              <div class="chart" id="bar-chart" style="height: 300px;"></div>
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->

        </div>
                <div class="col-md-6">
          <!-- LINE CHART -->
          
          <!-- /.box -->

          <!-- BAR CHART -->
          <div class="box box-success">
            <div class="box-header with-border">
              <h3 class="box-title">Course Profit</h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body chart-responsive">
              <div class="chart" id="bar-chart2" style="height: 300px;"></div>
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->

        </div>
        <!-- /.col (RIGHT) -->
      </div>
      <!-- /.row -->
        <section class="invoice">
     
      <div class="row">
       
        <div class="col-xs-6">
          <p class="lead">Total Profite </p>

          <div class="table-responsive">
            <table class="table">
              <tr>
                <th style="width:50%">Service Profite:</th>
                <td>Rs.<%= this.Service%></td>
              </tr>
              <tr>
                <th>Course Profite</th>
                <td>Rs.<%= this.Course%></td>
              </tr>
              
              <tr>
                <th> Profite Total:</th>
                <td>Rs.<%= this.Total%></td>
              </tr>
            </table>
          </div>
        </div>
        
      </div>
    
     
    </section>
    </section>
    <!-- /.content -->
  </div>
  <!-- /.content-wrapper -->

    <script>
  $(function () {
    "use strict";

    
    
   
    //BAR CHART
    var bar = new Morris.Bar({
      element: 'bar-chart',
      resize: true,
      data: [
           <asp:Repeater ID="rptdata" runat="server">
             <ItemTemplate>
           {y:'<%# Eval("Name") %>',a:'<%# Eval("Total") %>'}
           </ItemTemplate>
    <SeparatorTemplate>
        ,
    </SeparatorTemplate>
           </asp:Repeater>
        
      ],
      barColors: ['#00a65a'],
      xkey: 'y',
      ykeys: ['a'],
      labels: ['CPU'],
      hideHover: 'auto'
  });
        var bar = new Morris.Bar({
      element: 'bar-chart2',
      resize: true,
      data: [
           <asp:Repeater ID="rptdata2" runat="server">
             <ItemTemplate>
           {y:'<%# Eval("Name") %>',a:'<%# Eval("Total") %>'}
           </ItemTemplate>
    <SeparatorTemplate>
        ,
    </SeparatorTemplate>
           </asp:Repeater>
        
      ],
      barColors: ['#00a65a'],
      xkey: 'y',
      ykeys: ['a'],
      labels: ['CPU'],
      hideHover: 'auto'
  });


  });

</script>
</asp:Content>
