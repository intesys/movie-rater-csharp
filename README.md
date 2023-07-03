# Movie Rater

Movie Rater è un'applicazione web che mostra ai visitatori 2 film scelti in modo casuale e permette loro di scegliere 
il preferito tra i 2. Ogni volta che un utente vota uno dei 2 film l'applicazione aggiorna il contatore dei voti per il singolo film e propone altri 2 film sempre scelti in maniera casuale nel database.

## Dettagli Tecnici

- ASP.NET Core 7.0
- ASP.NET Core Web App (MVC) con Entity Framework
- [MaterializeCSS](https://materializecss.com/) per il frontend 
- Database SQLite già creato e popolato tramite migration. Vedi il file: MovieRaterWebAppContext-07197c0f-430b-42bb-9703-c7b2ec004527.db
- Visual Studio 2022 con [SQLite and SQL Server Compact Toolbox](https://marketplace.visualstudio.com/items?itemName=ErikEJ.SQLServerCompactSQLiteToolbox)

## Avvio dell'applicazione

Una volta ottenuto il codice effettuare il rebuild della solution.
E' incluso un file appsettings.json contenente la configurazione per il database locale. 

## Consegna del codice

Clonare questo repository e committare i singoli task. Al termine della sessione di lavoro consegnare il codice al referente Intesys:
1. inviando al referente Intesys il progetto un link al file .zip contenente la cartella .git (evitare zip via email, vengono rifiutati)
2. oppure creando un repository privato su github e condividendolo con l'account github del referente

## Task

Si richiede quindi di implementare le seguenti funzionalità:

1. Implementare il metodo `MoviesService#GetMovieCount` per ritornare al frontend il numero totale di film del database
2. Implementare il metodo `MoviesService#Get2RandomMovies` per prendere 2 film random dal database
3. Altri task scelti e inviati dal referente Intesys


## Elementi considerati per la valutazione

- correttezza della soluzione
- numero di task completati
- performance
- pulizia del codice
- versionamento dei sorgenti
- tempo di svolgimento

## Note
Per rendere il processo di selezione equo per tutti, si prega di non condividere con nessuno questo assignment o la soluzione proposta.



