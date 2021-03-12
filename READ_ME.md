#readMe

## STEPS WHEN SETTING UP THE ENVIRONNMENT

#install the database server for local use
#install node. it is heavily used in JS frameworks, even though in the future we will use Deno

create an asp.net webapi  file 


#Enable Cors for the UI/ front end

*the way to enable cors is to place this line of code into the package manager console*

```Install-Package Microsoft.AspNet.WebApi.Cors```

*Next, once that is all installed , add a using on the top of the `WebApiConfig` file to make sure rtgar cors will be used* 

```config.EnableCors(new EnableCorsAttribute("*", "*", "*"));```


## Create The Models

### department & employee

here you will create a model for each table with the fields as the names of the different feilds in the  database.


### Api for the depatment screen

    * in order to avoid sql injection, we use stored procedures tot get the values from the database.



    * the following code goes bellow the logic for getting the row in the database
    
```   using(var con = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString))
                using (var cmd = new SqlCommand(qry,con))
                using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
```