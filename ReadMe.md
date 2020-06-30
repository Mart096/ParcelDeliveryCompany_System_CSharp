# Parcel Delivery Company System 
## (made in Visual C Sharp)


### Eng (English)

A WinForms application which I have developed as part of my graduation project in C# for .NET Framework 4.5.1. <br>
This application is using Microsoft SQL Server 2017 for data storage and access. Database backup with example data is <br>
attached with project files (NOTE: database tables and their columns are defined in Polish).

The project was divided in two applications:
- Admin application (dedicated to administrators, unlimited access to all functions, still user has to sign in first <br>
  in order to use it);
- Employee application (dedicated to employees with restrictions on specific functions depending on user's role) ;

Current version of application supports the following roles:
1. Admin
2. Courier
3. Dispatcher
4. Customer communications (i.e. employee responsible for order registration over the phone)
5. Complaint department employee

A main feature of this application is map display with consignees' destination markers on it and route determination between them.
There are two route determination methods implemented:
1. In order of markers on the list.
2. Travelling salesman problem solving algorithm (shortest route determination).

### PL (Polski)

Projekt WinForms, który opracowałem w ramach pracy dyplomowej z użyciem języka programowania C#, na platformie docelowej .NET Framework 4.5.1. <br>
Do przechowywania danych przetwarzanych przez program, został wykorzystany system zarządzania bazą danych Microsoft SQL Server 2017. <br>
Projekt został podzielony na dwie aplikacje:
- Aplikacja dla administratorów,
- Aplikacja dla pracowników.

Celem tego zabiegu było wprowadzenie zarządzania uprawnieniami do wybranych funkcjonalności programu, dla użytkowników posiadających jedną z pięciu ról:
1. Administrator
2. Kurier
3. Dyspozytor
4. Pracownik ds. komunikacji z klientem (odpowiedzialny za dodawanie do systemu zleceń klientów, np. w wyniku rozmowy telefonicznej)
5. Pracownik działu reklamacji

Program posiada możliwość wyświetlania mapy z zaznaczonymi miejscami docelowych adresatów przesyłek (przedstawionych w postaci markerów), <br>
oraz narysowania drogi dojazdu. Program posiada dwa sposoby rysowania dróg:
1. Według kolejności znaczników na liście (markers list)
2. Wykorzystujący algorytm rozwiązywania problemu komiwojażera (obliczenie najkrótszej ścieżki).

W trybie dostarczania przesyłek (drugi tryb to transport przesyłek pomiędzy punktami firmowymi), każdy ze sposobów zakłada, że droga rozpoczyna się i <br>
kończy w tym samym punkcie firmowym. Dodatkowo, drugi sposób rysowania drogi wykorzystuje algorytm rozwiązywania problemu komiowjażera, do określenia <br>
najkrótszej ścieżki.
