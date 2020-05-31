<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmAddCourse.aspx.cs" Inherits="DMS.frmAddCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Add Course 
        <small>Add</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Course </a></li>
        <li class="active">Add>
      </ol>
        <section class="content">
                <!-- SELECT2 EXAMPLE -->
      <div class="box box-default">
        <div class="box-header with-border">
          <h3 class="box-title">Add New Course</h3>

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
                <label>Course Code</label>
                  <asp:TextBox type="text" class="form-control" id="CourseCode" placeholder="Enter Course Code" runat="server"></asp:TextBox>
                
              </div>
              <!-- /.form-group -->
              <div class="form-group">
                <label>Course Name</label>
                <asp:TextBox type="text" class="form-control" id="CourseName" placeholder="Enter Course Name" runat="server"></asp:TextBox>
               
              </div>
                  <div class="form-group">
                <label>Cource Duration</label>
                     
                   <asp:TextBox type="text" class="form-control" id="CourceDuration" placeholder="Enter Cource Duration" runat="server"></asp:TextBox>
              </div>
              <!-- /.form-group -->
            
            </div>
            <!-- /.col -->
            <div class="col-md-6">
              
              
                <div class="form-group">
                <label>Cource Price</label>
                    <asp:TextBox type="number" class="form-control" id="CourcePrice" placeholder="Enter Cource Price" runat="server"></asp:TextBox>
         
              </div>
              <!-- /.form-group -->
              <div class="form-group">
                <label>Description</label>
                  <asp:TextBox type="text" class="form-control" id="Description" placeholder="Enter Description" runat="server"></asp:TextBox>
             
              </div>
            </div>
            <!-- /.col -->
          </div>
          <!-- /.row -->
        </div>
        <!-- /.box-body -->
          <div class="box-footer">
                    <asp:Button type="submit" class="btn btn-primary" runat="server" ID="btnsubmitCource" Text="Submit" OnClick="btnsubmitCource_Click"  />
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
                  <th>Course Code</th>
                  <th>Course Name</th>
                  <th>Course duration</th>
                  <th>Course price</th>
                  <th>Description</th>
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
