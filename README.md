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

- `Microsoft.EntityFrameworkCore.Sqlite`  
- `Newtonsoft.Json`

Tyto balíčky nainstalujete pomocí příkazů:

```bash
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Newtonsoft.Json
```

---

## Spuštění aplikace

1. Otevřít terminál v kořenové složce projektu
2. Spusťte aplikaci příkazem:

```bash
dotnet run
```

---

##Poznámka

Při prvním spuštění se automaticky vytvoří databázový soubor `wario.db`. Pokud změníte strukturu datových entit, je nutné tento soubor smazat, aby se při dalším spuštění vytvořil nový, a předešlo se tak chybám.

Aplikace byla vytvořena cca za 3 hodiny a autorem je Jan Kovařčík
