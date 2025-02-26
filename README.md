# CompanyManager

**Lernziele:**

- Diese Vorlage dient als Ausgangspunkt für verschiedenste Demos/Ausbaustufen im Unterricht.

## Projektbeschreibung

Das Projekt **'CompanyManager'** dient als Beispiel für die Entwicklung eines datenzentrierten Software-Systems. Um die Komplexität eines solchen Systems zu veranschaulichen, ist das Beispiel in mehrere thematische Abschnitte unterteilt. Jede Lerneinheit beginnt mit dieser Vorlage und wird entsprechend der jeweiligen Aufgabenstellung weiterentwickelt.

### Vorlage

In dieser Vorlage gibt es bereits drei verschiedene Projekte:

| Name | Beschreibung | Typ |
|------|------------- |-----|
| **CompanyManager.Common**        | In diesem Projekt werden alle Klassen gesammelt, die in anderen Projekten verwendet werden (Schnittstellen, Hilfsfunktionen usw.). | Bibliothek |
| CompanyManager.Common.Contracts  | In diesem Abschnitt befinden sich alle Schnittstellen für die Date-Objekte. | Bibliothek |
| **CompanyManager.Logic**         | In diesem Projekt sind alle Schnittstellen und der Datenzugriff definiert. | Bibliothek |
| CompanyManager.Logic.Contracts   | In diesem Abschnitt befinden sich alle Schnittstellen. | Bibliothek |
| CompanyManager.Logic.DataContext | In diesem Abschnitt befindet sich der Data-Kontext (`CompanyManagerContext`). | Bibliothek |
| **CompanyManager.ConApp**        | Konsolenanwendung zum Starten des Programms und zur Implementierung des Menüsystems. Menüfunktionen sind mit *throw new NotImplementedException()* markiert. | Konsolenanwendung |

#### Systemstruktur

Die einzelnen Projekte sind miteinander verbunden und bilden ein System, das in der Lage ist, Daten zu verwalten. Die Struktur des Systems ist in der folgenden Abbildung zusammengefasst:

![Systemstructure (PA)](http://www.plantuml.com/plantuml/proxy?cache=no&src=https://raw.githubusercontent.com/leoggehrer/CompanyManager-Template/master/diagrams/systemstructure.puml)

**Erklärung:** Das Projekt ***CompanyManager.Common*** wird von den Projekten **CompanyManager.ConApp** und **CompanyManager.Logic** importiert. Das Importieren erfolgt in der jeweiligen Projekt-Datei. Hier der Auszug aus der Projekt-Datei ***CompanyManager.Logic.csproj***:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\CompanyManager.Common\CompanyManager.Common.csproj" />
  </ItemGroup>

</Project>
```

### Datenstruktur

Die Datenstruktur von 'CompanyManager' ist einfach und besteht im Wesentlichen aus 3 Komponenten, welche in der folgenden Tabelle zusammengefasst sind:

| Komponente   | Beschreibung                                                  | Größe | Mussfeld | Eindeutig |
| ------------ | ------------------------------------------------------------- | ----- | -------- | --------- |
| **Company**  |                                                               |       |          |           |
| *Name*       | Name der Firma                                                | 256   | Ja       | Ja        |
| *Address*    | Adresse der Firma                                             | 1024  | Nein     | Nein      |
| **Customer** |                                                               |       |          |           |
| *CompanyId*  | Fremdschlüssel zur Firma                                      | int   | Ja       | Nein      |
| *Name*       | Name des Kunden                                               | 256   | Ja       | Ja        |
| *Email*      | E-Mail-Adresse des Kunden                                     | 128   | Ja       | Ja        |
| **Employee** |                                                               |       |          |           |
| *CompanyId*  | Fremdschlüssel zur Firma                                      | int   | Ja       | Nein      |
| *FirstName*  | Vorname des Mitarbeiters                                      | 64    | Nein     | Nein      |
| *LastName*   | Nachname des Mitarbeiters                                     | 64    | Nein     | Nein      |
| *Email*      | E-Mail-Adresse des Kunden                                     | 128   | Ja       | Ja        |
| **Hinweis**  | Alle Komponenten haben eine eindeutige Identität (Id)         |       |          |           |
| \*           | *Natürlich können noch weitere Attribute hinzugefügt werden.* |       |          |           |

Aus dieser Definition kann ein entsprechendes Objektmodell abgeleitet werden, welches nachfolgend skizziert ist:

| Komponente   | Relation | Komponente |
| ------------ | -------- | ---------- |
| **Company**  | 1:n      | Customer   |
| **Company**  | 1:n      | Employee   |
| **Customer** | 1:1      | Company    |
| **Employee** | 1:1      | Company    |

### Ausbaustufen und Dokumentation

| Ausbaustufe | Beschreibung | Level | Link |
|-------------|--------------|-------|------|
| **Stufe 1**  | Erstellen der Entitäten und Anbindung an die Datenbank | Junior | [Demo](https://github.com/leoggehrer/CompanyManagerWithSqlite) |
| **Stufe 2**  | Hinzufügen und Verwendung von `AppSettings` | Junior | [Demo](https://github.com/leoggehrer/CompanyManagerWithSettings) |
| **Stufe 2.A**  | Hinzufügen und Verwendung von `AppSettings` mit generischen EntitySet<...> | Senior | [Demo](https://github.com/leoggehrer/CompanyManagerWithLogicGeneric) |
| **Stufe 3**  | Hinzufügen eines WebApi-Projektes für die REST-Operationen | Junior | [Demo](https://github.com/leoggehrer/CompanyManagerWithWebApi) |
| **Stufe 4**  | Abfragen und Bearbeitung von Daten mit der REST-Api | Junior | [Demo](https://github.com/leoggehrer/CompanyManagerWithRestConApp) |

### Testen des Systems

- keine Angaben

## Hilfsmittel

- keine Angaben

## Abgabe

- Termin: 1 Woche nach der Ausgabe

- Klasse:

- Name:

## Quellen

- keine Angabe

> **Viel Erfolg!**

