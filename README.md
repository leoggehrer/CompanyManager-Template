# CompanyManager

---

**Lernziele**

- Diese Vorlage dient als Ausgangspunkt für verschiedenste Demos im Unterricht.

## CompanyManager

Das Projekt **'CompanyManager'** dient als Beispiel für die Entwicklung eines datenzentrierten Software-Systems. Um die Komplexität eines solchen Systems zu veranschaulichen, ist das Beispiel in mehrere thematische Abschnitte unterteilt. Jede Lerneinheit beginnt mit dieser Vorlage und wird entsprechend der jeweiligen Aufgabenstellung weiterentwickelt.

### Vorlage

In dieser Vorlage gibt es bereits zwei verschiedene Projekte:

| Name | Beschreibung |
|------|------------- |
| CompanyManager.ConApp | Eine Konsolen-Anwendung zum Starten der Anwendung und Ausführung des Programm-Menüs. Die entsprechenden Menü-Funktionen müssen implementiert werden und sind mit *throw new NotImplementedException()* markiert. |
| CompanyManager.Logic | In diesem Projekt sind alle Schnittstellen und der Datenzugriff definiert. |
| CompanyManager.Logic.Contracts   | In diesem Abschnitt befinden sich alle Schnittstellen. |
| CompanyManager.Logic.DataContext | In diesem Abschnitt befindet sich der Data-Kontext (`CompanyManagerContext`). |

### Datenstruktur

Die Datenstruktur vom 'CompanyManager' ist einfach und besteht im Wesentlichen aus 3 Komponenten, welche in der folgenden Tabelle zusammengefasst sind:

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

