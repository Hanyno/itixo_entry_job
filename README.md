# ITIXO Entry Job

Tato jednoduchá konzolová aplikace pravidelně stahuje data o meteostanici z externího XML zdroje, převádí je do formátu JSON a ukládá je do lokální SQLite databáze.

Aplikace běží v nekonečné smyčce a data aktualizuje každou hodinu.

---

## Potřebné nástroje

- **.NET SDK** verze 6.0 nebo novější  
- Integrované vývojové prostředí (IDE), např. **Visual Studio** nebo **Visual Studio Code**

---

## Instalace závislostí

Ve složce projektu musí být nainstalované NuGet balíčky:

- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.Design`
- `Microsoft.EntityFrameworkCore.Sqlite`
- `Microsoft.EntityFrameworkCore.Tools`
- `Microsoft.Extensions.Configuration`
- `Microsoft.Extensions.Configuration.FileExtensions`
- `Microsoft.Extensions.Configuration.Json`
- `Microsoft.Extensions.Hosting`
- `Newtonsoft.Json`


Tyto balíčky nainstalujete pomocí příkazů:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.Configuration.FileExtensions
dotnet add package Microsoft.Extensions.Configuration.Json
dotnet add package Microsoft.Extensions.Hosting=
dotnet add package Newtonsoft.Json
```

---

## Spuštění aplikace

1. Otevřít terminál v kořenové složce projektu
2. Vytvořit migraci:

```bash
dotnet ef migrations add InitialCreate
```

3. Vytvořit databázi a tabulky:

```bash
dotnet ef database update
```

4. Spustit aplikaci:

```bash
dotnet run
```

---

## Poznámka

Aplikace byla vytvořena cca za 10 hodin (4 první verze, 6 oprava dle code review) a autorem je Jan Kovařčík
