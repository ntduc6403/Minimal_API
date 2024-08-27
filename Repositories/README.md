# Game Store API
<!-- chay lenh docker -->
## Starting SQL Sever
```powershell
$sa_password = "[SA PASSWORD HERE]"
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD= $sa_password" -e "MSSQL_PID=Evaluation" -p 1433:1433 
-v sqlvolume:/var/opt/mssql --rm --name mssql -d mcr.microsoft.com/mssql/server:2022-preview-ubuntu-22.04
