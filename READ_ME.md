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


## Api for the depatment screen

