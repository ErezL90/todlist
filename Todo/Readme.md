# ToDoList

TodoList Rest API - Swagger

## 1. ConnectionString query in SQL

#### We build a new Db name like: Initial Catalog=MyDbfoobar.

```sql
SELECT
    'Data Source=' + @@SERVERNAME+ ';Initial Catalog=MyDb' +
    CASE type_desc
        WHEN 'WINDOWS_LOGIN' 
            THEN ';Trusted_Connection=true;TrustServerCertificate=true'
        ELSE
            ';user id=' + SUSER_NAME() + ';password=<<YourPassword>>'
    END
FROM sys.server_principals
WHERE name = suser_name()
```

## 2. appsettings.json
#### Paste ConnctionString in appsettings.json, Like this one -->
```json

"ConnectionStrings": {
  "DbConnection": "Data Source=DESKTOP-9QHEA1O;Initial Catalog=MyDb;trusted_connection=true;TrustServerCertificate=true;"
}

```

## 3. Package Manager Console

#### 1:
```console
add-migration Initinal
```
#### 2:
```console
update-database
```

## Run

Run Todo Api...