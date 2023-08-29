## Bibliothek API mit .NET 8

- Authentifizierung
- Autorisierung
- Security
- Tests

## Überblick über die API

### Ausweisverwaltung

- Benutzerverwaltung 
  - Ausweis beantragen
  - Ausweis löschen

### Bestandsverwaltung

- Buch erfassen
  - Spende, Kauf ...
- Bücher ändern
- Bücher aus dem Bestand nehmen

### Ausleihe

- Buch ausleihen
- Buch zurückgeben
  - Schäden erfassen
- Ausgeliehene Buch verlängern
- Strafzahlung bei Verspätung

### Suche / Stöbern

- Liste aller Bücher
- Suche aller Bücher (Titel, Autor:in, ISBN, ...)
- Vorschläge für potenziell interessante Bücher
  - Pagination

### Commands

- Buch erfassen
- Buch ausleihen

### Queries

- Alle Bücher

## Server starten

Als Port wird `5000` verwendet.

## Den Server aufrufen

### Buch erfassen

```shell
$ curl \
    -i \
    -X POST \
    -H "Content-Type: application/json" \
    -d '{"title": "...", "author": "..."}' \
    https://localhost:5000/bestand/erfasse-buch
```

### Buch ausleihen

```shell
$ curl \
    -i \
    -X POST \
    -H "Content-Type: application/json" \
    -d '{"id": "..."}' \
    https://localhost:5000/ausleihe/leihe-buch-aus
```

### Liste aller Bücher abrufen

```shell
$ curl \
    -i \
    -X GET \
    https://localhost:5000/bestand/buecher
```