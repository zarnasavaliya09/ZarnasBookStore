2023-03-02
1505
started assignment 2 in-class on the lab computer
set up the ASP.NET MVC w/ core 3.1 (out-of-support)
HTTP enabled, individual account authentication
Reviewed the Areas folder, Controller, Model, View

1506- n Startup.cs online 33
removed options for default identity:
options => options.SignIn.RequireConfirmedAccount = true

1510
Tested app..ran it good..Tested links
Action Items:
-Modify the navigation
-update the copyright.. from 'static' to 'dynamic'

1516
Modeified the default welcome message tested..
review the rounte pattern in Startup.cs

2023-03-03
1514
confirmed the repo is build..now i want to test it..

2023-03-20
1424
its time to add bootstrap template
go to BootsWatch.com select bootstrap theme and download bootstrap.css
Add it to wwwroot>lib>bootstrap>dist>css and replace existing file with bootstrap.css
now go to Views>Shared>_Layout.cshtml, change the file name bootstrap.min.css to bootstrap.css

goto layout file  _Layout.cshtml change the file name from bootstrap.min.css to bootstrap.css.
change navigation color and footer properties

1532
add additional stylesheets and scripts from external CSS_JS.txt file
add a dropdown list to navbar tested it..it's not working

2236
added data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" 
tested again.. its working.
add three new project to current application

copy the data folder from main application and paste it to .DataAccess project.delete the original data file.
install Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages
now, delete migration folder from .DataAccess.

modify the namespace from ApplicationDbContext.
now, delete startup.cs file from all created new projects.

2023-03-10
957
move Models into .Models project and delete original.
now..add project reference to .DataAccess and .Models
rename the Models folder with ViewModels
change namespace in ErrorViewModels.cs and build project

1143
modify startup.cs file and AddContext

20230324
1043
added wrong project so need to remove that one
delete whole project backup readme.txt file from previous project and create new project.

setup the ASP.NET MVC core 3.1 out of support
HTTP enabled, individual account authentication
Reviewed the Areas folder, Controller, Model, View

in startup.cs file in line 33
removed options for default identity:
options => options.SignIn.RequireConfirmedAccount = true

tested it's working well
modify the welcome page
it's time add bootstrap template 
go to BootsWatch.com select bootstrap theme and download bootstrap.css
Add it to wwwroot>lib>bootstrap>dist>css and replace existing file with bootstrap.css
now go to Views>Shared>_Layout.cshtml, change the file name bootstrap.min.css to bootstrap.css

1118
change  the layout properties and footer properties
run the project and watch changes

add external stylesheets and scripts from external CSS_JS.txt file in layout file
add dropdown list in layout file 
tested project.. it's working...

1150
it's time to add 3 new project (.net core class library)
-DataAccess
-Models
-Utility

copy data from original project and paste it to DataAccess folder. 
install Microsoft.EntityFrameworkCore.Relational and Core.SqlServer packages
now, delete migration folder from .DataAccess.
modify the namespace in ApplicationDbContext class

delete class1.cs file from all projects
now, move models into ZarnasBookStore.Models class and delete original one

Add project reference to .DataAccess and .Models projects.
rename Models folder to ViewModels

change namespace in ErrorViewModel.cs file
then, build the project.review the browser presentation.

1225
in utility project create a static class SD.cs
Add the project reference to the main project
in DataAccess project add project reference to Models and Utility

Add a 'Customers' area to Area and change the area to customer in ScaffoldingReadMe.txt file
move HomeController.cs to the Area>Customers>Controller folder and delete Data and Model folder

edit HomeController.cs and define that the controller is in the Customer Area.
update namespace in HomeController namespace ZarnasBookStore.Area.Customer.Controllers

copy _ViewImport and _ViewStart to customer area amd modify the _ViewStart to Customer
modify the  path of _ViewStart.html

move the Views>Home
run the application..it's not working.

i find it i made Customers folder.
i made changes..

run again..it's working.
1613
Add a new Admin area in Areas
delete Data and Model folder and copy Views files from Views folder
delete Controllers folder.

1624
it's time to create Database
build the application.there are no error

view appsettings.json file
mofify the appjson file and apply migation using
>Add-migration AddDefaultIdentityMigration
migration file name  20230324204719_AddDefaultIndentityMigration.cs

change the correct default project .DataAccess and run 
review all the SQL syntax, statement, column and primary constraints

1739
update the database in migration file with datatype
write command update-database

and it's all up-to-date
Add a new table in database by creating new class file

Add new class Category.cs file in .Models project
now add migration using PM add-migration AddCategoryToDb
it's succeed

update this in ApplicationDbContext.cs
now add migration again and got duplication error..

20230330
2216
error solved.. i add the migration with different name and update the database

check the SQL server object explorer Category table created.
now create repository folder and inside the IRepository.cs

create Repository.cs file and add the namespace.
create another CategoryRepository under the folder IRepository

review the error in Category.cs and implement the interface to update
inside Category.cs implement the Repository and IRepository interfaces

20230331
0821
add new interface in IRepository folder ISP_Call.cs it extends IDisposable
install NuGet package for Dapper 

add a new class in Repository folder SP_Call.cs and implement the ISP_Call interface
add a connection to the database.
add the additional using statement and update the implementation of ISP_Call interface

add a new interface IUnitOfWork to the repository folder.
afterr add a new class and implement this interface to that class.

register it in a startup.cs in ConfigurationServices method
buid application..no error

add the controllser names CategoryController.cs inside Admin Area

20230410
1058
need to start again.i placed solution in same directory so it's not showing in githhub
need to start from first step.

did all the primary steps and add bootstrap and make changes in layout.
added theme SKETCHY

add dropdown navigation and tested again works well
added three new class library DataAccess,Models and Utility

added frmework library and delete class.cs file from all three project
add project reference and update namespace run again
working well...

1442
Add two Area Admin and customer and add the view folder and delete the controller folder
Add the migration using add-midrtion command
20230410191846_AddDefaultIdentityMigration.cs

then update the migration file and update database
review SQL server explorer

now add Category class in models folder.
add migration and update migration
review the SQL server explorer  

create Repository folder and inside Repository create interface file and also create class that implements interface

1717
now perform Category CRUD operations
add the CategoryController.cs inside the Admin area

add new index file name Index.cshtml into Views
20230411
1604
add layout path and copy the indexview code from the folder.

save and run the application
add this category into dropdown 
run and review changes

modify the index.cshtml icon in the category section and check it.
now add the category.js file into wwwroot/js folder
in index file add the @section and call the category.js file

run and review changes
20230412
0933
to activate update and delete button create New Category using Upsert action
add the IAction result in the controller and add the view as like index file 
copy and add the code from Category Updsert view

create partial view for edit and back and add the view in shared folder
now create another partial view for edit and back button and add the @model razor statement inside it.

modify the Upsert.cshtml to @title variable
add the @section call to validate input on the client side test.

2109
getting an error while loading category.cs file in browser
and not showing add category

20230413
1626
move to part 3 CoverType CRUD
create model class CoverType.cs and add the property id and name
add CoverTypeRepository class and interface

20230414
1119
modify covettypecontroller and covertyperepository
add a Product class in .DataAccess and make it public
add reference of new Product in ApplicationDbContext.cs
