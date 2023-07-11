STEP TO INSTALLATION AND TESTING THE API

1. RESTORE DATABASE MOVIEAPI.bak to SQL

3. EXECUTE QUERY CREATE AND INSERT TABLE MOVIE.SQL, CREATEADDMOVIE.sql, GETDATAMOVIE.sql, GETDETAILMOVIE.sql

2. CHANGE THE DATABASE CONNECTION IN appsettings.json and appsettings.Development.json to your SQL server user login

3. run the solution using IIS Express

4. on the url change from https://localhost:44327/api/values to https://localhost:44327/swagger/index.html

5. and you can test the APi from swagger