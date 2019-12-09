# Parcel Delivery Company System 
## (made in Visual C Sharp)


### Eng (English)

A WinForms project which I have developed in C# for .NET Framework 4.5.1.

More details in english soon.

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

Program posiada możliwość wyświetlania mapy z zaznaczonymi miejscami docelowych adresatów przesyłek (przedstawionych w postaci markerów), oraz narysowania drogi dojazdu. Program posiada dwa sposoby rysowania dróg:
1. Według kolejności znaczników na liście (markers list)
2. Obliczenie najkrótszej ścieżki.

W trybie dostarczania przesyłek (drugi tryb to transport przesyłek pomiędzy punktami firmowymi), każdy ze sposobów zakłada, że droga rozpoczyna się i kończy w tym samym punkcie firmowym. Dodatkowo, drugi sposób rysowania drogi wykorzystuje algorytm rozwiązywania problemu komiowjażera, do określenia najkrótszej ścieżki.
