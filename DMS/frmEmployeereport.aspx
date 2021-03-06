﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmEmployeereport.aspx.cs" Inherits="DMS.frmEmployeereport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Data Tables
        <small>advanced tables</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Tables</a></li>
        <li class="active">Data tables</li>
      </ol>
    </section>

    <!-- Main content -->
    <section class="content">
      <div class="row">
        <div class="col-xs-12">
     

          <div class="box">
            <div class="box-header">
              <h3 class="box-title"></h3>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
              <section class="invoice">
      <!-- title row -->
      <div class="row">
        <div class="col-xs-12">
          <h2 class="page-header">
            <i class="fa fa-globe"></i> Ocean Diving Cener Report View.
            
          </h2>
        </div>
        <!-- /.col -->
      </div>
      <!-- info row -->
      <div class="row invoice-info">
        <div class="col-sm-4 invoice-col">
          
          <address>
            <strong>Ocean Diving Cener.</strong><br>
            795 Unawatuna,Galle<br>
            Sri Lanka<br>
            Phone: (+94) 713921800<br>
            Email: info@oceandiving.com
          </address>
        </div>
        <!-- /.col -->
        <div class="col-sm-4 invoice-col">
         
        </div>
        <!-- /.col -->
       
        <!-- /.col -->
      </div>
      <!-- /.row -->

      <!-- Table row -->
      <div class="row">
        <div class="col-xs-12 table-responsive">
          <table class="table table-striped">
             <thead>
                <tr>
                  
                  <th>Employee Name</th>
                  <th>Employee Address</th>
                  <th>Employee Jobtype</th>
                  <th>Employee Basicsal</th>
                  <th></th>
                </tr>
                </thead>
                 <tbody>
                <span id="divInnerHtml" runat="server"></span>
                </tbody>
          </table>
        </div>
        <!-- /.col -->
      </div>
                  
    </section>
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->
        </div>
        <!-- /.col -->
      </div>
      <!-- /.row -->
    </section>
    <!-- /.content -->
  </div>
</asp:Content>
