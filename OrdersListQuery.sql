SELECT z.Id_zlecenia AS 'Numer zlecenia', 
k.Id_klienta AS 'Id klienta', k.Imie AS 'Imię', k.Nazwisko, k.Ulica, k.Nr_domu AS 'Nr domu', 
k.Nr_mieszkania AS 'Nr mieszkania', k.Miasto, k.Kod_pocztowy AS 'Kod pocztowy',
z.Id_kuriera AS 'Kurier obsługujący zlecenie' 
FROM Zlecenie z 
INNER JOIN Klient k ON z.Id_klienta=k.Id_klienta 
WHERE Id_zlecenia = 1;